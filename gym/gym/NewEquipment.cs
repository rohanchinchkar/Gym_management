using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace gym
{
    public partial class NewEquipment : Form
    {
        public NewEquipment()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String eqName = textBoxEquipment.Text;
            String Descp = richTextBoxDescription.Text;
            String muscle = textBoxMuscle.Text;
            String Delivery = dateTimePickerDelivery.Text;
            String cost = textBoxCost.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-IJUMM2N9\\MSSQLSERVER2022;Initial Catalog=Gym;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Equipment(EquipName, EDescription, MUsed, DDate, Cost) values ('" + eqName + "','" + Descp + "','" + muscle + "','" + Delivery + "','" + cost + "')";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            MessageBox.Show("Successfully Added New Equipment");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxEquipment.Clear();
            richTextBoxDescription.Clear();
            textBoxMuscle.Clear();
            textBoxCost.Clear();
            dateTimePickerDelivery.Value = DateTime.Now;

        }

        private void NewEquipment_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewEq_Click(object sender, EventArgs e)
        {
            ViewEq vEq = new ViewEq();
            vEq.Show();

        }
    }
}
