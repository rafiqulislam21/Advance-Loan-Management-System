namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnproductdetails = new System.Windows.Forms.Button();
            this.txtrepaymentacc = new System.Windows.Forms.TextBox();
            this.cmboperiod = new System.Windows.Forms.ComboBox();
            this.txtaccnumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btntypeb = new System.Windows.Forms.RadioButton();
            this.btntypea = new System.Windows.Forms.RadioButton();
            this.txtannex = new System.Windows.Forms.TextBox();
            this.txtloanamount = new System.Windows.Forms.TextBox();
            this.comid = new System.Windows.Forms.Label();
            this.lblcompanyid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 83);
            this.button1.TabIndex = 96;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(265, 455);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 95;
            this.label3.Text = "Available Products";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(522, 240);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(164, 20);
            this.dtp.TabIndex = 93;
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(1067, 228);
            this.txtproductid.Margin = new System.Windows.Forms.Padding(5);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(164, 20);
            this.txtproductid.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(876, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 91;
            this.label1.Text = "Product ID";
            // 
            // btnproductdetails
            // 
            this.btnproductdetails.FlatAppearance.BorderSize = 0;
            this.btnproductdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductdetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductdetails.Image = ((System.Drawing.Image)(resources.GetObject("btnproductdetails.Image")));
            this.btnproductdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductdetails.Location = new System.Drawing.Point(3, 144);
            this.btnproductdetails.Name = "btnproductdetails";
            this.btnproductdetails.Size = new System.Drawing.Size(241, 79);
            this.btnproductdetails.TabIndex = 90;
            this.btnproductdetails.Text = "      Enter product details";
            this.btnproductdetails.UseVisualStyleBackColor = true;
            this.btnproductdetails.Click += new System.EventHandler(this.btnproductdetails_Click_1);
            // 
            // txtrepaymentacc
            // 
            this.txtrepaymentacc.Location = new System.Drawing.Point(1067, 375);
            this.txtrepaymentacc.Margin = new System.Windows.Forms.Padding(5);
            this.txtrepaymentacc.Name = "txtrepaymentacc";
            this.txtrepaymentacc.Size = new System.Drawing.Size(164, 20);
            this.txtrepaymentacc.TabIndex = 89;
            // 
            // cmboperiod
            // 
            this.cmboperiod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboperiod.FormattingEnabled = true;
            this.cmboperiod.Items.AddRange(new object[] {
            "1 year",
            "5 year",
            "10 year",
            "20 year"});
            this.cmboperiod.Location = new System.Drawing.Point(1067, 317);
            this.cmboperiod.Name = "cmboperiod";
            this.cmboperiod.Size = new System.Drawing.Size(164, 24);
            this.cmboperiod.TabIndex = 88;
            this.cmboperiod.Text = "Select period";
            // 
            // txtaccnumber
            // 
            this.txtaccnumber.Location = new System.Drawing.Point(1067, 276);
            this.txtaccnumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtaccnumber.Name = "txtaccnumber";
            this.txtaccnumber.Size = new System.Drawing.Size(164, 20);
            this.txtaccnumber.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(876, 320);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 15);
            this.label13.TabIndex = 86;
            this.label13.Text = "DisImbursment Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(872, 375);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 15);
            this.label12.TabIndex = 85;
            this.label12.Text = "Repayment Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(876, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 84;
            this.label2.Text = "LC account Number";
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 306);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(244, 78);
            this.button7.TabIndex = 83;
            this.button7.Text = "Submit Application";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btntypeb
            // 
            this.btntypeb.AutoSize = true;
            this.btntypeb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btntypeb.Location = new System.Drawing.Point(631, 382);
            this.btntypeb.Margin = new System.Windows.Forms.Padding(5);
            this.btntypeb.Name = "btntypeb";
            this.btntypeb.Size = new System.Drawing.Size(55, 17);
            this.btntypeb.TabIndex = 81;
            this.btntypeb.TabStop = true;
            this.btntypeb.Text = "type B";
            this.btntypeb.UseVisualStyleBackColor = true;
            // 
            // btntypea
            // 
            this.btntypea.AutoSize = true;
            this.btntypea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btntypea.Location = new System.Drawing.Point(522, 382);
            this.btntypea.Margin = new System.Windows.Forms.Padding(5);
            this.btntypea.Name = "btntypea";
            this.btntypea.Size = new System.Drawing.Size(65, 17);
            this.btntypea.TabIndex = 80;
            this.btntypea.TabStop = true;
            this.btntypea.Text = "Type : A";
            this.btntypea.UseVisualStyleBackColor = true;
            // 
            // txtannex
            // 
            this.txtannex.Location = new System.Drawing.Point(522, 292);
            this.txtannex.Margin = new System.Windows.Forms.Padding(5);
            this.txtannex.Name = "txtannex";
            this.txtannex.Size = new System.Drawing.Size(164, 20);
            this.txtannex.TabIndex = 79;
            // 
            // txtloanamount
            // 
            this.txtloanamount.Location = new System.Drawing.Point(522, 334);
            this.txtloanamount.Margin = new System.Windows.Forms.Padding(5);
            this.txtloanamount.Name = "txtloanamount";
            this.txtloanamount.Size = new System.Drawing.Size(164, 20);
            this.txtloanamount.TabIndex = 78;
            // 
            // comid
            // 
            this.comid.AutoSize = true;
            this.comid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comid.Location = new System.Drawing.Point(327, 195);
            this.comid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.comid.Name = "comid";
            this.comid.Size = new System.Drawing.Size(88, 15);
            this.comid.TabIndex = 77;
            this.comid.Text = "Company  ID";
            // 
            // lblcompanyid
            // 
            this.lblcompanyid.AutoSize = true;
            this.lblcompanyid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompanyid.Location = new System.Drawing.Point(518, 192);
            this.lblcompanyid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcompanyid.Name = "lblcompanyid";
            this.lblcompanyid.Size = new System.Drawing.Size(168, 18);
            this.lblcompanyid.TabIndex = 75;
            this.lblcompanyid.Text = "____________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(331, 382);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 76;
            this.label8.Text = "Loan type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(327, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "Registration Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(327, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 74;
            this.label6.Text = "Annex link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(327, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 72;
            this.label4.Text = "Loan amount";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 78);
            this.button2.TabIndex = 97;
            this.button2.Text = "View your products";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(14, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 31);
            this.label5.TabIndex = 98;
            this.label5.Text = "Application Form";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnproductdetails);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 689);
            this.panel1.TabIndex = 99;
            // 
            // dgvproduct
            // 
            this.dgvproduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(253, 497);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.Size = new System.Drawing.Size(1040, 192);
            this.dgvproduct.TabIndex = 94;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1305, 689);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvproduct);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrepaymentacc);
            this.Controls.Add(this.cmboperiod);
            this.Controls.Add(this.txtaccnumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntypeb);
            this.Controls.Add(this.btntypea);
            this.Controls.Add(this.txtannex);
            this.Controls.Add(this.txtloanamount);
            this.Controls.Add(this.comid);
            this.Controls.Add(this.lblcompanyid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnproductdetails;
        private System.Windows.Forms.TextBox txtrepaymentacc;
        private System.Windows.Forms.ComboBox cmboperiod;
        private System.Windows.Forms.TextBox txtaccnumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RadioButton btntypeb;
        private System.Windows.Forms.RadioButton btntypea;
        private System.Windows.Forms.TextBox txtannex;
        private System.Windows.Forms.TextBox txtloanamount;
        private System.Windows.Forms.Label comid;
        private System.Windows.Forms.Label lblcompanyid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvproduct;
    }
}