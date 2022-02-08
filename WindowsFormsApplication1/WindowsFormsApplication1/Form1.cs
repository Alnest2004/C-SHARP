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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string PASSWORD = "123";
        int KEY = 0;
        string file;
        public FileStream fs;
        string poe = "exe";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,
                Title = "Выберите файлы",
                InitialDirectory = @"E:\"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    textBox1.Text += file;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] rez = Regex.Split(textBox1.Text, @"E:");
            foreach (string r in rez)
            {
                if (r != "")
                {
                    fs = new FileStream("E:"+r, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                    MessageBox.Show("ФАЙЛ " + r + " ЗАШИФРОВАН!");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (PASSWORD == textBox2.Text)
            {
               
                MessageBox.Show("ФАЙЛ РАСШИФРОВАН!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Пароль не верный!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] rez = Regex.Split(textBox1.Text, @"E:");
            foreach (string r in rez)
            {
                if (r != "")
                {
                    fs = new FileStream("E:" + r, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                    MessageBox.Show("ФАЙЛ " + r + " ЗАШИФРОВАН!");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] rez = Regex.Split(textBox1.Text, @"E:");
            foreach (string r in rez)
            {
                if (r != "")
                {
                    fs = new FileStream("E:" + r, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                    MessageBox.Show("ФАЙЛ " + r + " ЗАШИФРОВАН!");
                }

            }
        }
    }
}
