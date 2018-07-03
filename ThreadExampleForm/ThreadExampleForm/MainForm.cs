using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace ThreadExampleForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int count = CountCharacters();
            textBox.Text = count.ToString() + " characters in file";
        }

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("/home/dimitar/Desktop/Dimo/PROGRAMING/c#/project/Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(500);
            }

            return count;
        }
    }
}