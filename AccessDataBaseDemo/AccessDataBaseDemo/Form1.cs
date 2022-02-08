using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessDataBaseDemo
{
    public partial class Form1 : Form
    {
        // строка подключения к MS Access
        // вариант 1
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb;";
        // вариант 2
        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Workers.mdb;";

        // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
        private OleDbConnection myConnection;

        // конструктор класса формы
        public Form1()
        {
            InitializeComponent();

            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();
        }

        // обработчик события закрытия формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // заркываем соединение с БД
            myConnection.Close();
        }

        // обработчик нажатия кнопки SELECT1
        private void selectButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox2.Text);
            // текст запроса
            string query = String.Format("SELECT w_name FROM Worker WHERE w_id = {0}", id);

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);


        }

        public string Decrypt(string text)
        {
            var column = text.Length / 2;
            var symbols = new char[text.Length];
            int index = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    symbols[i + column * j] = text[index];
                    index++;
                }
            }

            return string.Join("", symbols);
        }

        // обработчик нажатия кнопки SELECT2
        private void selectButton2_Click(object sender, EventArgs e)
        {
            // текст запроса
            string query = "SELECT w_name, w_position, w_salary FROM Worker ORDER BY w_salary";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            // очищаем listBox1
            listBox1.Items.Clear();

            // в цикле построчно читаем ответ от БД
            while(reader.Read())
            {
                // выводим данные столбцов текущей строки в listBox1
                listBox1.Items.Add(Decrypt(reader[0].ToString()) + " " + Decrypt(reader[1].ToString()) + " " + Decrypt(reader[2].ToString()) + " ");
            }

            // закрываем OleDbDataReader
            reader.Close();
        }

        public string Encrypt(string text, int d=2)
        {
            var k = text.Length % d;
            if (k > 0)
            {
                //дополняем строку пробелами
                text += new string(' ', d - k);
            }

            var column = text.Length / d;
            var result = "";

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    result += text[i + column * j].ToString();
                }
            }

            return result;
        }

        // обработчик нажатия кнопки INSERT
        private void insertButton_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            string position = textBox6.Text;
            string salary = textBox4.Text;



            // текст запроса
            string query = string.Format("INSERT INTO Worker (w_name, w_position, w_salary) VALUES ('{0}', '{1}', {2})", Encrypt(name), Encrypt(position), Encrypt(salary));

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            // выполняем запрос к MS Access
            command.ExecuteNonQuery();
        }

        // обработчик нажатия кнопки UPDATE
        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox2.Text);
            int sal = Convert.ToInt32(textBox5.Text);
            // текст запроса
            string query = String.Format("UPDATE Worker SET w_salary = {1} WHERE w_id = {0}", id, sal);

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            MessageBox.Show(command.CommandText);

            // выполняем запрос к MS Access
            command.ExecuteNonQuery();
        }

        // обработчик нажатия кнопки DELETE
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox2.Text);
            // текст запроса
            string query = String.Format("DELETE FROM Worker WHERE w_id = {0}", id);

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            

            // выполняем запрос к MS Access
            command.ExecuteNonQuery();
        }
    }
}
