using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_System
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            String fname = txt_fname.Text;
            String lname = txt_lname.Text;

            String gender = "";

            bool isChecked = radioButton1.Checked;

            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;  
            }

            String dob = dateTimePicker1.Text;
            Int64 mobile = Int64.Parse(txt_mobile.Text);
            String email = txt_email.Text;
            String joindate = dateTimePicker2.Text;
            String gymtime = comboBox1.Text;
            String address = txt_address.Text;
            String membership = comboBox2.Text;




            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = DESKTOP-0KCQNJB\\MSSQLSERVER01; database = gymsystem; integrated security = True";
            con.ConnectionString = "data source = DESKTOP-0KCQNJB\\MSSQLSERVER01; database = gymsystem; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText= "Insert into NewMembers  (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,Maddress,MembershipTime) values('"+fname+"','" + lname + "','"+gender+"','"+dob+"','"+mobile+"','"+email+"','"+joindate+"','"+gymtime+"','"+address+"','"+membership+"')";


            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();


            radioButton1.Checked = false;
            radioButton2.Checked = false;


            txt_mobile.Clear();
            txt_email.Clear();


            comboBox1.ResetText();
            comboBox2.ResetText();
            txt_address.Clear();


            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }
    }
}
 