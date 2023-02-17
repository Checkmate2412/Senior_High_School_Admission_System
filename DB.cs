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
  public partial class DB : DevExpress.XtraEditors.XtraForm
  {
    public DB()
    {
      InitializeComponent();
    }

    private void DB_Load(object sender, EventArgs e)
    {
      try
      {
        string myConnection = "datasource=localhost;port=3306;username=Research;password=";
        MySqlConnection myConn = new MySqlConnection(myConnection);
        MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
        myDataAdapter.SelectCommand = new MySqlCommand(" select * [research].[studentapplicationform] ;", myConn);
        MySqlCommandBuilder cd = new MySqlCommandBuilder(myDataAdapter);
        myConn.Open();
        DataSet ds = new DataSet();
        MessageBox.Show("Connected");
        myConn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

      float width_ratio = (Screen.PrimaryScreen.Bounds.Width / 1378f);
      float height_ratio = (Screen.PrimaryScreen.Bounds.Height / 780f);

      SizeF scale = new SizeF(width_ratio, height_ratio);
      this.Scale(scale);

      foreach (Control control in this.Controls)
      {
        control.Font = new Font("Calibri Light", control.Font.SizeInPoints * height_ratio * width_ratio);
      }
    }

    private void Xbtn_Click(object sender, EventArgs e)
    {
      DialogResult dialog = MessageBox.Show("Do you really want to exit? All of your information will be deleted.", "", MessageBoxButtons.YesNo);

      if (dialog == DialogResult.Yes)
      {
        Application.Exit();
      }

      else if (dialog == DialogResult.No)
      {

      }
    }

    private void Dycibtn_Click(object sender, EventArgs e)
    {
      DialogResult dialog = MessageBox.Show("Do you really want to go back? All of your information will be deleted.", "", MessageBoxButtons.YesNo);
      if (dialog == DialogResult.Yes)
      {
        this.Hide();
        AMenu AMenu = new AMenu();
        AMenu.ShowDialog();
      }

      else if (dialog == DialogResult.No)
      {

      }
    }

    private void Pageback6btn_Click(object sender, EventArgs e)
    {
      EBlabel.Show();
      EBpanel.Show();
      Pageback5btn.Show();
      Page7btn.Show();
      GSpanel.Hide();
      GSlabel.Hide();
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
      FBlabel.Show();
      EBpanel.Hide();
      Page7btn.Hide();
      Pageback5btn.Hide();
      EBlabel.Hide();
    }

    private void Page7btn_Click(object sender, EventArgs e)
    {
      GSlabel.Show();
      GSpanel.Show();
      Donebtn.Show();
      Pageback6btn.Show();
      Page7btn.Hide();
      EBpanel.Hide();
      EBlabel.Hide();
      Pageback5btn.Hide();
    }

    private void Pageback4btn_Click(object sender, EventArgs e)
    {
      Pageback3btn.Show();
      Page5btn.Show();
      FBlabel.Show();
      FB2panel.Show();
      Page6btn.Hide();
      Pageback4btn.Hide();
      FB3panel.Hide();
    }

    private void Page6btn_Click(object sender, EventArgs e)
    {
      EBlabel.Show();
      EBpanel.Show();
      Pageback5btn.Show();
      Page7btn.Show();
      Page6btn.Hide();
      FB3panel.Hide();
      FBlabel.Hide();
      Pageback4btn.Hide();
    }

    private void Page5btn_Click(object sender, EventArgs e)
    {
      Pageback4btn.Show();
      FB3panel.Show();
      FBlabel.Show();
      Page6btn.Show();
      Page5btn.Hide();
      Pageback3btn.Hide();
      FB2panel.Hide();
    }

    private void Pageback3btn_Click(object sender, EventArgs e)
    {
      Pageback2btn.Show();
      Page4btn.Show();
      FB1panel.Show();
      FBlabel.Show();
      Page5btn.Hide();
      Pageback3btn.Hide();
      FB2panel.Hide();
    }

    private void Page4btn_Click(object sender, EventArgs e)
    {
      Page5btn.Show();
      Pageback3btn.Show();
      FBlabel.Show();
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
      RDlabel.Show();
      FB1panel.Hide();
      Page4btn.Hide();
      Pageback2btn.Hide();
      FBlabel.Hide();
    }

    private void Page3btn_Click(object sender, EventArgs e)
    {
      FBlabel.Show();
      FB1panel.Show();
      Page4btn.Show();
      Pageback2btn.Show();
      Page3btn.Hide();
      Pageback1btn.Hide();
      RDlabel.Hide();
      RDpanel.Hide();
    }

    private void Page2btn_Click(object sender, EventArgs e)
    {
      Page2btn.Hide();
      PBControl.Hide();
      PBlabel.Hide();
      Page3btn.Show();
      Pageback1btn.Show();
      RDlabel.Show();
      RDpanel.Show();
    }

    private void Pageback1btn_Click(object sender, EventArgs e)
    {
      Page2btn.Show();
      PBControl.Show();
      PBlabel.Show();
      RDpanel.Hide();
      Page3btn.Hide();
      Pageback1btn.Hide();
      RDlabel.Hide();
    }

    private void StdStrandtxt_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (StdStrandtxt.Text == "General Academic Strand (GAS)")
      {
        String First = "While the other Strands are career-specific, the General Academic Strand is great for students who are still undecided on which track to take. You can choose electives from the different academic Strands under this track.";
        String Second = "These subjects include Humanities, Social Sciences, Applied Economics, Organization and Management, and Disaster Preparedness.";

        string GAS = String.Format("\n\n\n{0}\n\n{1}", First, Second);

        StrandInfo.Text = GAS;
      }
      else if (StdStrandtxt.Text == "Accountancy, Business and Management (ABM)")
      {
        String First = "The Accountancy, Business and Management (ABM) strand would focus on the basic concepts of financial management, business management, corporate operations, and all things that are accounted for.";
        String Second = "ABM can also lead you to careers on management and accounting which could be sales manager, human resources, marketing director, project officer, bookkeeper, accounting clerk, internal auditor, and a lot more.";
        String Third = "Sample Fields of Study related to ABM:";
        String Fourth = "Bachelor of Science in Entrepreneurship, Bachelor of Science in Human Resource Development Management, Bachelor of Science in Business Administration, Bachelor of Science in Business Economics, Bachelor of Science major in Accountancy, Bachelor of Science major in Management, Bachelor of Science in Tourism";

        string ABM = String.Format("{0}\n\n{1}\n\n{2}\n\n{3}", First, Second, Third, Fourth);

        StrandInfo.Text = ABM;
      }
      else if (StdStrandtxt.Text == "Science, Technology, Engineering, and Mathematics (STEM)")
      {
        String First = "Science, Technology, Engineering, and Mathematics (STEM) Strand. Science, Technology, Engineering, and Mathematics are intertwining disciplines when applied in the real world. The difference of the STEM curriculum with the other strands and tracks is the focus on advanced concepts and topics.";
        String Second = "Under the track, you can become a pilot, an architect, an astrophysicist, a biologist, a chemist, an engineer, a dentist, a nutritionist, a nurse, a doctor, and a lot more. Those who are also interested in Marine Engineering should take this track.";
        String Third = "Sample Fields of Study related to STEM:";
        String Fourth = "Bachelor of Science in Chemical Engineering, Bachelor of Science in Industrial Engineering, Bachelor of Science in Biology, Bachelor of Science in Mathematics, Bachelor of Science in Architecture, Bachelor of Science in Medical Sciences, Bachelor of Science in Nursing, Bachelor of Science in Pharmacy, Bachelor of Science in Physical Therapy, Bachelor of Science in Occupational Therapy";

        string STEM = String.Format("{0}\n\n{1}\n\n{2}\n\n{3}", First, Second, Third, Fourth);

        StrandInfo.Text = STEM;
      }
      else if (StdStrandtxt.Text == "Humanities and Social Sciences (HUMSS)")
      {
        String First = "The HUMMS strand is designed for those who wonder what is on the other side of the wall. In other words, you are ready to take on the world and talk to a lot of people. This is for those who are considering taking up journalism, communication arts, liberal arts, education, and other social science-related courses in college.";
        String Second = "Sample Fields of Study related to HUMSS:";
        String Third = "Bachelor of Arts in Communication, Bachelor of Elementary Education, Bachelor of Secondary Education, Bachelor of Arts in Journalism, Bachelor of Arts in Broadcast Journalism, Bachelor of Arts major in Social Studies, Bachelor of Arts major in Philosophy, Bachelor of Arts major in Asian Studies, Bachelor of Arts major in Literature, Bachelor of Arts major in Foreign Studies, Bachelor of Arts major in Political Science";

        string HUMSS = String.Format("{0}\n\n{1}\n\n{2}", First, Second, Third);

        StrandInfo.Text = HUMSS;
      }
      else if (StdStrandtxt.Text == "Home Economics (HE)")
      {
        String First = "The Home Economics track offers various specializations that can lead to livelihood projects at home.T his strand aims to give you job-ready skills that can help you in finding the right employment.";
        String Second = "Sample Fields of Study related to HE:";
        String Third = "Certificate in Culinary Arts";

        string HE = String.Format("\n\n{0}\n\n{1}\n\n{2}", First, Second, Third);

        StrandInfo.Text = HE;
      }
      else if (StdStrandtxt.Text == "Information and Communications Technology (ICT)")
      {
        String First = "If you are computer-savvy or a technological freak, step right into Information and Communications Technology (ICT) Strand.";
        String Second = "Under this strand, you will be encouraged to utilize information and communication technological tools to contextualize, collaborate, and create experiences for learning in this professional strand.";
        String Third = "Sample Fields of Study related to ICT:";
        String Fourth = "Computer Programming, Animation, Bachelor of Science in Information Technology, Bachelor of Science in Computer Science, Bachelor of Science in Computer Engineering";

        string ICT = String.Format("\n{0}\n\n{1}\n\n{2}\n\n{3}", First, Second, Third, Fourth);

        StrandInfo.Text = ICT;
      }
      else if (StdStrandtxt.Text == "Pre-Baccalaureate Maritime Specialization")
      {
        String First = "In the pre-baccalaureate maritime specialization, which is a modified program of the Science, Technology, Engineering and Mathematics or STEM strand under the academic track, six specialized subjects of the STEM strand were retained and three were replaced with maritime-related subjects.";
        String Second = "This specialization aims to encourage senior high school graduates to pursue maritime studies in college.";

        string MARITIME = String.Format("\n\n\n{0}\n\n{1}", First, Second);

        StrandInfo.Text = MARITIME;
      }
      else if (StdStrandtxt.Text == "TVL Maritime Specialization")
      {
        String First = "Under the TVL maritime specialization, senior high school students who graduate from the said track will secure certifications allowing them to work as members of a ship’s crew.";
        String Second = "They will be qualified for a job in the maritime industry after graduating and acquiring required certifications.";

        string TVLMS = String.Format("\n\n\n{0}\n\n{1}", First, Second);

        StrandInfo.Text = TVLMS;
      }
    }

    private void Printbtn_Click(object sender, EventArgs e)
    {
      this.Hide();
      PF PF = new PF();
      PF.ShowDialog();
    }
  }
}
