using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Diagnostics;

namespace Deep_Face
{
    public partial class Main : Form
    {
        string ImagePath;
        public Main()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            #region Get image path and show image in picture box
            OfdGetImage.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png";
            if (OfdGetImage.ShowDialog() == DialogResult.OK)
            {
                ImagePath = OfdGetImage.FileName;
                LblImagePath.Text = ImagePath;
                PicShowImage.Image = Image.FromFile(ImagePath);
            }
            else
            {
                MessageBox.Show("Select Image");
            }
            #endregion
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            #region Save image path to input file for python
            inputjson inp = new inputjson();
            inp.ImagePath = ImagePath;
            string jout = JsonSerializer.Serialize<inputjson>(inp);
            File.WriteAllText("input.json", jout);
            #endregion

            #region Run python file
            Process myProcess = new Process(); 
            myProcess.StartInfo.FileName = @"Main.py";
            myProcess.Start();
            #endregion

            #region Checking the existence of the file
            bool IsFile = false;
            while (!IsFile)  
            {
                if (File.Exists(@"output.json"))
                {
                    IsFile = true;
                }
            }
            #endregion

            #region Read result from JSON file
            string outj = File.ReadAllText(@"output.json"); // Read out put from JSON file
            var person = JsonSerializer.Deserialize<outputjson>(outj); // Put result to out put class
            File.Delete(@"output.json"); // Delete output.json
            TxtAge.Text = person.Age.ToString(); // Show age
            RicEmotion.Text = person.Emotion.ToString(); // show emotion
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
 
    #region The class for convert image path to JSON file
    public class inputjson
    {
        public string ImagePath { get; set; }
    }
    #endregion

    #region The class for get out put from JSON file
    public class outputjson
    {
        public int Age { get; set; }
        public object Emotion { get; set; }
    }
    #endregion
}
