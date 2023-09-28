namespace gym
{
    partial class NewEquipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEquipment));
            label1 = new Label();
            textBoxEquipment = new TextBox();
            richTextBoxDescription = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePickerDelivery = new DateTimePicker();
            textBoxMuscle = new TextBox();
            textBoxCost = new TextBox();
            buttonSave = new Button();
            buttonReset = new Button();
            buttonViewEq = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(239, 177);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 0;
            label1.Text = "Equipment Name";
            // 
            // textBoxEquipment
            // 
            textBoxEquipment.Location = new Point(461, 177);
            textBoxEquipment.Margin = new Padding(4, 3, 4, 3);
            textBoxEquipment.Name = "textBoxEquipment";
            textBoxEquipment.Size = new Size(267, 30);
            textBoxEquipment.TabIndex = 1;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(461, 249);
            richTextBoxDescription.Margin = new Padding(4, 3, 4, 3);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(267, 87);
            richTextBoxDescription.TabIndex = 2;
            richTextBoxDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(239, 249);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(239, 374);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 4;
            label3.Text = "Muscle Used";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(239, 442);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 5;
            label4.Text = "Delivery Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(239, 509);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 6;
            label5.Text = "Cost";
            // 
            // dateTimePickerDelivery
            // 
            dateTimePickerDelivery.Format = DateTimePickerFormat.Short;
            dateTimePickerDelivery.Location = new Point(461, 442);
            dateTimePickerDelivery.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerDelivery.Name = "dateTimePickerDelivery";
            dateTimePickerDelivery.Size = new Size(267, 30);
            dateTimePickerDelivery.TabIndex = 7;
            // 
            // textBoxMuscle
            // 
            textBoxMuscle.Location = new Point(461, 374);
            textBoxMuscle.Margin = new Padding(4, 3, 4, 3);
            textBoxMuscle.Name = "textBoxMuscle";
            textBoxMuscle.Size = new Size(267, 30);
            textBoxMuscle.TabIndex = 8;
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(461, 504);
            textBoxCost.Margin = new Padding(4, 3, 4, 3);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(267, 30);
            textBoxCost.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(214, 579);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(134, 34);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(471, 579);
            buttonReset.Margin = new Padding(4, 3, 4, 3);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(134, 34);
            buttonReset.TabIndex = 11;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonViewEq
            // 
            buttonViewEq.Location = new Point(728, 579);
            buttonViewEq.Margin = new Padding(4, 3, 4, 3);
            buttonViewEq.Name = "buttonViewEq";
            buttonViewEq.Size = new Size(203, 34);
            buttonViewEq.TabIndex = 12;
            buttonViewEq.Text = "View Equipments";
            buttonViewEq.UseVisualStyleBackColor = true;
            buttonViewEq.Click += buttonViewEq_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Aquamarine;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(461, 12);
            pictureBox1.Margin = new Padding(5, 3, 5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // NewEquipment
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1054, 644);
            Controls.Add(pictureBox1);
            Controls.Add(buttonViewEq);
            Controls.Add(buttonReset);
            Controls.Add(buttonSave);
            Controls.Add(textBoxCost);
            Controls.Add(textBoxMuscle);
            Controls.Add(dateTimePickerDelivery);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBoxDescription);
            Controls.Add(textBoxEquipment);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewEquipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewEquipment";
            Load += NewEquipment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxEquipment;
        private RichTextBox richTextBoxDescription;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePickerDelivery;
        private TextBox textBoxMuscle;
        private TextBox textBoxCost;
        private Button buttonSave;
        private Button buttonReset;
        private Button buttonViewEq;
        private PictureBox pictureBox1;
    }
}