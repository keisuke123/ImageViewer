using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        private string[] files;
        private string prevPath;
        private int prevRatio = 1;
        private int zoomRatio = 1;
        private int coordinateX = 0;
        private int coordinateY = 0;

        public Form1()
        {
            InitializeComponent();

            prevPath = Properties.Settings.Default.imagePath;
            if (Properties.Settings.Default.imagePath != "")
            {
                files = getImagesPath();
                foreach(string elem in files)
                {
                    Console.WriteLine(elem);
                }
                pictureBox1.Image = new Bitmap(files[0]);
                trackBar.Minimum = 1;
                trackBar.Maximum = files.Length;
            }
            Console.WriteLine(trackBar.TickStyle);
            comboBox1.SelectedIndex = 0;
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Image_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            coordinateX = pictureBox1.Location.X;
            coordinateY = pictureBox1.Location.Y;
            pictureBox1.Hide();
            pictureBox1.Image = new Bitmap(files[trackBar.Value - 1]);
            pictureBox1.Show();
            imageZoom();
            panel1.AutoScrollPosition = new Point(-coordinateX, -coordinateY);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {
            settingsForm settings = new settingsForm();
            settings.ShowDialog();
            settings.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (prevPath != Properties.Settings.Default.imagePath)
            {
                prevPath = Properties.Settings.Default.imagePath;
                files = getImagesPath();
                trackBar.Maximum = files.Length;
                trackBar.Minimum = 1;
                Console.WriteLine("min: " + trackBar.Minimum + " max:" + trackBar.Maximum);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
        }

        private string[] getImagesPath()
        {
            return Directory.GetFiles(Properties.Settings.Default.imagePath).Where(elem => Regex.IsMatch(elem, "(.jpg|.png|.bmp)$")).ToArray();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoomRatio = int.Parse((comboBox1.Text).Replace("%", ""))/100;
            imageZoom();
        }

        private void imageZoom()
        {
            if (prevRatio < zoomRatio)
            {
                double zp = (double)zoomRatio / (double)prevRatio;
                Bitmap bmp = new Bitmap(
                pictureBox1.Image,
                (int)(pictureBox1.Image.Width * zp),
                (int)(pictureBox1.Image.Height * zp));
                pictureBox1.Image = bmp;
                prevRatio = zoomRatio;
            }else if (prevRatio == zoomRatio)
            {
                Bitmap bmp = new Bitmap(
                pictureBox1.Image,
                (int)(pictureBox1.Image.Width * zoomRatio),
                (int)(pictureBox1.Image.Height * zoomRatio));
                pictureBox1.Image = bmp;
                prevRatio = zoomRatio;
            }
            else
            {
                double zp = (double)zoomRatio / (double)prevRatio;
                Bitmap bmp = new Bitmap(
                pictureBox1.Image,
                (int)(pictureBox1.Image.Width * (zp)),
                (int)(pictureBox1.Image.Height * (zp)));
                pictureBox1.Image = bmp;
                prevRatio = zoomRatio;
            }
        }
    }
}
