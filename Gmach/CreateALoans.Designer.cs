namespace Gmach
{
    partial class CreateALoans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnHrivim = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSelectedHarivem = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridMembers = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMembresList = new System.Windows.Forms.Button();
            this.textFatherName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textSearchMembers = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.lebIdNum = new System.Windows.Forms.Label();
            this.lebName = new System.Windows.Forms.Label();
            this.textIdNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.combLoanReasons = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateLoant = new Gmach.ControlerDate();
            this.textAmountOfOnePayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labPayments = new System.Windows.Forms.Label();
            this.labLoanAmount = new System.Windows.Forms.Label();
            this.textNumOfPayments = new System.Windows.Forms.TextBox();
            this.textLoantAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateOfFirstPayment = new Gmach.ControlerDate();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedHarivem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnHrivim);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dgvSelectedHarivem);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.dataGridMembers);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.SaveButton);
            this.tabPage1.Controls.Add(this.combLoanReasons);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnHrivim
            // 
            this.btnHrivim.Location = new System.Drawing.Point(540, 441);
            this.btnHrivim.Name = "btnHrivim";
            this.btnHrivim.Size = new System.Drawing.Size(129, 23);
            this.btnHrivim.TabIndex = 101;
            this.btnHrivim.Text = "הוסף ערב";
            this.btnHrivim.UseVisualStyleBackColor = true;
            this.btnHrivim.Click += new System.EventHandler(this.btnHrivim_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(570, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 100;
            this.label8.Text = "ערבים";
            // 
            // dgvSelectedHarivem
            // 
            this.dgvSelectedHarivem.AllowUserToAddRows = false;
            this.dgvSelectedHarivem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectedHarivem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectedHarivem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectedHarivem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSelectedHarivem.Location = new System.Drawing.Point(363, 290);
            this.dgvSelectedHarivem.Name = "dgvSelectedHarivem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectedHarivem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSelectedHarivem.Size = new System.Drawing.Size(470, 145);
            this.dgvSelectedHarivem.TabIndex = 99;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(153, 441);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 98;
            this.btnClose.Text = "סגור";
            this.btnClose.UseVisualStyleBackColor = true;
          //  this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridMembers
            // 
            this.dataGridMembers.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMembers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridMembers.Location = new System.Drawing.Point(362, 141);
            this.dataGridMembers.Name = "dataGridMembers";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridMembers.Size = new System.Drawing.Size(470, 131);
            this.dataGridMembers.TabIndex = 95;
            this.dataGridMembers.Visible = false;
            this.dataGridMembers.DoubleClick += new System.EventHandler(this.dataGridMembers_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMembresList);
            this.groupBox3.Controls.Add(this.textFatherName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textSearchMembers);
            this.groupBox3.Controls.Add(this.textName);
            this.groupBox3.Controls.Add(this.lebIdNum);
            this.groupBox3.Controls.Add(this.lebName);
            this.groupBox3.Controls.Add(this.textIdNum);
            this.groupBox3.Location = new System.Drawing.Point(362, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 151);
            this.groupBox3.TabIndex = 86;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "פרטי הלוה";
            // 
            // btnMembresList
            // 
            this.btnMembresList.Location = new System.Drawing.Point(69, 88);
            this.btnMembresList.Name = "btnMembresList";
            this.btnMembresList.Size = new System.Drawing.Size(75, 23);
            this.btnMembresList.TabIndex = 98;
            this.btnMembresList.Text = "חברים";
            this.btnMembresList.UseVisualStyleBackColor = true;
            this.btnMembresList.Click += new System.EventHandler(this.btnMembresList_Click);
            // 
            // textFatherName
            // 
            this.textFatherName.Enabled = false;
            this.textFatherName.Location = new System.Drawing.Point(259, 57);
            this.textFatherName.Name = "textFatherName";
            this.textFatherName.Size = new System.Drawing.Size(123, 20);
            this.textFatherName.TabIndex = 81;
            this.textFatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
          //  this.textFatherName.TextChanged += new System.EventHandler(this.textFatherName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "חיפש";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "\'בן ר";
            // 
            // textSearchMembers
            // 
            this.textSearchMembers.Location = new System.Drawing.Point(43, 50);
            this.textSearchMembers.Name = "textSearchMembers";
            this.textSearchMembers.Size = new System.Drawing.Size(123, 20);
            this.textSearchMembers.TabIndex = 96;
            this.textSearchMembers.TextChanged += new System.EventHandler(this.textSearchMembers_TextChanged);
            // 
            // textName
            // 
            this.textName.Enabled = false;
            this.textName.Location = new System.Drawing.Point(259, 25);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(123, 20);
            this.textName.TabIndex = 78;
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lebIdNum
            // 
            this.lebIdNum.AutoSize = true;
            this.lebIdNum.Location = new System.Drawing.Point(401, 93);
            this.lebIdNum.Name = "lebIdNum";
            this.lebIdNum.Size = new System.Drawing.Size(61, 13);
            this.lebIdNum.TabIndex = 77;
            this.lebIdNum.Text = "מספר זהות";
            // 
            // lebName
            // 
            this.lebName.AutoSize = true;
            this.lebName.Location = new System.Drawing.Point(411, 32);
            this.lebName.Name = "lebName";
            this.lebName.Size = new System.Drawing.Size(23, 13);
            this.lebName.TabIndex = 76;
            this.lebName.Text = "שם";
            // 
            // textIdNum
            // 
            this.textIdNum.Enabled = false;
            this.textIdNum.Location = new System.Drawing.Point(259, 90);
            this.textIdNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textIdNum.Name = "textIdNum";
            this.textIdNum.Size = new System.Drawing.Size(123, 20);
            this.textIdNum.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "סיבת ההלוואה";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(53, 441);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 90;
            this.SaveButton.Text = "שמור";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // combLoanReasons
            // 
            this.combLoanReasons.FormattingEnabled = true;
            this.combLoanReasons.Location = new System.Drawing.Point(27, 347);
            this.combLoanReasons.Name = "combLoanReasons";
            this.combLoanReasons.Size = new System.Drawing.Size(230, 21);
            this.combLoanReasons.TabIndex = 91;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateLoant);
            this.groupBox2.Controls.Add(this.textAmountOfOnePayment);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.labPayments);
            this.groupBox2.Controls.Add(this.labLoanAmount);
            this.groupBox2.Controls.Add(this.textNumOfPayments);
            this.groupBox2.Controls.Add(this.textLoantAmount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateOfFirstPayment);
            this.groupBox2.Location = new System.Drawing.Point(6, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 274);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "פרטי ההלואה";
            // 
            // dateLoant
            // 
            this.dateLoant.Location = new System.Drawing.Point(128, 177);
            this.dateLoant.Name = "dateLoant";
            this.dateLoant.Size = new System.Drawing.Size(123, 20);
            this.dateLoant.TabIndex = 90;
            // 
            // textAmountOfOnePayment
            // 
            this.textAmountOfOnePayment.Enabled = false;
            this.textAmountOfOnePayment.Location = new System.Drawing.Point(8, 94);
            this.textAmountOfOnePayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textAmountOfOnePayment.Name = "textAmountOfOnePayment";
            this.textAmountOfOnePayment.Size = new System.Drawing.Size(114, 20);
            this.textAmountOfOnePayment.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "סכום תשלום חודשי";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(9, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(83, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "מטבע";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 55);
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
            this.radioButton1.Location = new System.Drawing.Point(25, 19);
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
            this.labPayments.Location = new System.Drawing.Point(144, 64);
            this.labPayments.Name = "labPayments";
            this.labPayments.Size = new System.Drawing.Size(84, 13);
            this.labPayments.TabIndex = 83;
            this.labPayments.Text = "מספר תשלומים";
            // 
            // labLoanAmount
            // 
            this.labLoanAmount.AutoSize = true;
            this.labLoanAmount.Location = new System.Drawing.Point(144, 29);
            this.labLoanAmount.Name = "labLoanAmount";
            this.labLoanAmount.Size = new System.Drawing.Size(73, 13);
            this.labLoanAmount.TabIndex = 82;
            this.labLoanAmount.Text = " סכום הלואה";
            // 
            // textNumOfPayments
            // 
            this.textNumOfPayments.Location = new System.Drawing.Point(9, 57);
            this.textNumOfPayments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNumOfPayments.Name = "textNumOfPayments";
            this.textNumOfPayments.Size = new System.Drawing.Size(114, 20);
            this.textNumOfPayments.TabIndex = 81;
            this.textNumOfPayments.TextChanged += new System.EventHandler(this.textNumOfPayments_TextChanged);
            // 
            // textLoantAmount
            // 
            this.textLoantAmount.Location = new System.Drawing.Point(8, 22);
            this.textLoantAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textLoantAmount.Name = "textLoantAmount";
            this.textLoantAmount.Size = new System.Drawing.Size(114, 20);
            this.textLoantAmount.TabIndex = 80;
            this.textLoantAmount.TextChanged += new System.EventHandler(this.textLoantAmount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "תאריך ההלואה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "תאריך פרעון";
            // 
            // dateOfFirstPayment
            // 
            this.dateOfFirstPayment.Location = new System.Drawing.Point(128, 227);
            this.dateOfFirstPayment.Name = "dateOfFirstPayment";
            this.dateOfFirstPayment.Size = new System.Drawing.Size(123, 20);
            this.dateOfFirstPayment.TabIndex = 91;
        //    this.dateOfFirstPayment.Load += new System.EventHandler(this.dateOfFirstPayment_Load);
            // 
            // CreateALoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(843, 511);
            this.Controls.Add(this.tabControl1);
            this.Name = "CreateALoans";
            this.Load += new System.EventHandler(this.CreateALoans_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedHarivem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combLoanReasons;
        protected System.Windows.Forms.TextBox textIdNum;
        protected System.Windows.Forms.TextBox textLoantAmount;
        protected System.Windows.Forms.TextBox textName;
        protected System.Windows.Forms.TextBox textNumOfPayments;
        protected System.Windows.Forms.TextBox textAmountOfOnePayment;
        protected System.Windows.Forms.Label lebName;
        protected System.Windows.Forms.Label lebIdNum;
        protected System.Windows.Forms.Label labLoanAmount;
        protected System.Windows.Forms.Button SaveButton;
        protected System.Windows.Forms.Label labPayments;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textFatherName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSearchMembers;
        private System.Windows.Forms.DataGridView dataGridMembers;
        protected System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHrivim;
        public System.Windows.Forms.DataGridView dgvSelectedHarivem;
        private ControlerDate dateOfFirstPayment;
        private ControlerDate dateLoant;
        private System.Windows.Forms.Button btnMembresList;



        
    }
}