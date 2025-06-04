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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_equipname.Clear();
            txt_description.Clear();
            txt_muscles.Clear();
            txt_cost.Clear();
            dob_ddate.Value = DateTime.Now;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String EquipName = txt_equipname.Text;
            String Description = txt_description.Text;
            String MUsed = txt_muscles.Text;
            String DDate = dob_ddate.Text;
            Int64 Cost = Int64.Parse(txt_cost.Text);

            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = DESKTOP-0KCQNJB\\MSSQLSERVER01; database = gymsystem; integrated security = True";
            con.ConnectionString = "Data Source=DESKTOP-0KCQNJB\\MSSQLSERVER01;Initial Catalog=gymsystem;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Insert into Equipmenttable (EquipName,EDescription,MUsed,DDate,Cost) values ('" + txt_equipname.Text + "','" + txt_description.Text + "','" + txt_muscles.Text + "','" + dob_ddate.Text + "'," + txt_cost.Text + ")";

            
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.","Inserted",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btn_viewequip_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
    }
}
