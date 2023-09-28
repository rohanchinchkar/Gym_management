namespace gym
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            newStaffToolStripMenuItem = new ToolStripMenuItem();
            equimentToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            dToolStripMenuItem = new ToolStripMenuItem();
            logToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.ActiveCaptionText;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.GripMargin = new Padding(3);
            menuStrip1.ImageScalingSize = new Size(30, 30);
            menuStrip1.Items.AddRange(new ToolStripItem[] { newStaffToolStripMenuItem, equimentToolStripMenuItem, logOutToolStripMenuItem, dToolStripMenuItem, logToolStripMenuItem, exitToolStripMenuItem1 });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;
            menuStrip1.Location = new Point(9, 170);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(20);
            menuStrip1.Size = new Size(316, 617);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // newStaffToolStripMenuItem
            // 
            newStaffToolStripMenuItem.BackColor = Color.Black;
            newStaffToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            newStaffToolStripMenuItem.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point);
            newStaffToolStripMenuItem.ForeColor = SystemColors.Control;
            newStaffToolStripMenuItem.Image = (Image)resources.GetObject("newStaffToolStripMenuItem.Image");
            newStaffToolStripMenuItem.Margin = new Padding(20);
            newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            newStaffToolStripMenuItem.Size = new Size(242, 41);
            newStaffToolStripMenuItem.Text = "Add Member";
            newStaffToolStripMenuItem.Click += newStaffToolStripMenuItem_Click;
            // 
            // equimentToolStripMenuItem
            // 
            equimentToolStripMenuItem.BackColor = Color.Black;
            equimentToolStripMenuItem.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            equimentToolStripMenuItem.ForeColor = SystemColors.Control;
            equimentToolStripMenuItem.Image = (Image)resources.GetObject("equimentToolStripMenuItem.Image");
            equimentToolStripMenuItem.Margin = new Padding(20);
            equimentToolStripMenuItem.Name = "equimentToolStripMenuItem";
            equimentToolStripMenuItem.Size = new Size(213, 46);
            equimentToolStripMenuItem.Text = "New Staff";
            equimentToolStripMenuItem.Click += equimentToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.BackColor = Color.Black;
            logOutToolStripMenuItem.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            logOutToolStripMenuItem.ForeColor = SystemColors.Control;
            logOutToolStripMenuItem.Image = (Image)resources.GetObject("logOutToolStripMenuItem.Image");
            logOutToolStripMenuItem.Margin = new Padding(20);
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(235, 46);
            logOutToolStripMenuItem.Text = "Equipment";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // dToolStripMenuItem
            // 
            dToolStripMenuItem.BackColor = Color.Black;
            dToolStripMenuItem.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dToolStripMenuItem.ForeColor = SystemColors.Control;
            dToolStripMenuItem.Image = (Image)resources.GetObject("dToolStripMenuItem.Image");
            dToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            dToolStripMenuItem.Margin = new Padding(20);
            dToolStripMenuItem.Name = "dToolStripMenuItem";
            dToolStripMenuItem.Size = new Size(302, 46);
            dToolStripMenuItem.Text = "Delete Member";
            dToolStripMenuItem.Click += dToolStripMenuItem_Click;
            // 
            // logToolStripMenuItem
            // 
            logToolStripMenuItem.BackColor = Color.Black;
            logToolStripMenuItem.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            logToolStripMenuItem.ForeColor = SystemColors.Control;
            logToolStripMenuItem.Image = (Image)resources.GetObject("logToolStripMenuItem.Image");
            logToolStripMenuItem.Margin = new Padding(20);
            logToolStripMenuItem.Name = "logToolStripMenuItem";
            logToolStripMenuItem.Size = new Size(184, 46);
            logToolStripMenuItem.Text = "Log Out";
            logToolStripMenuItem.Click += logToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.BackColor = Color.Black;
            exitToolStripMenuItem1.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            exitToolStripMenuItem1.ForeColor = SystemColors.Control;
            exitToolStripMenuItem1.Image = (Image)resources.GetObject("exitToolStripMenuItem1.Image");
            exitToolStripMenuItem1.Margin = new Padding(20);
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(124, 46);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(878, 694);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.Control;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newStaffToolStripMenuItem;
        private ToolStripMenuItem equimentToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem dToolStripMenuItem;
        private ToolStripMenuItem logToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}