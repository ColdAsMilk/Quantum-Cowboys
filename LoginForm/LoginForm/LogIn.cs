using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LoginForm
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kyler\Documents\GitHub\Quantum-Cowboys\LoginForm\LoginForm\Database1.mdf;Integrated Security=True");
            string query = "Select * from LoginInfo Where username = '" + txtUsername.Text.Trim() + "' and password ='" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count==1)
            {
                MarketPlace objFrmMain = new MarketPlace();
                this.Hide();
                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void LabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration objFrmMain = new Registration();
            this.Hide();
            objFrmMain.Show();
        }
    }
}
