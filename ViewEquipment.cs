﻿using System;
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
    public partial class ViewEquipment : Form
    {
        public ViewEquipment()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewEquipment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = DESKTOP-0KCQNJB\\MSSQLSERVER01; database = gymsystem; integrated security = True";
            con.ConnectionString = "data source = DESKTOP-0KCQNJB\\MSSQLSERVER01; database = gymsystem; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Equipmenttable";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
           

        }
    }
}
