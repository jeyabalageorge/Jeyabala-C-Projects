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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                //string connectionStr = "Provider= Microsoft.ACE.ÒLEDB.12.0; Data Source= D:\\Jeyabala George\\Vicapri Training\\Testing Job\\CV\\CV_Testing\\CV_New\\amsphere\\Database_JB.accdb;Persist Security Info=False;";
                string connectionStr = "provider=Microsoft.ACE.OLEDB.12.0; data source= D:\\Jeyabala George\\Vicapri Training\\Testing Job\\CV\\CV_Testing\\CV_New\\amsphere\\Database_JB.accdb";



                MessageBox.Show(connectionStr);
                DBJB = new OleDbConnection(connectionStr);
               // DBJB.Open();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            MessageBox.Show("Connected");

        }

        public OleDbConnection DBJB { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;

            string typed = textBox1.Text;
            MessageBox.Show("You have Typed:  "+ typed);
            textBox1.Text = "";
            String sqlstr = "insert into Family_JB (name, age) values ('Vishal', '12')";
            DBJB.Open();
            cmd.CommandText = sqlstr;
            cmd.Connection = DBJB;
            cmd.ExecuteNonQuery();
            DBJB.Close();

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
