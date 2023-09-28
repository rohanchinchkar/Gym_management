namespace gym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember demem = new DeleteMember();
            demem.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember ad = new AddMember();
            ad.Show();


        }

        private void equimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaff stf = new NewStaff();
            stf.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Login L1 = new Login();
            L1.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEquipment neeq = new NewEquipment();
            neeq.Show();
        }
    }
}