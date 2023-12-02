namespace Assignment5_DataStorage
{
    partial class UserManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManual));
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            CopyrightLabel = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 18);
            label2.Name = "label2";
            label2.Size = new Size(370, 80);
            label2.TabIndex = 0;
            label2.Text = "How to add a new record\r\n\r\n1) Enter all the details into the provided text fields\r\n2) Click the Check button to make sure everything is valid\r\n3) Click the register button to insert it into the table";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 18);
            label5.Name = "label5";
            label5.Size = new Size(215, 64);
            label5.TabIndex = 1;
            label5.Text = "How to load a record\r\n\r\n1) select a row\r\n2) press the load button to view ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 18);
            label3.Name = "label3";
            label3.Size = new Size(335, 96);
            label3.TabIndex = 1;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 27);
            label4.Name = "label4";
            label4.Size = new Size(174, 64);
            label4.TabIndex = 1;
            label4.Text = "How to delete a record\r\n\r\n1) First Select a row\r\n2) Press the delete button\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 19);
            label1.Name = "label1";
            label1.Size = new Size(247, 20);
            label1.TabIndex = 4;
            label1.Text = "Welcome to the User Manual";
            // 
            // CopyrightLabel
            // 
            CopyrightLabel.AutoSize = true;
            CopyrightLabel.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            CopyrightLabel.Location = new Point(58, 517);
            CopyrightLabel.Margin = new Padding(1, 0, 1, 0);
            CopyrightLabel.Name = "CopyrightLabel";
            CopyrightLabel.Size = new Size(277, 15);
            CopyrightLabel.TabIndex = 14;
            CopyrightLabel.Text = "Copyright © Ramiyan Gangatharan - DC 2023 ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 121);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Record";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(383, 121);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Record";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(12, 409);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(383, 105);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Delete Row / Delete All ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 27);
            label6.Name = "label6";
            label6.Size = new Size(166, 64);
            label6.TabIndex = 2;
            label6.Text = "How to Delete all records\r\n\r\n1) Press Delete All\r\n2) confirm Deletion";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(12, 306);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(383, 97);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Loading Records";
            // 
            // UserManual
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 541);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(CopyrightLabel);
            Controls.Add(label1);
            Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UserManual";
            Text = "User Manual";
            Load += UserManual_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label CopyrightLabel;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private GroupBox groupBox4;
    }
}