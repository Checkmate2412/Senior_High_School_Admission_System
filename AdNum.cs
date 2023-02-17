using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Research
{
    public partial class AdNum : DevExpress.XtraEditors.XtraForm
    {
        public AdNum()
        {
            InitializeComponent();
        }

        private void AdNum_Load(object sender, EventArgs e)
        {
            float width_ratio = (Screen.PrimaryScreen.Bounds.Width / 1378f);
            float height_ratio = (Screen.PrimaryScreen.Bounds.Height / 780f);

            SizeF scale = new SizeF(width_ratio, height_ratio);
            this.Scale(scale);

            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Calibri Light", control.Font.SizeInPoints * height_ratio * width_ratio);
            }

            string constring = "datasource=localhost;port=3306;username=Research;password=";
            string Query = "select * from research.studentapplicationform ;";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string Adnum = myReader.GetString("AdmissionNumber");
                    Adnumtxt.Text = Adnum;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you going to take the exam?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                EE EE = new EE();
                EE.ShowDialog();
            }

            else if (dialog == DialogResult.No)
            {
                this.Hide();
                Menu Menu = new Menu();
                Menu.ShowDialog();
            }
        }
    }
}