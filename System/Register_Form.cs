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
    public partial class Register_Form : Form
    {

        MySqlConnection con = new MySqlConnection(@"Database = mydb; Data source = 127.0.0.1; User Id = root; Password = root");

        public Register_Form()
        {
            InitializeComponent();

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Country FROM data", con);
                MySqlDataReader read = cmd.ExecuteReader();
                while(read.Read())
                {
                    CountryBox.Items.Add(read.GetValue(0).ToString());
                }
                con.Close();
            }
            catch(MySqlException)
            {
                MessageBox.Show("Error");
                con.Close();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime voteTime = new DateTime(2018, 2, 20, 0, 0, 0);

            TimeSpan TimeRemaining = voteTime - System.DateTime.Now;

            label1.Text = "До начала гонки осталось " + TimeRemaining.Days + " дня " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд";


        }


        private void Send_Button_Click(object sender, EventArgs e)
        {
            if (PassBox.Text == RetryBox.Text)
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users (login, password, country, date_of_birth) VALUES ('" + email_box.Text + "', '" + PassBox.Text + "', '" + CountryBox.Text + "', '" + DateTime.Text + "') ", con);
                    MySqlDataReader read = cmd.ExecuteReader();
                    MessageBox.Show("OK");
                    con.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают !");
            }

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (DateTime.Value.Year == 2018)
        //    {
        //        MessageBox.Show(DateTime.Value.ToString());
        //    }
            
        //    if(DateTime.Value.Year == 2017)
        //    {
        //        MessageBox.Show("2017");
        //    }
        //}

        private void LoadIMG_Button_Click(object sender, EventArgs e)
        {
            if(OPF.ShowDialog() == DialogResult.OK)
            {
                foreach(string file in OPF.FileNames)
                {
                    ImageBox.Image = Image.FromFile("" + file + "");
                }
            }
        }

        private void DateTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
