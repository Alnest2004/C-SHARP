using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public static string connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb;";

        private OleDbConnection myConnection;

        public Form1()
        {
            InitializeComponent();

            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connetionString);

            // открываем соединение с БД
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workersDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.workersDataSet.Worker);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string update = "UPDATE Worker SET w_name = @w_name, w_position = @w_position, w_salary = @w_salary WHERE w_id = @w_id";



            OleDbCommand command = new OleDbCommand(update, myConnection);
            string sql = "select * FROM Worker ORDER BY w_salary";
            command.ExecuteNonQuery();


            try
            {



                SqlCommand myCommand = new SqlCommand(update, command);

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    myCommand.Parameters.Clear();
                    myCommand.Parameters.AddWithValue("@w_name", dataGridView1.Rows[i].Cells[0].Value);
                    myCommand.Parameters.AddWithValue("@w_position", dataGridView1.Rows[i].Cells[1].Value);
                    myCommand.Parameters.AddWithValue("@w_salary", dataGridView1.Rows[i].Cells[2].Value);
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
