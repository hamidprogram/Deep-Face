namespace Deep_Face
{
    partial class Main
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
            this.BtnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblImagePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PicShowImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RicEmotion = new System.Windows.Forms.RichTextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OfdGetImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicShowImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(334, 145);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(100, 23);
            this.BtnSelect.TabIndex = 0;
            this.BtnSelect.Text = "Select Image";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnStart);
            this.groupBox1.Controls.Add(this.LblImagePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PicShowImage);
            this.groupBox1.Controls.Add(this.BtnSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(6, 145);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(100, 23);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Start Analyze";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblImagePath
            // 
            this.LblImagePath.AutoSize = true;
            this.LblImagePath.Location = new System.Drawing.Point(77, 30);
            this.LblImagePath.Name = "LblImagePath";
            this.LblImagePath.Size = new System.Drawing.Size(0, 13);
            this.LblImagePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Path:";
            // 
            // PicShowImage
            // 
            this.PicShowImage.Location = new System.Drawing.Point(334, 19);
            this.PicShowImage.Name = "PicShowImage";
            this.PicShowImage.Size = new System.Drawing.Size(100, 120);
            this.PicShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicShowImage.TabIndex = 1;
            this.PicShowImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RicEmotion);
            this.groupBox2.Controls.Add(this.TxtAge);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 237);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // RicEmotion
            // 
            this.RicEmotion.Enabled = false;
            this.RicEmotion.Location = new System.Drawing.Point(60, 74);
            this.RicEmotion.Name = "RicEmotion";
            this.RicEmotion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RicEmotion.Size = new System.Drawing.Size(374, 157);
            this.RicEmotion.TabIndex = 3;
            this.RicEmotion.Text = "";
            // 
            // TxtAge
            // 
            this.TxtAge.Enabled = false;
            this.TxtAge.Location = new System.Drawing.Point(60, 48);
            this.TxtAge.Multiline = true;
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(113, 20);
            this.TxtAge.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Emotion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Age:";
            // 
            // OfdGetImage
            // 
            this.OfdGetImage.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deep Face";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicShowImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblImagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicShowImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RicEmotion;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog OfdGetImage;
    }
}