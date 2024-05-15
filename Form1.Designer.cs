namespace BookLibrary
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
            lblNumber2 = new Label();
            lblNumber3 = new Label();
            lblNumber4 = new Label();
            lblNumber5 = new Label();
            btnAdd = new Button();
            btnSubmit = new Button();
            lblNumber6 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnOpen = new Button();
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            txtBox3 = new TextBox();
            txtBox5 = new TextBox();
            lblNumber1 = new Label();
            txt9 = new TextBox();
            txtBox6 = new TextBox();
            SuspendLayout();
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Location = new Point(50, 61);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(47, 15);
            lblNumber2.TabIndex = 1;
            lblNumber2.Text = "Author:";
            lblNumber2.Click += lblNumber2_Click;
            // 
            // lblNumber3
            // 
            lblNumber3.AutoSize = true;
            lblNumber3.Location = new Point(50, 89);
            lblNumber3.Name = "lblNumber3";
            lblNumber3.Size = new Size(41, 15);
            lblNumber3.TabIndex = 2;
            lblNumber3.Text = "Genre:";
            lblNumber3.Click += label3_Click;
            // 
            // lblNumber4
            // 
            lblNumber4.AutoSize = true;
            lblNumber4.Location = new Point(50, 120);
            lblNumber4.Name = "lblNumber4";
            lblNumber4.Size = new Size(99, 15);
            lblNumber4.TabIndex = 3;
            lblNumber4.Text = "Book description:";
            lblNumber4.Click += label4_Click;
            // 
            // lblNumber5
            // 
            lblNumber5.AutoSize = true;
            lblNumber5.Location = new Point(50, 152);
            lblNumber5.Name = "lblNumber5";
            lblNumber5.Size = new Size(88, 15);
            lblNumber5.TabIndex = 4;
            lblNumber5.Text = "Published date:";
            lblNumber5.Click += label5_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(75, 233);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(73, 25);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(156, 233);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(73, 25);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblNumber6
            // 
            lblNumber6.AutoSize = true;
            lblNumber6.Location = new Point(50, 187);
            lblNumber6.Name = "lblNumber6";
            lblNumber6.Size = new Size(59, 15);
            lblNumber6.TabIndex = 7;
            lblNumber6.Text = "Publisher:";
            lblNumber6.Click += lblNumber6_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(237, 233);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(73, 25);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseMnemonic = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(318, 233);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(73, 25);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(399, 233);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(73, 25);
            btnOpen.TabIndex = 12;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            // 
            // txtBox1
            // 
            txtBox1.AccessibleDescription = "";
            txtBox1.AccessibleName = "";
            txtBox1.Location = new Point(268, 22);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(218, 23);
            txtBox1.TabIndex = 13;
            txtBox1.Tag = "";
            txtBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(268, 51);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(218, 23);
            txtBox2.TabIndex = 14;
            txtBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(267, 86);
            txtBox3.Name = "txtBox3";
            txtBox3.Size = new Size(218, 23);
            txtBox3.TabIndex = 15;
            txtBox3.TextChanged += textBox3_TextChanged;
            // 
            // txtBox5
            // 
            txtBox5.Location = new Point(268, 120);
            txtBox5.Name = "txtBox5";
            txtBox5.Size = new Size(218, 23);
            txtBox5.TabIndex = 17;
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Location = new Point(50, 30);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(74, 15);
            lblNumber1.TabIndex = 18;
            lblNumber1.Text = "Book of title:";
            lblNumber1.Click += label1_Click_1;
            // 
            // txt9
            // 
            txt9.Location = new Point(267, 184);
            txt9.Name = "txt9";
            txt9.Size = new Size(218, 23);
            txt9.TabIndex = 20;
            // 
            // txtBox6
            // 
            txtBox6.Location = new Point(267, 155);
            txtBox6.Name = "txtBox6";
            txtBox6.Size = new Size(218, 23);
            txtBox6.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 450);
            Controls.Add(txt9);
            Controls.Add(txtBox6);
            Controls.Add(lblNumber1);
            Controls.Add(txtBox5);
            Controls.Add(txtBox3);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Controls.Add(btnOpen);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblNumber6);
            Controls.Add(btnSubmit);
            Controls.Add(btnAdd);
            Controls.Add(lblNumber5);
            Controls.Add(lblNumber4);
            Controls.Add(lblNumber3);
            Controls.Add(lblNumber2);
            Name = "Form1";
            Text = "Book Library";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblNumber2;
        private Label lblNumber3;
        private Button button1;
        private Button btnAdd;
        private Label lblNumber4;
        private Label lblNumber5;
        private Label lblNumber6;
        private Button btnSubmit;
        private CheckBox checkBox1;
        private Button button2;
        private Button button3;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnOpen;
        private TextBox txtBox1;
        private TextBox txtBox2;
        private TextBox txtBox3;
        private TextBox txtBox5;
        private TextBox txt9;
        private TextBox txtBox6;
    }
}
