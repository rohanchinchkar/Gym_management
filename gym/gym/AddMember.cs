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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
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
            String gymt = comboBoxTime.Text;
            String adress = richTextBoxAdress.Text;
            String membershipT = comboBoxMembership.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-IJUMM2N9\\MSSQLSERVER2022;Initial Catalog=Gym;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewMember(Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,Maddress,MembershipTime) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "'," + mobile + ",'" + mail + "','" + joindate + "','" + gymt + "','" + adress + "','" + membershipT + "')";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            MessageBox.Show("Successfully Added New Member");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxFirst.Clear();
            textBoxLastN.Clear();
            textBoxEmail.Clear();
            textBoxMob.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            comboBoxTime.ResetText();
            comboBoxMembership.ResetText();

            richTextBoxAdress.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoin.Value = DateTime.Now;

        }

        private void textBoxFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
        }
    }
}
