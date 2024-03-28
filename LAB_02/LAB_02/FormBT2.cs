using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_02
{
    public partial class FormBT2 : Form
    {
        public FormBT2()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            textName.Text = ofd.SafeFileName.ToString();
            textSize.Text = sr.BaseStream.Length.ToString();
            textURL.Text = fs.Name.ToString();

            // Line count
            int LineCount = 0;
            while (sr.ReadLine() != null)
            {
                LineCount++;
            }
            textLineCount.Text = LineCount.ToString();
            sr.Close();

            //Word count
            sr = new StreamReader(ofd.FileName);
            string textFileWord = sr.ReadToEnd();
            string[] ArrWords = textFileWord.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            textWordsCount.Text = ArrWords.Length.ToString();
            sr.Close();

            //Character count
            sr = new StreamReader(ofd.FileName);
            int charCount = 0;
            int currentChar;
            while ((currentChar = sr.Read()) != -1)
            {
                if (!char.IsWhiteSpace((char)currentChar))
                {
                    charCount++;
                }
            }   
            textCharCount.Text = charCount.ToString();
            sr.Close();
            fs.Close();

            //Display File
            sr = new StreamReader(ofd.FileName);
            textDisplay.Text = sr.ReadToEnd();
        }
    }
}
