namespace Gmach
{
    partial class ViewTheLoans
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
            this.btnClose = new System.Windows.Forms.Button();
            this.textIDNum = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textFatherName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textLoanDate = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labPayments = new System.Windows.Forms.Label();
            this.labLoanAmount = new System.Windows.Forms.Label();
            this.textNumOfPayments = new System.Windows.Forms.TextBox();
            this.textLoantAmount = new System.Windows.Forms.TextBox();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.loans_DS = new Gmach.Loans_DS();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loans_DS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(230, 461);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 23);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "סגור";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textIDNum
            // 
            this.textIDNum.Location = new System.Drawing.Point(237, 97);
            this.textIDNum.Name = "textIDNum";
            this.textIDNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textIDNum.Size = new System.Drawing.Size(101, 20);
            this.textIDNum.TabIndex = 4;
            this.textIDNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(237, 18);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textFirstName.Size = new System.Drawing.Size(101, 20);
            this.textFirstName.TabIndex = 5;
            this.textFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(237, 45);
            this.textLastName.Name = "textLastName";
            this.textLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textLastName.Size = new System.Drawing.Size(101, 20);
            this.textLastName.TabIndex = 2;
            this.textLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "מספר זהות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "שם פרטי";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "שם האב";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "שם משפחה";
            // 
            // textFatherName
            // 
            this.textFatherName.Location = new System.Drawing.Point(237, 71);
            this.textFatherName.Name = "textFatherName";
            this.textFatherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textFatherName.Size = new System.Drawing.Size(101, 20);
            this.textFatherName.TabIndex = 3;
            this.textFatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textIDNum);
            this.groupBox1.Controls.Add(this.textFirstName);
            this.groupBox1.Controls.Add(this.textLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textFatherName);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(447, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטים אישיים";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textLoanDate);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.labPayments);
            this.groupBox2.Controls.Add(this.labLoanAmount);
            this.groupBox2.Controls.Add(this.textNumOfPayments);
            this.groupBox2.Controls.Add(this.textLoantAmount);
            this.groupBox2.Location = new System.Drawing.Point(42, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 149);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "פרטי ההלואה";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "ערבים";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "תאריך הלואה";
            // 
            // textLoanDate
            // 
            this.textLoanDate.Location = new System.Drawing.Point(261, 85);
            this.textLoanDate.Name = "textLoanDate";
            this.textLoanDate.Size = new System.Drawing.Size(77, 20);
            this.textLoanDate.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(168, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(59, 64);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "מטבע";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 95;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "דולר";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 94;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "שקל";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labPayments
            // 
            this.labPayments.AutoSize = true;
            this.labPayments.Location = new System.Drawing.Point(355, 69);
            this.labPayments.Name = "labPayments";
            this.labPayments.Size = new System.Drawing.Size(84, 13);
            this.labPayments.TabIndex = 83;
            this.labPayments.Text = "מספר תשלומים";
            // 
            // labLoanAmount
            // 
            this.labLoanAmount.AutoSize = true;
            this.labLoanAmount.Location = new System.Drawing.Point(366, 45);
            this.labLoanAmount.Name = "labLoanAmount";
            this.labLoanAmount.Size = new System.Drawing.Size(73, 13);
            this.labLoanAmount.TabIndex = 82;
            this.labLoanAmount.Text = " סכום הלואה";
            // 
            // textNumOfPayments
            // 
            this.textNumOfPayments.Location = new System.Drawing.Point(277, 62);
            this.textNumOfPayments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNumOfPayments.Name = "textNumOfPayments";
            this.textNumOfPayments.Size = new System.Drawing.Size(61, 20);
            this.textNumOfPayments.TabIndex = 1;
            // 
            // textLoantAmount
            // 
            this.textLoantAmount.Location = new System.Drawing.Point(277, 38);
            this.textLoantAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textLoantAmount.Name = "textLoantAmount";
            this.textLoantAmount.Size = new System.Drawing.Size(61, 20);
            this.textLoantAmount.TabIndex = 0;
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(302, 151);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(78, 20);
            this.textBalance.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "החוב הנוכחי";
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.AllowUserToAddRows = false;
            this.dataGridViewPayments.AllowUserToDeleteRows = false;
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(42, 323);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.ReadOnly = true;
            this.dataGridViewPayments.Size = new System.Drawing.Size(447, 116);
            this.dataGridViewPayments.TabIndex = 97;
            this.dataGridViewPayments.DoubleClick += new System.EventHandler(this.dataGridViewPayments_DoubleClick_1);
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(23, 461);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 98;
            this.btnOK.Text = "שמור פרטים";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(123, 461);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "עדכן פרטים";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // loans_DS
            // 
            this.loans_DS.DataSetName = "Loans_DS";
            this.loans_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewTheLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 505);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGridViewPayments);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "ViewTheLoans";
            this.Text = "c";
            this.Load += new System.EventHandler(this.ViewTheLoans_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loans_DS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textIDNum;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFatherName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        protected System.Windows.Forms.Label labLoanAmount;
        protected System.Windows.Forms.TextBox textLoantAmount;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label labPayments;
        protected System.Windows.Forms.TextBox textNumOfPayments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textLoanDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnUpdate;
        private Loans_DS loans_DS;
      //  private DataSet1 dataSet1;
      //  private System.Windows.Forms.BindingSource aABindingSource;
    //    private Gmach.DataSet1TableAdapters.AATableAdapter aATableAdapter;
    }
}