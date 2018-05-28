using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace System
{
    public partial class Login_Form : Form
    {

        MySqlConnection con = new MySqlConnection(@"Database = mydb; Data source = 127.0.0.1; User Id = root; Password = root;");
        string count;

        public Login_Form()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime voteTime = new DateTime(2018, 2, 20, 0, 0, 0);

            TimeSpan TimeRemaining = voteTime - DateTime.Now;

            label1.Text = "До начала гонки осталось " + TimeRemaining.Days + " дня " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд";


        }


        private void Login_Button_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT *, COUNT(*) FROM users WHERE login = '" + LoginBox.Text + "' AND password = '" + PassBox.Text + "'  ", con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                count = read["COUNT(*)"].ToString();
            }
            con.Close();

            if (count == "0")
            {
                MessageBox.Show("Логин или пароль введены неверно");
            }

            else
            {
                MessageBox.Show("Авторизация прошла успешно");
            }
        }
    }
}
