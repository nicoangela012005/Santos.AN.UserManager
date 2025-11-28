namespace Santos.AN.UserManager
{
    partial class DetailsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 21);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "User Details";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 94);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Full Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 69);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "UserID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 132);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 192);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Password: ";
            // 
            // button1
            // 
            button1.Location = new Point(164, 234);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(183, 69);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 6;
            label6.Text = "42743240";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(183, 94);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 7;
            label7.Text = "Angela Nicole Santos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(199, 164);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(183, 149);
            label9.Name = "label9";
            label9.Size = new Size(153, 15);
            label9.TabIndex = 9;
            label9.Text = "hed-ansantos@smu.edu.ph";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(183, 192);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 10;
            label10.Text = "pogikoshet";
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 311);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetailsForm";
            Text = "DetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}