using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class PostBounty : Form
    {
        public PostBounty()
        {
            InitializeComponent();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(filePath);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string name, wantedLevel, location;
            double award;
            int imageID;
            bool valid = true;
            txtName.BackColor = Color.White;
            txtLocation.BackColor = Color.White;
            txtAward.BackColor = Color.White;


            //name
            if (String.IsNullOrEmpty(txtName.Text))
            {
                valid = false;
                txtName.BackColor = Color.DarkRed;
            }
            else
            {
                name = txtName.Text;
            }

            //wanted level
            if (radAlive.Checked == true)
            {
                wantedLevel = "Alive";
            }
            else
            {
                if (radDead.Checked == true)
                {
                    wantedLevel = "Dead";
                }
                else
                {
                    wantedLevel = "Dead or Alive";
                }
            }
           

            //award
            if ((Double.Parse(txtAward.Text)) == 0 || String.IsNullOrEmpty(txtAward.Text))
            {
                valid = false;
                txtAward.BackColor = Color.DarkRed;
            }
            else
            {
                award = Double.Parse(txtAward.Text);
            }
            // location
            if (String.IsNullOrEmpty(txtLocation.Text))
            {
                valid = false;
                txtLocation.BackColor = Color.DarkRed;
            }
            else
            {
                location = txtLocation.Text;
            }
            




        }

        private void TxtAward_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
            (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Decimal))
            {
                e.Handled = true;
            }
        }

        private void PostBounty_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}