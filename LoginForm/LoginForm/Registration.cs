//Ask Alec about anything on this form
//He might not understand it
//But he wrote it `\(o_o)/


/*
 * I WILL PUT A COMMENT WHERE SOMETHING IS NEEDED FROM YOU
 */
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
    public partial class Registration : Form
    {
        String connectionString = @""; //Connection String goes in between the quotes
        public Registration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please Fill Mandatory Fields");
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                //!!!!! 
                // Might not work, just hoping if statements are like Java
                MessageBox.Show("Error. Please Confirm Password");
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
            else
            {

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    //Opening the Connection (if im thinking about this right)
                    SqlCommand sqlcmd = new SqlCommand("", sqlCon); //Table Name goes in, if Im thinking correctly, ask Alec for the video about this
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    // !!!!!
                    // Needs tweaking from you for the Column(?) Names
                    sqlcmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Compelete, Partner.");
                    Clear();
                }
            }

        }
        void Clear()
        {
            txtUsername.Text = txtPassword.Text = "";
        }
    }
}