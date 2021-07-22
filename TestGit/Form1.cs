using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGit
{
    public partial class frmGitTest : Form
    {
        public frmGitTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAnswer.Text = "";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(txtInput.Text());

            input = Math.Sqrt(input);

            lblAnswer.Text = input.ToString();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(txtInput);

            input = Math.Pow(input, 2);

            lblAnswer.Text = input.ToString();
        }
    }
}
