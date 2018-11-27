﻿using System;
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
        int prevRatio = 1;

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
            pictureBox1.Image = new Bitmap(files[trackBar.Value - 1]);
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
            
            int zoomRatio = int.Parse(comboBox1.Text)/100;

            if(prevRatio < zoomRatio)
            {
                pictureBox1.Refresh();
                Bitmap bmp = new Bitmap(
                pictureBox1.Image,
                pictureBox1.Image.Width * zoomRatio,
                pictureBox1.Image.Height * zoomRatio);
                pictureBox1.Image = bmp;
                prevRatio = zoomRatio;
            }
            else
            {
                pictureBox1.Refresh();
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
