namespace WindowsFormsApp1
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.display2 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtapprove = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnapprove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtloanrepaid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtloanremark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateloanissue = new System.Windows.Forms.DateTimePicker();
            this.cmboxdeadline = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.display2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display2
            // 
            this.display2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display2.Location = new System.Drawing.Point(221, 118);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(828, 251);
            this.display2.TabIndex = 0;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(878, 75);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(141, 30);
            this.txtsearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(217, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Application Forms";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 76);
            this.button3.TabIndex = 1;
            this.button3.Text = "View All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(680, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 55);
            this.button4.TabIndex = 1;
            this.button4.Text = "    Search by company id";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtapprove
            // 
            this.txtapprove.Location = new System.Drawing.Point(884, 454);
            this.txtapprove.Multiline = true;
            this.txtapprove.Name = "txtapprove";
            this.txtapprove.Size = new System.Drawing.Size(165, 35);
            this.txtapprove.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 178);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 78);
            this.button6.TabIndex = 4;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnapprove
            // 
            this.btnapprove.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapprove.Image = ((System.Drawing.Image)(resources.GetObject("btnapprove.Image")));
            this.btnapprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnapprove.Location = new System.Drawing.Point(680, 428);
            this.btnapprove.Name = "btnapprove";
            this.btnapprove.Size = new System.Drawing.Size(188, 75);
            this.btnapprove.TabIndex = 5;
            this.btnapprove.Text = "    Approve loan by id";
            this.btnapprove.UseVisualStyleBackColor = true;
            this.btnapprove.Click += new System.EventHandler(this.btnapprove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(321, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loan Repaid";
            // 
            // txtloanrepaid
            // 
            this.txtloanrepaid.Location = new System.Drawing.Point(467, 402);
            this.txtloanrepaid.Name = "txtloanrepaid";
            this.txtloanrepaid.Size = new System.Drawing.Size(149, 20);
            this.txtloanrepaid.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(318, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loan Remark";
            // 
            // txtloanremark
            // 
            this.txtloanremark.Location = new System.Drawing.Point(467, 428);
            this.txtloanremark.Name = "txtloanremark";
            this.txtloanremark.Size = new System.Drawing.Size(149, 20);
            this.txtloanremark.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(318, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loan issue date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(318, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Payment Dead line";
            // 
            // dateloanissue
            // 
            this.dateloanissue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateloanissue.Location = new System.Drawing.Point(467, 487);
            this.dateloanissue.Name = "dateloanissue";
            this.dateloanissue.Size = new System.Drawing.Size(149, 20);
            this.dateloanissue.TabIndex = 8;
            // 
            // cmboxdeadline
            // 
            this.cmboxdeadline.FormattingEnabled = true;
            this.cmboxdeadline.Items.AddRange(new object[] {
            "1 year",
            "5 year",
            "10 year",
            "20 year"});
            this.cmboxdeadline.Location = new System.Drawing.Point(467, 454);
            this.cmboxdeadline.Name = "cmboxdeadline";
            this.cmboxdeadline.Size = new System.Drawing.Size(149, 21);
            this.cmboxdeadline.TabIndex = 9;
            this.cmboxdeadline.Text = "Select Deadline";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(227, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 31);
            this.label7.TabIndex = 39;
            this.label7.Text = "Application Approvals";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 561);
            this.panel1.TabIndex = 40;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnapprove);
            this.Controls.Add(this.txtapprove);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.cmboxdeadline);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.dateloanissue);
            this.Controls.Add(this.txtloanrepaid);
            this.Controls.Add(this.txtloanremark);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "Application Approvals";
            ((System.ComponentModel.ISupportInitialize)(this.display2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView display2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtapprove;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnapprove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtloanrepaid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtloanremark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateloanissue;
        private System.Windows.Forms.ComboBox cmboxdeadline;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}