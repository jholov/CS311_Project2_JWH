namespace CS311_Project2_JWH
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
        }//end Dispose

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(392, 117);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 30);
            this.lbl1.TabIndex = 0;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(526, 117);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 30);
            this.lbl2.TabIndex = 1;
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(47, 41);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(121, 38);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "$100.00";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt1.Location = new System.Drawing.Point(95, 130);
            this.txt1.Name = "txt1";
            this.txt1.PlaceholderText = "Enter Your Bet!";
            this.txt1.Size = new System.Drawing.Size(170, 37);
            this.txt1.TabIndex = 3;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(95, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(119, 97);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Roll";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(430, 260);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(0, 45);
            this.lbl4.TabIndex = 5;
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl5.Location = new System.Drawing.Point(392, 80);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(79, 30);
            this.lbl5.TabIndex = 6;
            this.lbl5.Text = "Die #1";
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl6.Location = new System.Drawing.Point(526, 80);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(79, 30);
            this.lbl6.TabIndex = 7;
            this.lbl6.Text = "Die #2";
            this.lbl6.Click += new System.EventHandler(this.lbl6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS311_Project2_JWH.Properties.Resources.shutterstock_410235007_1;
            this.ClientSize = new System.Drawing.Size(623, 366);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private TextBox txt1;
        private Button btn1;
        private Label lbl4;
        private Label lbl5;
        private Label lbl6;

        private double bankAmount = 100.00;
        private int point;
        private Boolean pointSet = false;

    }//end Form1 

}//end Namespace