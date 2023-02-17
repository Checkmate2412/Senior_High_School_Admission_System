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
using System.Net.Mail;
using System.Net;

namespace Research
{
  public partial class Email : DevExpress.XtraEditors.XtraForm
  {
    public Email()
    {
      InitializeComponent();
      fillcombo();
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

    private void Email_Load(object sender, EventArgs e)
    {
      layoutControlItem4.PaintAppearanceItemCaption.ForeColor = Color.DarkOrange;
      layoutControlItem1.PaintAppearanceItemCaption.ForeColor = Color.DarkOrange;

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
          string Name = myReader.GetString("FirstName") + " " + myReader.GetString("MiddleName") + " " + myReader.GetString("LastName") + " " + myReader.GetString("Suffix") + " ";
          string Email = myReader.GetString("EmailAddress");

          Totxt.Text = Email;
          Nametxt.Text = Name;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      int Number;
      Number = int.Parse(Text.Text);

      if (Number >= 35)
        try
        {
          var client = new SmtpClient("smtp.gmail.com", 587)
          {
            Credentials = new NetworkCredential("example@gmail.com", "password"),
            EnableSsl = true
          };
          String Hello = "Good Day";
          String Exclamation = "!";
          String Name = Nametxt.Text;
          String Message = "We are happy to inform you that you PASSED the entrance exam which you have taken here at *school* for the Senior High School. You were able to got the score of ";
          String Score = Text.Text;
          String Message2 = "/50. The first day of classes will be on (Monday, June 4, 2017). There will be bulletin boards posted around the campus which will inform you about what section are you in.";
          String Message3 = "Thank you so much for trusting DYCI! We are more than a school, a family!";
          String Message4 = "Best Regards,";
          String DYCI = "*school*";

          string Email = String.Format("{0}, {1}{2}\n\n\n{3}{4}{5}\n\n\n{6}\n\n\n{7}\n{8}", Hello, Name, Exclamation, Message, Score, Message2, Message3, Message4, DYCI);

          client.Send("example@gmail.com", Totxt.Text, "Result of Entrance Examination", Email);
          MessageBox.Show("Mail sent", "Success", MessageBoxButtons.OK);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      else if (Number <= 35)
        try
        {
          var client = new SmtpClient("smtp.gmail.com", 587)
          {
            Credentials = new NetworkCredential("example@gmail.com", "password"),
            EnableSsl = true
          };
          String Hello = "Good Day";
          String Exclamation = "!";
          String Name = Nametxt.Text;
          String Message = "We are very sorry to inform you that you were not able to get the passing score in order to have your Senior High School here at *school*. You were able to get the score of ";
          String Score = Text.Text;
          String Message2 = "/50. Please do ask and approach our office if you have your questions regarding this matter. Thank you very much for your cooperation.";
          String Message3 = "Best Regards,";
          String DYCI = "*school*";

          string Email = String.Format("{0}, {1}{2}\n\n\n{3}{4}{5}\n\n\n{6}\n{7}", Hello, Name, Exclamation, Message, Score, Message2, Message3, DYCI);

          client.Send("example@gmail.com", Totxt.Text, "Result of Entrance Examination", Email);
          MessageBox.Show("Mail sent", "Success", MessageBoxButtons.OK);
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
        AMenu AMenu = new AMenu();
        AMenu.ShowDialog();
      }
    }
  }
}
