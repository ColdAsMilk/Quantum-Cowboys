using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Bounties : Form
    {
        public int ctrPage = 1;
        public int ctrPicture = 0;
        public static string directory = "C:\\Users\\Kyler\\Documents\\GitHub\\Quantum-Cowboys\\MarketPlace\\MarketPlace\\bin\\images";
        public static List<Image> imageList = Directory.GetFiles(directory, "*.jpg", SearchOption.AllDirectories).Select(Image.FromFile).ToList();
        public Bounties()
        {
            InitializeComponent();

        }


        private void Bounties_Load(object sender, EventArgs e)
        {
            LoadImageBoxes(imageList);
        }
        public void LoadImageBoxes(List<Image> imageList)
        {
            int amountImages = imageList.Count();

            double result = amountImages / 6.0;
            double totPages = Math.Ceiling(result);
            lblPageCtr.Text = "Page " + ctrPage.ToString() + " of " + totPages.ToString();

            amountImages = amountImages - ((ctrPage - 1) * 6);
            //populate for form load     
            if (amountImages > 5)
            {
                pictureBox1.Image = imageList[ctrPicture + 0];
                pictureBox2.Image = imageList[ctrPicture + 1];
                pictureBox3.Image = imageList[ctrPicture + 2];
                pictureBox4.Image = imageList[ctrPicture + 3];
                pictureBox5.Image = imageList[ctrPicture + 4];
                pictureBox6.Image = imageList[ctrPicture + 5];
                ctrPicture += 6;
            }
            else
            {
                switch (amountImages)
                {
                    case 0:
                        pictureBox1.Image = null;
                        pictureBox2.Image = null;
                        pictureBox3.Image = null;
                        pictureBox4.Image = null;
                        pictureBox5.Image = null;
                        pictureBox6.Image = null;
                        break;
                    case 1:
                        pictureBox1.Image = imageList[ctrPicture + 0];
                        pictureBox2.Image = null;
                        pictureBox3.Image = null;
                        pictureBox4.Image = null;
                        pictureBox5.Image = null;
                        pictureBox6.Image = null;
                        break;

                    case 2:
                        pictureBox1.Image = imageList[ctrPicture + 0];
                        pictureBox2.Image = imageList[ctrPicture + 1];
                        pictureBox3.Image = null;
                        pictureBox4.Image = null;
                        pictureBox5.Image = null;
                        pictureBox6.Image = null;
                        break;
                    case 3:
                        pictureBox1.Image = imageList[ctrPicture + 0];
                        pictureBox2.Image = imageList[ctrPicture + 1];
                        pictureBox3.Image = imageList[ctrPicture + 2];
                        pictureBox4.Image = null;
                        pictureBox5.Image = null;
                        pictureBox6.Image = null;
                        break;
                    case 4:
                        pictureBox1.Image = imageList[ctrPicture + 0];
                        pictureBox2.Image = imageList[ctrPicture + 1];
                        pictureBox3.Image = imageList[ctrPicture + 2];
                        pictureBox4.Image = imageList[ctrPicture + 3];
                        pictureBox5.Image = null;
                        pictureBox6.Image = null;
                        break;
                    case 5:
                        pictureBox1.Image = imageList[ctrPicture + 0];
                        pictureBox2.Image = imageList[ctrPicture + 1];
                        pictureBox3.Image = imageList[ctrPicture + 2];
                        pictureBox4.Image = imageList[ctrPicture + 3];
                        pictureBox5.Image = imageList[ctrPicture + 4];
                        pictureBox6.Image = null;
                        break;
                }
            }

        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            ctrPage++;
            LoadImageBoxes(imageList);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ctrPage--;
            ctrPicture -= 6;
            LoadImageBoxes(imageList);
        }

        private void BtnPostBounty_Click(object sender, EventArgs e)
        {
            new PostBounty().ShowDialog();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LblSearch_Click(object sender, EventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void LblPageCtr_Click(object sender, EventArgs e)
        {

        }

        private void BtnForward_Click_1(object sender, EventArgs e)
        {
            ctrPage++;
            LoadImageBoxes(imageList);
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            ctrPage--;
            ctrPicture -= 6;
            LoadImageBoxes(imageList);
        }
    }
}
