using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public static string connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb;";
        public static SqlConnection cnn = new SqlConnection(connetionString);

        public static string sql = "select * from Datetest.dbo.Date";
        SqlDataAdapter dataadapter = new SqlDataAdapter(sql, cnn);
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workersDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.workersDataSet.Worker);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=server;Initial Catalog=Datetest;User ID=Dateuser;Password=12345";
            SqlConnection cnn = new SqlConnection(connetionString);
            string update;

            update = "update Datetest.dbo.Date set id=@id,Name=@Name,Date=@Date where id=@id";
            string sql = "select * from Datetest.dbo.Date";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();


            try
            {
                cnn.Open();

                dataadapter.Fill(ds, "Datetest.dbo.Date");


                SqlCommand myCommand = new SqlCommand(update, cnn);

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    myCommand.Parameters.Clear();
                    myCommand.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
                    myCommand.Parameters.AddWithValue("@Name", dataGridView1.Rows[i].Cells[1].Value);
                    myCommand.Parameters.AddWithValue("@Date", dataGridView1.Rows[i].Cells[2].Value);
                    myCommand.ExecuteNonQuery();

                }


                cnn.Close();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
