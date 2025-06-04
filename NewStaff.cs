using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_System
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txt_mobile.Clear();
            txt_city.Clear();
            txt_state.Clear();
            txt_email.Clear();


            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
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
            String state = txt_state.Text;
            String city = txt_city.Text;


            
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = DESKTOP-0KCQNJB\\MSSQLSERVER01; database = gymsystem; integrated security = True";
            con.ConnectionString = "data source = DESKTOP-0KCQNJB\\MSSQLSERVER01; database = gymsystem; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Insert into NewStaff  (fname,lname,gender,dob,mobile,email,joindate,statee,city) values('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + joindate + "','" + state + "','" + city + "')";


            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved");


        }

        private void NewStaff_Load(object sender, EventArgs e)
        {

        }

        private void lbl_gymtime_Click(object sender, EventArgs e)
        {

        }
    }
}
