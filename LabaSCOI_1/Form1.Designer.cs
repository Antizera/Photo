using System.Drawing;

namespace LabaSCOI_1
{
    partial class Form1
    {
     
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Load1 = new System.Windows.Forms.Button();
            this.Load2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SAVE = new System.Windows.Forms.Button();
            this.SUM = new System.Windows.Forms.Button();
            this.Proizv = new System.Windows.Forms.Button();
            this.Avr = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Load1
            // 
            this.Load1.Location = new System.Drawing.Point(12, 235);
            this.Load1.Name = "Load1";
            this.Load1.Size = new System.Drawing.Size(133, 34);
            this.Load1.TabIndex = 1;
            this.Load1.Text = "Load";
            this.Load1.UseVisualStyleBackColor = true;
            this.Load1.Click += new System.EventHandler(this.Load1_Click);
            // 
            // Load2
            // 
            this.Load2.Location = new System.Drawing.Point(12, 500);
            this.Load2.Name = "Load2";
            this.Load2.Size = new System.Drawing.Size(133, 34);
            this.Load2.TabIndex = 1;
            this.Load2.Text = "Load2";
            this.Load2.UseVisualStyleBackColor = true;
            this.Load2.Click += new System.EventHandler(this.Load2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(447, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(700, 300);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(1046, 420);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(113, 35);
            this.SAVE.TabIndex = 3;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // SUM
            // 
            this.SUM.Location = new System.Drawing.Point(405, 418);
            this.SUM.Name = "SUM";
            this.SUM.Size = new System.Drawing.Size(104, 37);
            this.SUM.TabIndex = 4;
            this.SUM.Text = "Сумма";
            this.SUM.UseVisualStyleBackColor = true;
            this.SUM.Click += new System.EventHandler(this.SUM_Click);
            // 
            // Proizv
            // 
            this.Proizv.Location = new System.Drawing.Point(515, 418);
            this.Proizv.Name = "Proizv";
            this.Proizv.Size = new System.Drawing.Size(121, 37);
            this.Proizv.TabIndex = 5;
            this.Proizv.Text = "Произведение";
            this.Proizv.UseVisualStyleBackColor = true;
            this.Proizv.Click += new System.EventHandler(this.Proizv_Click);
            // 
            // Avr
            // 
            this.Avr.Location = new System.Drawing.Point(642, 418);
            this.Avr.Name = "Avr";
            this.Avr.Size = new System.Drawing.Size(144, 51);
            this.Avr.TabIndex = 6;
            this.Avr.Text = "Среднее арефметическое";
            this.Avr.UseVisualStyleBackColor = true;
            this.Avr.Click += new System.EventHandler(this.Avr_Click);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(792, 418);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(87, 37);
            this.Min.TabIndex = 7;
            this.Min.Text = "Минимум";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(885, 418);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(96, 37);
            this.Max.TabIndex = 8;
            this.Max.Text = "Максимум";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(471, 513);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(520, 159);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(471, 688);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(520, 159);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1836, 859);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Avr);
            this.Controls.Add(this.Proizv);
            this.Controls.Add(this.SUM);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Load2);
            this.Controls.Add(this.Load1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Olive;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Load1;
        private System.Windows.Forms.Button Load2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button SUM;
        private System.Windows.Forms.Button Proizv;
        private System.Windows.Forms.Button Avr;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

