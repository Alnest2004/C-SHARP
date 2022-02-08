using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string PASSWORD = "123";
        int KEY = 0;
        string file;
        public FileStream fs;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            byte[] buf = File.ReadAllBytes(textBox1.Text);
            for (int i = 0; i < buf.Length; i++)
            {
                buf[i] = (byte)(buf[i] ^ KEY);
            }
            File.WriteAllBytes(textBox1.Text, buf);
            fs = new FileStream(textBox1.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            MessageBox.Show("ФАЙЛ ЗАШИФРОВАН!");
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            if(PASSWORD == textBox2.Text)
            {
                fs.Close();
                byte[] buf = File.ReadAllBytes(textBox1.Text);
                for (int i = 0; i < buf.Length; i++)
                {
                    buf[i] = (byte)(buf[i] ^ KEY);
                }
                File.WriteAllBytes(textBox1.Text, buf);
                MessageBox.Show("ФАЙЛ РАСШИФРОВАН!");
            }
            else
            {
                MessageBox.Show("Пароль не верный!");
            }
        }
    }
}
