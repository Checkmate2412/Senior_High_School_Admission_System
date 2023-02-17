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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (Uname.Text == "Administrator" && Pword.Text == "administrator")
            {
                this.Hide();
                AMenu AMenu = new AMenu();
                AMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Username/Password");
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu Menu = new Menu();
            Menu.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            float width_ratio = (Screen.PrimaryScreen.Bounds.Width / 1378f);
            float height_ratio = (Screen.PrimaryScreen.Bounds.Height / 780f);

            SizeF scale = new SizeF(width_ratio, height_ratio);
            this.Scale(scale);

            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Calibri Light", control.Font.SizeInPoints * height_ratio * width_ratio);
            }
        }
    }
}