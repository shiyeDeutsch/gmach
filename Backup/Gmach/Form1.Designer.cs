namespace Gmach
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateASavingsPlan = new System.Windows.Forms.Button();
            this.Tracking = new System.Windows.Forms.Button();
            this.Payments = new System.Windows.Forms.Button();
            this.createAMember = new System.Windows.Forms.Button();
            this.Members = new System.Windows.Forms.Button();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.panelLoans = new System.Windows.Forms.Panel();
            this.controlerDate2 = new Gmach.ControlerDate();
            this.textSirech = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.controlerDate1 = new Gmach.ControlerDate();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.panelLoans.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.CreateASavingsPlan);
            this.panel1.Controls.Add(this.Tracking);
            this.panel1.Controls.Add(this.Payments);
            this.panel1.Controls.Add(this.createAMember);
            this.panel1.Controls.Add(this.Members);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 235);
            this.panel1.TabIndex = 0;
            // 
            // CreateASavingsPlan
            // 
            this.CreateASavingsPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateASavingsPlan.Location = new System.Drawing.Point(0, 188);
            this.CreateASavingsPlan.Name = "CreateASavingsPlan";
            this.CreateASavingsPlan.Size = new System.Drawing.Size(121, 47);
            this.CreateASavingsPlan.TabIndex = 4;
            this.CreateASavingsPlan.Text = "צור תוכנית חסכון";
            this.CreateASavingsPlan.UseVisualStyleBackColor = true;
            // 
            // Tracking
            // 
            this.Tracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tracking.Location = new System.Drawing.Point(0, 0);
            this.Tracking.Name = "Tracking";
            this.Tracking.Size = new System.Drawing.Size(121, 47);
            this.Tracking.TabIndex = 0;
            this.Tracking.Text = "פעולות";
            this.Tracking.UseVisualStyleBackColor = true;
            this.Tracking.Click += new System.EventHandler(this.Tracking_Click);
            // 
            // Payments
            // 
            this.Payments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payments.Location = new System.Drawing.Point(0, 94);
            this.Payments.Name = "Payments";
            this.Payments.Size = new System.Drawing.Size(121, 47);
            this.Payments.TabIndex = 2;
            this.Payments.Text = "צור הלואה";
            this.Payments.UseVisualStyleBackColor = true;
            this.Payments.Click += new System.EventHandler(this.Payments_Click);
            // 
            // createAMember
            // 
            this.createAMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAMember.Location = new System.Drawing.Point(0, 141);
            this.createAMember.Name = "createAMember";
            this.createAMember.Size = new System.Drawing.Size(121, 47);
            this.createAMember.TabIndex = 3;
            this.createAMember.Text = "צור חבר";
            this.createAMember.UseVisualStyleBackColor = true;
            this.createAMember.Click += new System.EventHandler(this.createAMember_Click);
            // 
            // Members
            // 
            this.Members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Members.Location = new System.Drawing.Point(0, 47);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(121, 47);
            this.Members.TabIndex = 1;
            this.Members.Text = "כרטיס חבר";
            this.Members.UseVisualStyleBackColor = true;
            this.Members.Click += new System.EventHandler(this.Members_Click);
            // 
            // dgvLoans
            // 
            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(0, 47);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.Size = new System.Drawing.Size(560, 465);
            this.dgvLoans.TabIndex = 0;
            // 
            // panelLoans
            // 
            this.panelLoans.Controls.Add(this.controlerDate2);
            this.panelLoans.Controls.Add(this.textSirech);
            this.panelLoans.Controls.Add(this.label3);
            this.panelLoans.Controls.Add(this.dgvLoans);
            this.panelLoans.Controls.Add(this.label4);
            this.panelLoans.Controls.Add(this.checkBox2);
            this.panelLoans.Location = new System.Drawing.Point(55, 55);
            this.panelLoans.Name = "panelLoans";
            this.panelLoans.Size = new System.Drawing.Size(538, 512);
            this.panelLoans.TabIndex = 7;
            this.panelLoans.Visible = false;
            // 
            // controlerDate2
            // 
            this.controlerDate2.Location = new System.Drawing.Point(21, 15);
            this.controlerDate2.Name = "controlerDate2";
            this.controlerDate2.Size = new System.Drawing.Size(125, 20);
            this.controlerDate2.TabIndex = 13;
            this.controlerDate2.TextDate = "";
            // 
            // textSirech
            // 
            this.textSirech.Location = new System.Drawing.Point(243, 15);
            this.textSirech.Name = "textSirech";
            this.textSirech.Size = new System.Drawing.Size(114, 20);
            this.textSirech.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "תאריך";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "שם";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(441, 18);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "הלואת פעילם";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(0, 235);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(121, 47);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "דוחו\"ת";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // controlerDate1
            // 
            this.controlerDate1.Location = new System.Drawing.Point(673, 111);
            this.controlerDate1.Name = "controlerDate1";
            this.controlerDate1.Size = new System.Drawing.Size(123, 20);
            this.controlerDate1.TabIndex = 8;
            this.controlerDate1.TextDate = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 442);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "גמ\"ח";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.panelLoans.ResumeLayout(false);
            this.panelLoans.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Members;
        private System.Windows.Forms.Button Payments;
        private System.Windows.Forms.Button createAMember;
        private System.Windows.Forms.Button Tracking;
        private System.Windows.Forms.Button CreateASavingsPlan;
        private System.Windows.Forms.Panel panelLoans;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.Label label3;
        private ControlerDate controlerDate2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textSirech;
        private ControlerDate controlerDate1;
        private System.Windows.Forms.Button btnReport;


    }
}

