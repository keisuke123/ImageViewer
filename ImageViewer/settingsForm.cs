using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ImageViewer
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
           
            imagePathTextBox.Text = Properties.Settings.Default.imagePath;
        }

        private void folderSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                imagePathTextBox.Text = dialog.SelectedPath;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void imagePathOkButton_Click(object sender, EventArgs e)
        {
            if (imagePathTextBox.Text != "")
            {
                Properties.Settings.Default.imagePath = imagePathTextBox.Text;
                Properties.Settings.Default.Save();
                Close();
            }
            else
            {
                MessageBox.Show("正しいパスを入力してください");
            }
        }

        private void imagePathCancelButton_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
