using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PooPaint
{
    public class Canny
    {

        public static Bitmap MakeGrayscale(Bitmap original)
        {
            try
            {
                Color originalColor;
                Color newColor;
                Bitmap newBitmap = new Bitmap(original.Width, original.Height);

                for (int i = 0; i < original.Width; i++)
                    for (int j = 0; j < original.Height; j++)
                    {
                        // get the pixels from the original image
                        originalColor = original.GetPixel(i, j);
                        // create the gray scale version of each pixel
                        int grayScale = (int)((originalColor.R * 0.3) + (originalColor.G * 0.59) + (originalColor.B * 0.11));
                        newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                return newBitmap;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static Bitmap DetectEdge(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            int xleft;
            int xright;
            int ytop;
            int ybot;
            double gx;
            double gy;
            double tempAngle;
            Color color1, color2;
            double[,] magnitudes = new double[original.Width, original.Height];
            double[,] angles = new double[original.Width, original.Height];
            bool[,] isEdge = new bool[original.Width, original.Height];
            double maxMag = 0;

            // traverse every pixel
            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    xleft = i - 1;
                    xright = i + 1;
                    ytop = j - 1;
                    ybot = j + 1;

                    // check bounds
                    // if out of bounds, get reflected value
                    if (xleft < 0)
                        xleft = xright;
                    if (xright > original.Width - 1)
                        xright = xleft;
                    if (ytop < 0)
                        ytop = ybot;
                    if (ybot > original.Height - 1)
                        ybot = ytop;

                    // compute x gradient magnitude
                    color1 = original.GetPixel(xright, j);
                    color2 = original.GetPixel(xleft, j);
                    gx = (color1.R - color2.R) / 2;

                    // compute y gradient magnitude
                    color1 = original.GetPixel(i, ybot);
                    color2 = original.GetPixel(i, ytop);
                    gy = (color1.R - color2.R) / 2;

                    // store magnitudes
                    magnitudes[i, j] = Math.Abs(gx) + Math.Abs(gy);
                    if (magnitudes[i, j] > maxMag)
                        maxMag = magnitudes[i, j];

                    // need to round angles and then store angles
                    tempAngle = Math.Atan(gy / gx);
                    // convert from radians to degrees
                    tempAngle = tempAngle * 180 / Math.PI;

                    // θ in [0°, 22.5°] or [157.6°, 180°] maps to 0°.
                    if ((tempAngle >= 0 && tempAngle < 22.5) || (tempAngle > 157.5 && tempAngle <= 180) || (tempAngle <= 0 && tempAngle > -22.5) || (tempAngle < -157.5 && tempAngle >= -180))
                        tempAngle = 0.0;
                    // θ in [22.6°, 67.4°] maps to 45°.
                    else if ((tempAngle > 22.5 && tempAngle < 67.5) || (tempAngle < -22.5 && tempAngle > -67.5))
                        tempAngle = 45.0;
                    // θ in [67.5°, 112.5°] maps to 90°.
                    else if ((tempAngle > 67.5 && tempAngle < 112.5) || (tempAngle < -67.5 && tempAngle > -112.5))
                        tempAngle = 90.0;
                    // θ in [112.6°, 157.5°] maps to 135°.
                    else if ((tempAngle > 112.5 && tempAngle < 157.5) || (tempAngle < -112.5 && tempAngle > -157.5))
                        tempAngle = 135.0;

                    angles[i, j] = tempAngle;
                }

            // now need to check neighboring magnitudes of every pixel
            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    // if gradient angle is 0°, is edge if its gradient magnitude is greater than the magnitudes at pixels @ the left and right
                    // if gradient angle is 90°, is edge if its gradient magnitude is greater than the magnitudes at pixels @ the top and bot
                    // if gradient angle is 135°, is edge if its gradient magnitude is greater than the magnitudes at pixels @ the topleft and botright
                    // if gradient angle is 45°, is edge if its gradient magnitude is greater than the magnitudes at pixels @ the topright and botleft
                    if ((i - 1 < 0 || i + 1 > original.Width - 1 || j - 1 < 0 || j + 1 > original.Height - 1))
                    {
                        isEdge[i, j] = false;
                    }
                    else if (angles[i, j] == 0.0)
                    {

                        if (magnitudes[i, j] > magnitudes[i - 1, j] && magnitudes[i, j] > magnitudes[i + 1, j])
                            isEdge[i, j] = true;
                        else
                            isEdge[i, j] = false;
                    }
                    else if (angles[i, j] == 90.0)
                    {

                        if (magnitudes[i, j] > magnitudes[i, j - 1] && magnitudes[i, j] > magnitudes[i, j + 1])
                            isEdge[i, j] = true;
                        else
                            isEdge[i, j] = false;
                    }
                    else if (angles[i, j] == 135.0)
                    {

                        if (magnitudes[i, j] > magnitudes[i - 1, j - 1] && magnitudes[i, j] > magnitudes[i + 1, j + 1])
                            isEdge[i, j] = true;
                        else
                            isEdge[i, j] = false;
                    }
                    else if (angles[i, j] == 45.0)
                    {
                        if (magnitudes[i, j] > magnitudes[i + 1, j - 1] && magnitudes[i, j] > magnitudes[i - 1, j + 1])
                            isEdge[i, j] = true;
                        else
                            isEdge[i, j] = false;
                    }
                }

            double lowerThreshold = maxMag * 0.10;

            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    // if edge
                    if (isEdge[i, j] && magnitudes[i, j] > lowerThreshold)
                    {
                        // check pixels in the direction of the edge
                        // if either or both have 
                        // the same angle as [i, j]
                        // magnitude is > than lower threshold
                        // then mark as edge
                        if (angles[i, j] == 0.0)
                        {
                            if (angles[i, j] == angles[i - 1, j] || angles[i, j] == angles[i + 1, j])
                            {
                                if (magnitudes[i - 1, j] > lowerThreshold)
                                    newBitmap.SetPixel(i - 1, j, Color.White);
                                else
                                    newBitmap.SetPixel(i - 1, j, Color.Black);

                                if (magnitudes[i + 1, j] > lowerThreshold)
                                    newBitmap.SetPixel(i + 1, j, Color.White);
                                else
                                    newBitmap.SetPixel(i + 1, j, Color.Black);
                            }
                        }
                        else if (angles[i, j] == 90.0)
                        {
                            if (angles[i, j] == angles[i, j - 1] || angles[i, j] == angles[i, j + 1])
                            {
                                if (magnitudes[i, j - 1] > lowerThreshold)
                                    newBitmap.SetPixel(i, j - 1, Color.White);
                                else
                                    newBitmap.SetPixel(i, j - 1, Color.Black);

                                if (magnitudes[i, j + 1] > lowerThreshold)
                                    newBitmap.SetPixel(i, j + 1, Color.White);
                                else
                                    newBitmap.SetPixel(i, j + 1, Color.Black);
                            }
                        }
                        else if (angles[i, j] == 135.0)
                        {
                            if (angles[i, j] == angles[i - 1, j - 1] || angles[i, j] == angles[i + 1, j + 1])
                            {
                                if (magnitudes[i - 1, j - 1] > lowerThreshold)
                                    newBitmap.SetPixel(i - 1, j - 1, Color.White);
                                else
                                    newBitmap.SetPixel(i - 1, j - 1, Color.Black);

                                if (magnitudes[i + 1, j + 1] > lowerThreshold)
                                    newBitmap.SetPixel(i + 1, j + 1, Color.White);
                                else
                                    newBitmap.SetPixel(i + 1, j + 1, Color.Black);
                            }
                        }
                        else if (angles[i, j] == 45.0)
                        {
                            if (angles[i, j] == angles[i + 1, j - 1] || angles[i, j] == angles[i - 1, j + 1])
                            {
                                if (magnitudes[i + 1, j - 1] > lowerThreshold)
                                    newBitmap.SetPixel(i + 1, j - 1, Color.White);
                                else
                                    newBitmap.SetPixel(i + 1, j - 1, Color.Black);

                                if (magnitudes[i - 1, j + 1] > lowerThreshold)
                                    newBitmap.SetPixel(i - 1, j + 1, Color.White);
                                else
                                    newBitmap.SetPixel(i - 1, j + 1, Color.Black);
                            }
                        }
                    }
                    else
                        newBitmap.SetPixel(i, j, Color.Black);
                }

            return newBitmap;
        }
    }
}
