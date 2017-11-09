using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobsPatents
{
    public partial class Form1 : Form
    {
        string title;
        string description;
        string date;
        string creator;




        public MySqlConnection con = new MySqlConnection("SERVER=db4free.net;PORT=3307;DATABASE=bobspatents;UID=serglit1650;PWD=serglit102;");

        


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            title = textBox1.Text;
            description = textBox2.Text;
            date = textBox3.Text;
            creator = textBox4.Text;

            MySqlCommand commandInsert = new MySqlCommand("INSERT INTO `Patents`(`Title`, `Description`, `Date`, `Creator`) VALUES ('"+title+"','"+description+"','"+date+"','"+creator+"')", con);
            commandInsert.Parameters.AddWithValue("@SPSamount", textBox2);
            commandInsert.ExecuteNonQuery();
            commandInsert.Parameters.Clear();
            MessageBox.Show("Money were unsuccessfully sent. Pending: 666 Hrs, 666 Min, 666 Sec");

            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
