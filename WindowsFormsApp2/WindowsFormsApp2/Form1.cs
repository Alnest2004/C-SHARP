using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Model model;
        private Presenter presenter;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            presenter = new Presenter(model);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.model = this.presenter.Login(textBox1.Text, textBox2.Text);
            Update();
        }

        private void Update()
        {
            richTextBox1.Text = this.model.Message;
        }
    }
}
