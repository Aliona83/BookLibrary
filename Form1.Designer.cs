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
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            lblNumber3 = new Label();
            lblNumber4 = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            txtNumber3 = new TextBox();
            txtNumber4 = new TextBox();
            SuspendLayout();
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Location = new Point(50, 30);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(38, 15);
            lblNumber1.TabIndex = 0;
            lblNumber1.Text = "label1";
            lblNumber1.Click += lblNumber1_Click;
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Location = new Point(50, 68);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(38, 15);
            lblNumber2.TabIndex = 1;
            lblNumber2.Text = "label2";
            lblNumber2.Click += lblNumber2_Click;
            // 
            // lblNumber3
            // 
            lblNumber3.AutoSize = true;
            lblNumber3.Location = new Point(50, 96);
            lblNumber3.Name = "lblNumber3";
            lblNumber3.Size = new Size(38, 15);
            lblNumber3.TabIndex = 2;
            lblNumber3.Text = "label3";
            lblNumber3.Click += lblNumber3_Click;
            // 
            // lblNumber4
            // 
            lblNumber4.AutoSize = true;
            lblNumber4.Location = new Point(50, 125);
            lblNumber4.Name = "lblNumber4";
            lblNumber4.Size = new Size(38, 15);
            lblNumber4.TabIndex = 3;
            lblNumber4.Text = "label4";
            lblNumber4.Click += lblNumber4_Click;
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(155, 27);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(100, 23);
            txtNumber1.TabIndex = 4;
            txtNumber1.TextChanged += txtNumber1_TextChanged;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(155, 59);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(100, 23);
            txtNumber2.TabIndex = 5;
            txtNumber2.TextChanged += txtNumber2_TextChanged;
            // 
            // txtNumber3
            // 
            txtNumber3.Location = new Point(155, 88);
            txtNumber3.Name = "txtNumber3";
            txtNumber3.Size = new Size(100, 23);
            txtNumber3.TabIndex = 6;
            txtNumber3.TextChanged += txtNumber3_TextChanged;
            // 
            // txtNumber4
            // 
            txtNumber4.Location = new Point(155, 117);
            txtNumber4.Name = "txtNumber4";
            txtNumber4.Size = new Size(100, 23);
            txtNumber4.TabIndex = 7;
            txtNumber4.TextChanged += txtNumber4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumber4);
            Controls.Add(txtNumber3);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(lblNumber4);
            Controls.Add(lblNumber3);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber1;
        private Label lblNumber2;
        private Label lblNumber3;
        private Label lblNumber4;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private TextBox txtNumber3;
        private TextBox txtNumber4;
    }
}
