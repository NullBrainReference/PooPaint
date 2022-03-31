namespace PooPaint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ComeBackButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.filterSetButton = new System.Windows.Forms.Button();
            this.blackWhiteButton = new System.Windows.Forms.Button();
            this.mirrorButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.wMirrorButton = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sharpButton = new System.Windows.Forms.Button();
            this.bordersButton = new System.Windows.Forms.Button();
            this.pseudoToneButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.aLevelButton = new System.Windows.Forms.Button();
            this.psnrButton = new System.Windows.Forms.Button();
            this.medianButton = new System.Windows.Forms.Button();
            this.erosionButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.openingButton = new System.Windows.Forms.Button();
            this.closeingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(107, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "neibours zoom";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ComeBackButton
            // 
            this.ComeBackButton.Location = new System.Drawing.Point(12, 69);
            this.ComeBackButton.Name = "ComeBackButton";
            this.ComeBackButton.Size = new System.Drawing.Size(89, 23);
            this.ComeBackButton.TabIndex = 3;
            this.ComeBackButton.Text = "Undo All";
            this.ComeBackButton.UseVisualStyleBackColor = true;
            this.ComeBackButton.Click += new System.EventHandler(this.ComeBackButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 98);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(89, 23);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // filterSetButton
            // 
            this.filterSetButton.Location = new System.Drawing.Point(21, 227);
            this.filterSetButton.Name = "filterSetButton";
            this.filterSetButton.Size = new System.Drawing.Size(72, 23);
            this.filterSetButton.TabIndex = 7;
            this.filterSetButton.Text = "set";
            this.filterSetButton.UseVisualStyleBackColor = true;
            this.filterSetButton.Click += new System.EventHandler(this.filterSetButton_Click);
            // 
            // blackWhiteButton
            // 
            this.blackWhiteButton.Location = new System.Drawing.Point(330, 11);
            this.blackWhiteButton.Name = "blackWhiteButton";
            this.blackWhiteButton.Size = new System.Drawing.Size(75, 23);
            this.blackWhiteButton.TabIndex = 8;
            this.blackWhiteButton.Text = "W/B";
            this.blackWhiteButton.UseVisualStyleBackColor = true;
            this.blackWhiteButton.Click += new System.EventHandler(this.blackWhiteButton_Click);
            // 
            // mirrorButton
            // 
            this.mirrorButton.Location = new System.Drawing.Point(256, 12);
            this.mirrorButton.Name = "mirrorButton";
            this.mirrorButton.Size = new System.Drawing.Size(68, 23);
            this.mirrorButton.TabIndex = 9;
            this.mirrorButton.Text = "mirror H";
            this.mirrorButton.UseVisualStyleBackColor = true;
            this.mirrorButton.Click += new System.EventHandler(this.mirrorButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 40);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // wMirrorButton
            // 
            this.wMirrorButton.Location = new System.Drawing.Point(256, 40);
            this.wMirrorButton.Name = "wMirrorButton";
            this.wMirrorButton.Size = new System.Drawing.Size(68, 23);
            this.wMirrorButton.TabIndex = 9;
            this.wMirrorButton.Text = "mirror W";
            this.wMirrorButton.UseVisualStyleBackColor = true;
            this.wMirrorButton.Click += new System.EventHandler(this.wMirrorButton_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 292);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(32, 13);
            this.widthLabel.TabIndex = 11;
            this.widthLabel.Text = "width";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(12, 305);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(36, 13);
            this.heightLabel.TabIndex = 11;
            this.heightLabel.Text = "height";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 94);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "filter core";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(58, 71);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(20, 20);
            this.textBox9.TabIndex = 13;
            this.textBox9.Text = "0";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(58, 45);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(20, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "-1";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(58, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(20, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "0";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(32, 71);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(20, 20);
            this.textBox8.TabIndex = 13;
            this.textBox8.Text = "-1";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(32, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(20, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "4";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(20, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "-1";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 71);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(20, 20);
            this.textBox7.TabIndex = 13;
            this.textBox7.Text = "0";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(20, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "-1";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "0";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(411, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Blur";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Bilineal zoom";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sharpButton
            // 
            this.sharpButton.Location = new System.Drawing.Point(411, 39);
            this.sharpButton.Name = "sharpButton";
            this.sharpButton.Size = new System.Drawing.Size(75, 23);
            this.sharpButton.TabIndex = 13;
            this.sharpButton.Text = "Sharpnes";
            this.sharpButton.UseVisualStyleBackColor = true;
            this.sharpButton.Click += new System.EventHandler(this.sharpButton_click);
            // 
            // bordersButton
            // 
            this.bordersButton.Location = new System.Drawing.Point(492, 11);
            this.bordersButton.Name = "bordersButton";
            this.bordersButton.Size = new System.Drawing.Size(75, 23);
            this.bordersButton.TabIndex = 15;
            this.bordersButton.Text = "Borders";
            this.bordersButton.UseVisualStyleBackColor = true;
            this.bordersButton.Click += new System.EventHandler(this.bordersButton_Click);
            // 
            // pseudoToneButton
            // 
            this.pseudoToneButton.Location = new System.Drawing.Point(330, 40);
            this.pseudoToneButton.Name = "pseudoToneButton";
            this.pseudoToneButton.Size = new System.Drawing.Size(75, 23);
            this.pseudoToneButton.TabIndex = 16;
            this.pseudoToneButton.Text = "W/B psT";
            this.pseudoToneButton.UseVisualStyleBackColor = true;
            this.pseudoToneButton.Click += new System.EventHandler(this.pseudoToneButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Embross";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(573, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Canny";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(573, 40);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "RndDith";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(654, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = "Noise";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(654, 40);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "GrayWorld";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // aLevelButton
            // 
            this.aLevelButton.Location = new System.Drawing.Point(735, 11);
            this.aLevelButton.Name = "aLevelButton";
            this.aLevelButton.Size = new System.Drawing.Size(75, 23);
            this.aLevelButton.TabIndex = 22;
            this.aLevelButton.Text = "AutoLVL";
            this.aLevelButton.UseVisualStyleBackColor = true;
            this.aLevelButton.Click += new System.EventHandler(this.aLevelButton_Click);
            // 
            // psnrButton
            // 
            this.psnrButton.Location = new System.Drawing.Point(735, 39);
            this.psnrButton.Name = "psnrButton";
            this.psnrButton.Size = new System.Drawing.Size(75, 23);
            this.psnrButton.TabIndex = 23;
            this.psnrButton.Text = "PSNR";
            this.psnrButton.UseVisualStyleBackColor = true;
            this.psnrButton.Click += new System.EventHandler(this.psnrButton_Click);
            // 
            // medianButton
            // 
            this.medianButton.Location = new System.Drawing.Point(816, 11);
            this.medianButton.Name = "medianButton";
            this.medianButton.Size = new System.Drawing.Size(75, 23);
            this.medianButton.TabIndex = 24;
            this.medianButton.Text = "Median";
            this.medianButton.UseVisualStyleBackColor = true;
            this.medianButton.Click += new System.EventHandler(this.medianButton_Click);
            // 
            // erosionButton
            // 
            this.erosionButton.Location = new System.Drawing.Point(898, 39);
            this.erosionButton.Name = "erosionButton";
            this.erosionButton.Size = new System.Drawing.Size(75, 23);
            this.erosionButton.TabIndex = 25;
            this.erosionButton.Text = "Erosion";
            this.erosionButton.UseVisualStyleBackColor = true;
            this.erosionButton.Click += new System.EventHandler(this.erosionButton_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(898, 11);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 26;
            this.button10.Text = "Dilation";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // openingButton
            // 
            this.openingButton.Location = new System.Drawing.Point(979, 11);
            this.openingButton.Name = "openingButton";
            this.openingButton.Size = new System.Drawing.Size(75, 23);
            this.openingButton.TabIndex = 27;
            this.openingButton.Text = "Opening";
            this.openingButton.UseVisualStyleBackColor = true;
            this.openingButton.Click += new System.EventHandler(this.openingButton_Click);
            // 
            // closeingButton
            // 
            this.closeingButton.Location = new System.Drawing.Point(979, 39);
            this.closeingButton.Name = "closeingButton";
            this.closeingButton.Size = new System.Drawing.Size(75, 23);
            this.closeingButton.TabIndex = 28;
            this.closeingButton.Text = "Closeing";
            this.closeingButton.UseVisualStyleBackColor = true;
            this.closeingButton.Click += new System.EventHandler(this.closeingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 560);
            this.Controls.Add(this.closeingButton);
            this.Controls.Add(this.openingButton);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.erosionButton);
            this.Controls.Add(this.medianButton);
            this.Controls.Add(this.psnrButton);
            this.Controls.Add(this.aLevelButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pseudoToneButton);
            this.Controls.Add(this.bordersButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.sharpButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.wMirrorButton);
            this.Controls.Add(this.mirrorButton);
            this.Controls.Add(this.blackWhiteButton);
            this.Controls.Add(this.filterSetButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.ComeBackButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ComeBackButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button filterSetButton;
        private System.Windows.Forms.Button blackWhiteButton;
        private System.Windows.Forms.Button mirrorButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button wMirrorButton;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button sharpButton;
        private System.Windows.Forms.Button bordersButton;
        private System.Windows.Forms.Button pseudoToneButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button aLevelButton;
        private System.Windows.Forms.Button psnrButton;
        private System.Windows.Forms.Button medianButton;
        private System.Windows.Forms.Button erosionButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button openingButton;
        private System.Windows.Forms.Button closeingButton;
    }
}

