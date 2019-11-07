using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class MarketPlace : Form
    {
        public MarketPlace()
        {
            InitializeComponent();
        }

        private void BtnBounties_Click(object sender, EventArgs e)
        {
            new Bounties().ShowDialog();
        }

        private void MarketPlace_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new PostBounty().ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new Account().ShowDialog();
        }
    }
}
