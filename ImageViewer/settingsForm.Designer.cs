namespace ImageViewer
{
    partial class settingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.folderSelectButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.imagePathOkButton = new System.Windows.Forms.Button();
            this.imagePathCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.Location = new System.Drawing.Point(29, 44);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.Size = new System.Drawing.Size(280, 19);
            this.imagePathTextBox.TabIndex = 1;
            // 
            // folderSelectButton
            // 
            this.folderSelectButton.Location = new System.Drawing.Point(319, 42);
            this.folderSelectButton.Name = "folderSelectButton";
            this.folderSelectButton.Size = new System.Drawing.Size(56, 23);
            this.folderSelectButton.TabIndex = 2;
            this.folderSelectButton.Text = "選択";
            this.folderSelectButton.UseVisualStyleBackColor = true;
            this.folderSelectButton.Click += new System.EventHandler(this.folderSelectButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "画像のパスを選択";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imagePathOkButton
            // 
            this.imagePathOkButton.Location = new System.Drawing.Point(205, 79);
            this.imagePathOkButton.Name = "imagePathOkButton";
            this.imagePathOkButton.Size = new System.Drawing.Size(104, 23);
            this.imagePathOkButton.TabIndex = 4;
            this.imagePathOkButton.Text = "OK";
            this.imagePathOkButton.UseVisualStyleBackColor = true;
            this.imagePathOkButton.Click += new System.EventHandler(this.imagePathOkButton_Click);
            // 
            // imagePathCancelButton
            // 
            this.imagePathCancelButton.Location = new System.Drawing.Point(74, 79);
            this.imagePathCancelButton.Name = "imagePathCancelButton";
            this.imagePathCancelButton.Size = new System.Drawing.Size(104, 23);
            this.imagePathCancelButton.TabIndex = 5;
            this.imagePathCancelButton.Text = "Cancel";
            this.imagePathCancelButton.UseVisualStyleBackColor = true;
            this.imagePathCancelButton.Click += new System.EventHandler(this.imagePathCancelButton_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 124);
            this.Controls.Add(this.imagePathCancelButton);
            this.Controls.Add(this.imagePathOkButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderSelectButton);
            this.Controls.Add(this.imagePathTextBox);
            this.Name = "settingsForm";
            this.Text = "設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox imagePathTextBox;
        private System.Windows.Forms.Button folderSelectButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button imagePathOkButton;
        private System.Windows.Forms.Button imagePathCancelButton;
    }
}