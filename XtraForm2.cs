using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Research
{
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm2()
        {
            InitializeComponent();
        }

        int score = 0;
        int timer = 31;

        private void XtraForm2_Load(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (radioButton1.Checked == true)
            {
                score = score + 1;
                label1.Text = Convert.ToString(score);
                groupControl1.Hide();
                groupControl2.Show();
                simpleButton2.Show();
                simpleButton1.Hide();
                timer = 31;
                timer1.Start();
            }
            else
            {
                label1.Text = Convert.ToString(score);
                groupControl1.Hide();
                groupControl2.Show();
                simpleButton1.Hide();
                simpleButton2.Show();
                timer = 31;
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer = timer - 1;
            label2.Text = Convert.ToString(timer);
            if (label2.Text == "0" && radioButton1.Checked == true)
            {
                timer1.Stop();
                score = score + 1;
                label1.Text = Convert.ToString(score);
                groupControl1.Hide();
                groupControl2.Show();
                simpleButton2.Show();
                simpleButton1.Hide();
                timer = 31;
                timer1.Start();
            }
            else if (label2.Text == "0")
            {
                timer1.Stop();
                label1.Text = Convert.ToString(score);
                groupControl1.Hide();
                groupControl2.Show();
                simpleButton2.Show();
                simpleButton1.Hide();
                timer = 31;
                timer1.Start();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                score = score + 1;
                label1.Text = Convert.ToString(score);
                groupControl1.Hide();
                groupControl2.Show();
            }
            else
            {
                label1.Text = Convert.ToString(score);
                groupControl1.Hide();
                groupControl2.Show();
            }
        }

    }
}