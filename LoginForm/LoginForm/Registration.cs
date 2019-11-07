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
using System.Configuration;

namespace LoginForm
{
    public partial class Registration : Form
    {   //Shoving the connection string into a variable for easier use
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kyler\Documents\GitHub\Quantum-Cowboys\LoginForm\LoginForm\Database1.mdf;Integrated Security=True";
        public Registration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Checking if the Username or password text fields are empty (They have to have a usernameNPassword)
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill fields");
            else if (txtPassword.Text != txtConfirmPassword.Text) //Checking to see if the password field and confirmation field are matching.
                MessageBox.Show("Passwords do not match");
            else
            {
                    //Creating instance of connection
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open(); //Opening instance
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);// Establishing parameters
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserName", txtUsername.Text.Trim()); //Adding the Username
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim()); //Adding the password
                    sqlCmd.ExecuteNonQuery(); //Executing the Sql Query connected to the database
                    MessageBox.Show("Registration Success"); 
                    
                    Clear(); //Calls Clear Method
                    LogIn objFrmMain = new LogIn();
                    this.Hide();
                    objFrmMain.Show();
                }
            }
        }
        void Clear() //Resets the textbox fields.
        {
            txtUsername.Text = txtPassword.Text = txtConfirmPassword.Text = "";
        }

        private void LabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn objFrmMain = new LogIn();
            this.Hide();
            objFrmMain.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}