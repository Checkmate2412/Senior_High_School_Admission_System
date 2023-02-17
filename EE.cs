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
    public partial class EE : DevExpress.XtraEditors.XtraForm
    {
        public EE()
        {
            InitializeComponent();
            fillcombo();
        }

        void fillcombo()
        {
            string constring = "datasource=localhost;port=3306;username=Research;password=";
            string Query = "select * from research.studentapplicationform;";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string Adnum = myReader.GetInt32("AdmissionNumber").ToString();

                    AdNumtxt.Properties.Items.Add(Adnum);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dycibtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to go back?", "", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Menu Menu = new Menu();
                Menu.ShowDialog();
            }
        }

        private void Xbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (dialog == DialogResult.No)
            {

            }
        }

        private void EE_Load(object sender, EventArgs e)
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

        private void AdNumtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=Research;password=";
            string Query = "select * from research.studentapplicationform where AdmissionNumber='" + AdNumtxt.Text + "';";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string FName = myReader.GetString("FirstName");
                    string MName = myReader.GetString("MiddleName");
                    string LName = myReader.GetString("LastName");
                    string Suffix = myReader.GetString("Suffix");
                    string Nickname = myReader.GetString("Nickname");
                    string Gender = myReader.GetString("Gender");
                    string Religion = myReader.GetString("Religion");
                    string Nationality = myReader.GetString("Nationality");
                    string Status = myReader.GetString("CivilStatus");
                    string DBirth = myReader.GetString("DateofBirth");
                    string PBirth = myReader.GetString("PlaceofBirth");
                    string BirthOrder = myReader.GetString("BirthOrder");
                    string Age = myReader.GetString("Age");
                    string Email = myReader.GetString("EmailAddress");
                    string ContactNum = myReader.GetString("ContactNumber");
                    string Barangay = myReader.GetString("ApartmentHouseNoStreetBarangay");
                    string City = myReader.GetString("CityMunicipality");
                    string Province = myReader.GetString("ProvinceState");
                    string Country = myReader.GetString("Country");
                    string MothName = myReader.GetString("MothersName");
                    string MothOcc = myReader.GetString("MothersOccupation");
                    string MothEmail = myReader.GetString("MothersEmailAddress");
                    string MothContact = myReader.GetString("MothersContactNumber");
                    string FathName = myReader.GetString("FathersName");
                    string FathOcc = myReader.GetString("FathersOccupation");
                    string FathEmail = myReader.GetString("FathersEmailAddress");
                    string FathContact = myReader.GetString("FathersContactNumber");
                    string GuarName = myReader.GetString("GuardiansName");
                    string GuarOcc = myReader.GetString("GuardiansOccupation");
                    string GuarEmail = myReader.GetString("GuardiansEmailAddress");
                    string GuarContact = myReader.GetString("GuardiansContactNumber");
                    string Income = myReader.GetString("EstimatedTotalAnnualIncome");
                    string Sibling1 = myReader.GetString("BrothersSistersName1");
                    string DOB1 = myReader.GetString("DateofBirth1");
                    string Course1 = myReader.GetString("CourseOccupation1");
                    string SC1 = myReader.GetString("SchoolCompany1");
                    string Sibling2 = myReader.GetString("BrothersSistersName2");
                    string DOB2 = myReader.GetString("DateofBirth2");
                    string Course2 = myReader.GetString("CourseOccupation2");
                    string SC2 = myReader.GetString("SchoolCompany2");
                    string Sibling3 = myReader.GetString("BrothersSistersName3");
                    string DOB3 = myReader.GetString("DateofBirth3");
                    string Course3 = myReader.GetString("CourseOccupation3");
                    string SC3 = myReader.GetString("SchoolCompany3");
                    string Sibling4 = myReader.GetString("BrothersSistersName4");
                    string DOB4 = myReader.GetString("DateofBirth4");
                    string Course4 = myReader.GetString("CourseOccupation4");
                    string SC4 = myReader.GetString("SchoolCompany4");
                    string Sibling5 = myReader.GetString("BrothersSistersName5");
                    string DOB5 = myReader.GetString("DateofBirth5");
                    string Course5 = myReader.GetString("CourseOccupation5");
                    string SC5 = myReader.GetString("SchoolCompany5");
                    string School1 = myReader.GetString("NameofSchool1");
                    string SchoolAdd1 = myReader.GetString("SchoolAddress1");
                    string SchoolYear1 = myReader.GetString("YearGraduated1");
                    string HA1 = myReader.GetString("HonorsAwards1");
                    string School2 = myReader.GetString("NameofSchool2");
                    string SchoolAdd2 = myReader.GetString("SchoolAddress2");
                    string SchoolYear2 = myReader.GetString("YearGraduated2");
                    string HA2 = myReader.GetString("HonorsAwards2");
                    string School3 = myReader.GetString("NameofSchool3");
                    string SchoolAdd3 = myReader.GetString("SchoolAddress3");
                    string SchoolYear3 = myReader.GetString("YearGraduated3");
                    string HA3 = myReader.GetString("HonorsAwards3");
                    string School4 = myReader.GetString("NameofSchool4");
                    string SchoolAdd4 = myReader.GetString("SchoolAddress4");
                    string SchoolYear4 = myReader.GetString("YearGraduated4");
                    string HA4 = myReader.GetString("HonorsAwards4");
                    string School5 = myReader.GetString("NameofSchool5");
                    string SchoolAdd5 = myReader.GetString("SchoolAddress5");
                    string SchoolYear5 = myReader.GetString("YearGraduated5");
                    string HA5 = myReader.GetString("HonorsAwards5");
                    string Grade = myReader.GetString("Grade");
                    string Strand = myReader.GetString("Strand");


                    StdFNtxt.Text = FName;
                    StdMNtxt.Text = MName;
                    StdLNtxt.Text = LName;
                    StdStxt.Text = Suffix;
                    StdNtxt.Text = Nickname;
                    StdGtxt.Text = Gender;
                    StdRtxt.Text = Religion;
                    StdNatxt.Text = Nationality;
                    StdCStxt.Text = Status;
                    StdDBtxt.Text = DBirth;
                    StdPBtxt.Text = PBirth;
                    StdBOtxt.Text = BirthOrder;
                    StdAtxt.Text = Age;
                    StdEAtxt.Text = Email;
                    StdCNtxt.Text = ContactNum;
                    StdAddresstxt.Text = Barangay;
                    StdCitytxt.Text = City;
                    StdProvincetxt.Text = Province;
                    StdCountrytxt.Text = Country;
                    MNtxt.Text = MothName;
                    MOtxt.Text = MothOcc;
                    MEAtxt.Text = MothEmail;
                    MCNtxt.Text = MothContact;
                    FNtxt.Text = FathName;
                    FOtxt.Text = FathOcc;
                    FEAtxt.Text = FathEmail;
                    FCNtxt.Text = FathContact;
                    GNtxt.Text = GuarName;
                    GOtxt.Text = GuarOcc;
                    GEAtxt.Text = GuarEmail;
                    GCNtxt.Text = GuarContact;
                    Incometxt.Text = Income;
                    BSName1txt.Text = Sibling1;
                    BSDB1txt.Text = DOB1;
                    BSCO1txt.Text = Course1;
                    BSSC1txt.Text = SC1;
                    BSName2txt.Text = Sibling2;
                    BSDB2txt.Text = DOB2;
                    BSCO2txt.Text = Course2;
                    BSSC2txt.Text = SC2;
                    BSName3txt.Text = Sibling3;
                    BSDB3txt.Text = DOB3;
                    BSCO3txt.Text = Course3;
                    BSSC3txt.Text = SC3;
                    BSName4txt.Text = Sibling4;
                    BSDB4txt.Text = DOB4;
                    BSCO4txt.Text = Course4;
                    BSSC4txt.Text = SC4;
                    BSName5txt.Text = Sibling5;
                    BSDB5txt.Text = DOB5;
                    BSCO5txt.Text = Course5;
                    BSSC5txt.Text = SC5;
                    School1txt.Text = School1;
                    SchoolAdd1txt.Text = SchoolAdd1;
                    SchoolYG1txt.Text = SchoolYear1;
                    SchoolHA1txt.Text = HA1;
                    School2txt.Text = School2;
                    SchoolAdd2txt.Text = SchoolAdd2;
                    SchoolYG2txt.Text = SchoolYear2;
                    SchoolHA2txt.Text = HA2;
                    School3txt.Text = School3;
                    SchoolAdd3txt.Text = SchoolAdd3;
                    SchoolYG3txt.Text = SchoolYear3;
                    SchoolHA3txt.Text = HA3;
                    School4txt.Text = School4;
                    SchoolAdd4txt.Text = SchoolAdd4;
                    SchoolYG4txt.Text = SchoolYear4;
                    SchoolHA4txt.Text = HA4;
                    School5txt.Text = School5;
                    SchoolAdd5txt.Text = SchoolAdd5;
                    SchoolYG5txt.Text = SchoolYear5;
                    SchoolHA5txt.Text = HA5;
                    StdGradetxt.Text = Grade;
                    StdStrandtxt.Text = Strand;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pageback6btn_Click(object sender, EventArgs e)
        {
            EBpanel.Show();
            Pageback5btn.Show();
            Page7btn.Show();
            GSpanel.Hide();
            Pageback6btn.Hide();
            Donebtn.Hide();
        }

        private void Donebtn_Click(object sender, EventArgs e)
        {

        }

        private void Pageback5btn_Click(object sender, EventArgs e)
        {
            Pageback4btn.Show();
            Page6btn.Show();
            FB3panel.Show();
            EBpanel.Hide();
            Page7btn.Hide();
            Pageback5btn.Hide();
        }

        private void Page7btn_Click(object sender, EventArgs e)
        {
            GSpanel.Show();
            Donebtn.Show();
            Pageback6btn.Show();
            Page7btn.Hide();
            EBpanel.Hide();
            Pageback5btn.Hide();
        }

        private void Pageback4btn_Click(object sender, EventArgs e)
        {
            Pageback3btn.Show();
            Page5btn.Show();
            FB2panel.Show();
            Page6btn.Hide();
            Pageback4btn.Hide();
            FB3panel.Hide();
        }

        private void Page6btn_Click(object sender, EventArgs e)
        {
            EBpanel.Show();
            Pageback5btn.Show();
            Page7btn.Show();
            Page6btn.Hide();
            FB3panel.Hide();
            Pageback4btn.Hide();
        }

        private void Pageback3btn_Click(object sender, EventArgs e)
        {
            Pageback2btn.Show();
            Page4btn.Show();
            FB1panel.Show();
            Page5btn.Hide();
            Pageback3btn.Hide();
            FB2panel.Hide();
        }

        private void Page5btn_Click(object sender, EventArgs e)
        {
            Pageback4btn.Show();
            FB3panel.Show();
            Page6btn.Show();
            Page5btn.Hide();
            Pageback3btn.Hide();
            FB2panel.Hide();
        }

        private void Page4btn_Click(object sender, EventArgs e)
        {
            Page5btn.Show();
            Pageback3btn.Show();
            FB2panel.Show();
            Page4btn.Hide();
            Pageback2btn.Hide();
            FB1panel.Hide();
        }

        private void Pageback2btn_Click(object sender, EventArgs e)
        {
            Pageback1btn.Show();
            Page3btn.Show();
            RDpanel.Show();
            FB1panel.Hide();
            Page4btn.Hide();
            Pageback2btn.Hide();
        }

        private void Page3btn_Click(object sender, EventArgs e)
        {
            FB1panel.Show();
            Page4btn.Show();
            Pageback2btn.Show();
            Page3btn.Hide();
            Pageback1btn.Hide();
            RDpanel.Hide();
        }

        private void Page2btn_Click(object sender, EventArgs e)
        {
            Page2btn.Hide();
            PBControl.Hide();
            Page3btn.Show();
            Pageback1btn.Show();
            RDpanel.Show();
        }

        private void Pageback1btn_Click(object sender, EventArgs e)
        {
            Page2btn.Show();
            PBControl.Show();
            RDpanel.Hide();
            Page3btn.Hide();
            Pageback1btn.Hide();
        }
    }
}