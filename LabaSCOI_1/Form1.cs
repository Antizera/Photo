using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaSCOI_1
{
    public partial class Form1 : Form
    {
        

        public int min(int i , int b)
        {
            if (i < b) return i; else return b;
        }
        public int max(int i, int b)
        {
            if (i < b) return b; else return i;
        } 
        public static T Clamp<T>(T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return val;
        }
        private Bitmap image1 = null;
        private Bitmap image2 = null;
        private Bitmap image3 = null;
       
        public Form1()
        {
            InitializeComponent();
            image1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            image2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            
          
        }
        private void Load1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (image1 != null)
                {
                    pictureBox1.Image = null;
                    image1.Dispose();
                }

                image1 = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = image1;
            }

            int[] N=new int[256];


            for (int y = 0; y < image1.Height - 1; y++)
                for (int x = 0; x < image1.Width - 1; x++)
                {
                    var pix = image1.GetPixel(x, y);
                 var   c = (pix.R + pix.G + pix.B) / 3;
                    N[c]++;
                }

            var max = N.Max<int>();
            int hhs = 100;
            int k = hhs / max;

        }

        private void Load2_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (image2 != null)
                {
                    pictureBox2.Image = null;
                    image2.Dispose();
                }

                image2 = new Bitmap(openFileDialog.FileName);
                pictureBox2.Image = image2;
            }
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileFialog = new SaveFileDialog();
            saveFileFialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileFialog.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
            saveFileFialog.RestoreDirectory = true;

            if (saveFileFialog.ShowDialog() == DialogResult.OK)
            {
                
                
                    pictureBox3.Image.Save(saveFileFialog.FileName);
                
            }
        }


      
        
        private void SUM_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(image1.Width, image1.Height);
            for (int i = 0; i < image1.Height; ++i)
            {
                for (int j = 0; j < image1.Width; ++j)
                {
                    var pix1 = image1.GetPixel(j, i);
                    var pix2 = image2.GetPixel(j, i);


                    int r1 = pix1.R;
                    int g1 = pix1.G;
                    int b1 = pix1.B;

                    int r2 = pix2.R;
                    int g2 = pix2.G;
                    int b2 = pix2.B;

                    r1 = (int)Clamp(r1 + r2, 0, 255);
                    g1 = (int)Clamp(g1 + g2, 0, 255);
                    b1 = (int)Clamp(b1 + b2, 0, 255);

                    pix1 = Color.FromArgb(r1, g1, b1);
                    bit.SetPixel(j, i, pix1);

                   

                }
            }
            
            pictureBox3.Image = bit;
        }

        private void Proizv_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(image1.Width, image1.Height);
            for (int i = 0; i < image1.Height; ++i)
            {
                for (int j = 0; j < image1.Width; ++j)
                {
                    var pix1 = image1.GetPixel(j, i);
                    var pix2 = image2.GetPixel(j, i);


                    int r1 = pix1.R;
                    int g1 = pix1.G;
                    int b1 = pix1.B;

                    int r2 = pix2.R;
                    int g2 = pix2.G;
                    int b2 = pix2.B;

                    r1 = (int)Clamp((r1 * r2)/255, 0, 255);
                    g1 = (int)Clamp((g1 * g2)/255, 0, 255);
                    b1 = (int)Clamp((b1 * b2)/255, 0, 255);

                    pix1 = Color.FromArgb(r1, g1, b1);
                    bit.SetPixel(j, i, pix1);

                    

                }
            }
            pictureBox3.Image = bit;
        }

        private void Avr_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(image1.Width, image1.Height);
            for (int i = 0; i < image1.Height; ++i)
            {
                for (int j = 0; j < image1.Width; ++j)
                {
                    var pix1 = image1.GetPixel(j, i);
                    var pix2 = image2.GetPixel(j, i);


                    int r1 = pix1.R;
                    int g1 = pix1.G;
                    int b1 = pix1.B;

                    int r2 = pix2.R;
                    int g2 = pix2.G;
                    int b2 = pix2.B;

                    r1 = (int)Clamp((r1 * r2) / 2, 0, 255);
                    g1 = (int)Clamp((g1 * g2) / 2, 0, 255) ;
                    b1 = (int)Clamp((b1 * b2) / 2, 0, 255);

                    pix1 = Color.FromArgb(r1, g1, b1);
                    bit.SetPixel(j, i, pix1);

                   

                }
            }
            pictureBox3.Image = bit;
        }

        private void Min_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(image1.Width, image1.Height);
            for (int i = 0; i < image1.Height; ++i)
            {
                for (int j = 0; j < image1.Width; ++j)
                {
                    var pix1 = image1.GetPixel(j, i);
                    var pix2 = image2.GetPixel(j, i);


                    int r1 = pix1.R;
                    int g1 = pix1.G;
                    int b1 = pix1.B;

                    int r2 = pix2.R;
                    int g2 = pix2.G;
                    int b2 = pix2.B;

                    r1 = (int)Clamp(min(r1,r2), 0, 255);
                    g1 = (int)Clamp(min(g1,g2), 0, 255);
                    b1 = (int)Clamp(min(b1,b2), 0, 255);

                    pix1 = Color.FromArgb(r1, g1, b1);
                    bit.SetPixel(j, i, pix1);

                    

                }
            }
            pictureBox3.Image = bit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(image1.Width, image1.Height);
            for (int i = 0; i < image1.Height; ++i)
            {
                for (int j = 0; j < image1.Width; ++j)
                {
                    var pix1 = image1.GetPixel(j, i);
                    var pix2 = image2.GetPixel(j, i);


                    int r1 = pix1.R;
                    int g1 = pix1.G;
                    int b1 = pix1.B;

                    int r2 = pix2.R;
                    int g2 = pix2.G;
                    int b2 = pix2.B;

                    r1 = (int)Clamp(max(r1, r2), 0, 255);
                    g1 = (int)Clamp(max(g1, g2), 0, 255);
                    b1 = (int)Clamp(max(b1, b2), 0, 255);

                    pix1 = Color.FromArgb(r1, g1, b1);
                    bit.SetPixel(j, i, pix1);

                    

                }
            }
            pictureBox3.Image = bit;
        }
    }
}
