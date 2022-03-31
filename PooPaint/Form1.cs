using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooPaint
{
    public partial class Form1 : Form
    {
        private MyImage myImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picUpdateV2()
        {
            pictureBox1.Image = myImage.currentImg;
            pictureBox1.Width = (int)(myImage.currentImg.Width);
            pictureBox1.Height = (int)(myImage.currentImg.Height);

            widthLabel.Text = myImage.currentImg.Width.ToString();
            heightLabel.Text = myImage.currentImg.Height.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myImage.AddFilter(new NNFilter());
            picUpdateV2();
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(myImage.originalImg);
            myImage = new MyImage(bitmap);
            picUpdateV2();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            myImage.RemoveLastFilter();
            picUpdateV2();
        }


        private void blackWhiteButton_Click(object sender, EventArgs e)
        {
            myImage.AddFilter(new WBlackFilter());
            picUpdateV2();
        }

        private void mirrorButton_Click(object sender, EventArgs e)
        {
            myImage.AddFilter(new MirrVFilter());
            picUpdateV2();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    pictureBox1.Image.Save(fs,System.Drawing.Imaging.ImageFormat.Bmp);
                    fs.Dispose();
                }
            }
        }

        private void wMirrorButton_Click(object sender, EventArgs e)
        {
            myImage.AddFilter(new MirrHFilter());
            picUpdateV2();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void filterSetButton_Click(object sender, EventArgs e)
        {
            Filter lFilter = new Filter(textBox1.Text, textBox2.Text, textBox3.Text, 
                textBox4.Text, textBox5.Text, textBox6.Text, 
                textBox7.Text, textBox8.Text, textBox9.Text);
            myImage.AddFilter(lFilter);
            picUpdateV2();
        }

        private void button4_Click_1(object sender, EventArgs e)//BlureB
        {
            myImage.AddFilter(new BlurFilter());
            picUpdateV2();
        }

        private void button5_Click(object sender, EventArgs e)
        {//bilineal
            myImage.AddFilter(new BilinealFilter());
            picUpdateV2();
        }

        private void sharpButton_click(object sender, EventArgs e)
        {
            myImage.AddFilter(new SharpnessFilter());
            picUpdateV2();
        }

        private void bordersButton_Click(object sender, EventArgs e)
        {
            myImage.AddFilter(new BordersFilter());
            picUpdateV2();
        }

        private void pseudoToneButton_Click(object sender, EventArgs e)
        {
            myImage.AddFilter(new PsToneFilter());
            picUpdateV2();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {//Embross
            myImage.AddFilter(new EmbrosFilter());
            picUpdateV2();
        }

        private void button6_Click(object sender, EventArgs e)
        {//Canny
            myImage.AddFilter(new CannyFilter());
            picUpdateV2();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Load
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myImage = new MyImage(new Bitmap(openFileDialog1.FileName, true));
                
                pictureBox1.Size = myImage.currentImg.Size;
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = myImage.currentImg;
            }
            picUpdateV2();
        }

        private void button7_Click(object sender, EventArgs e)
        {//RndDithering
            myImage.AddFilter(new RandomDitheringFilter());
            picUpdateV2();
        }

        private void button8_Click(object sender, EventArgs e)
        {//Noise
            myImage.AddFilter(new NoiseFilter());
            picUpdateV2();
        }

        private void button9_Click(object sender, EventArgs e)
        {//GrayWorld
            myImage.AddFilter(new GrayWorldFilter());
            picUpdateV2();
        }

        private void aLevelButton_Click(object sender, EventArgs e)
        {
            myImage.AddFilter(new AutoLvlFilter());
            picUpdateV2();
        }

        private void psnrButton_Click(object sender, EventArgs e)
        {
            string str = Metrics.PSNR(myImage.currentImg);
            MessageBox.Show(str);
        }

        private void medianButton_Click(object sender, EventArgs e)
        {
            myImage.AddFilter(new MedianFilter());
            picUpdateV2();
        }

        private void erosionButton_Click(object sender, EventArgs e)
        {
            myImage.AddFilter(new ErosionFilter());
            picUpdateV2();
        }

        private void button10_Click(object sender, EventArgs e)
        {//Dilation
            myImage.AddFilter(new DilationFilter());
            picUpdateV2();
        }

        private void openingButton_Click(object sender, EventArgs e)
        {
            myImage.AddFilter(new OpeningFilter());
            picUpdateV2();
        }

        private void closeingButton_Click(object sender, EventArgs e)
        {
            myImage.AddFilter(new ClosingFilter());
            picUpdateV2();
        }
    }
}
