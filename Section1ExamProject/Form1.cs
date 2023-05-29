using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section1ExamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lblSent.Text = "The most recent sent message: " + txtbxMessage.Text;
            txtbxMessage.Text = " ";
        }

        private void BlankSpace_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += " ";
        }

        private void btnDigit1_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "1";
        }

        private void btnDigit2_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "2";
        }

        private void btnDigit3_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "3";
        }

        private void btnDigit4_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "4";
        }

        private void btnDigit5_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "5";
        }

        private void btnDigit6_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "6";
        }

        private void btnDigit7_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "7";
        }

        private void btnDigit8_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "8";
        }

        private void btnDigit9_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "9";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "A";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "B";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "C";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "D";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "E";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "F";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "G";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "H";
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "I";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "J";
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "K";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "L";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "M";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "N";
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "O";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "P";
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "Q";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "R";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "S";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "T";
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "U";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "V";
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "W";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "X";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "Y";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += "Z";
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            txtbxMessage.Text += ".";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
