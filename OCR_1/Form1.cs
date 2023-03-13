using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

//using IronOcr;
using IronOcr;


using Exception = System.Exception;

namespace OCR_1
{
    public partial class Form1 : Form
    {
        //private object openimagedia;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbimg.Image != null)
                {
                    var Ocr = new TesseractEngine("C:\\Users\\piriy\\OneDrive\\Desktop", "eng", EngineMode.Default);
                    var Result = Ocr.Process(new Bitmap(pbimg.Image));
                    rtxresult.Text = Result.GetText();
                }
                else
                {
                    MessageBox.Show(@"No image selected.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error process image conversion. " + exception.Message);
            }
        }

        private void Btnrr_Click(object sender, EventArgs e)
        {
            if (pbimg.Image != null)
            {
                var imagerr = pbimg.Image;
                imagerr.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pbimg.Image = imagerr;
            }
        }

        private void Btnload_Click(object sender, EventArgs e)
        {
            try
            {
                 OpenFileDialog openimagedia = new OpenFileDialog();
                openimagedia.Filter = "PNG files|*.png|JPEG files|*.jpg;*.jpeg|All files|*.*";
                if (openimagedia.ShowDialog() == DialogResult.OK)
                {
                    pbimg.Load(openimagedia.FileName);
                    pbimg.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error loading image. " + exception.Message);
            }


        }

       

        private void Btnrl_Click(object sender, EventArgs e)
        {
            if (pbimg.Image != null)
            {
                var imagerl = pbimg.Image;
                imagerl.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pbimg.Image = imagerl;
            }
        }
    }
}
