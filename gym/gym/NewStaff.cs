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

namespace gym
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void NewStaff_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String fname = textBoxFirst.Text;
            String lname = textBoxLastN.Text;

            String gender = "";

            bool ischecked = radioButton1.Checked;

            if (ischecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(textBoxMob.Text);
            String mail = textBoxEmail.Text;
            String joindate = dateTimePickerJoin.Text;
            String state = textBoxState.Text;
            String city = textBoxCity.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-IJUMM2N9\\MSSQLSERVER2022;Initial Catalog=Gym;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewStaff(Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Statee,City) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "'," + mobile + ",'" + mail + "','" + joindate + "','" + state + "','" + city + "')";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            MessageBox.Show("Successfully Added New Staff");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxFirst.Clear();
            textBoxLastN.Clear();
            textBoxEmail.Clear();
            textBoxMob.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoin.Value = DateTime.Now;
            textBoxCity.Clear();
            textBoxState.Clear();
        }
    }
}
