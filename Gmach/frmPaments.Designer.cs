namespace Gmach
{
    partial class frmPaments
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAmountPaing = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBalanceToPay = new System.Windows.Forms.TextBox();
            this.textGeneralAmountToPay = new System.Windows.Forms.TextBox();
            this.textNumOfPament = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.loans_DS1 = new Gmach.Loans_DS();
            this.controlerDate1 = new Gmach.ControlerDate();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loans_DS1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.controlerDate1);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textAmountPaing);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBalanceToPay);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 172);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Gmach.Properties.Resources.draw_edit_pen_pencil_text_write_icon_1320162307919760358_16;
            this.btnEdit.Location = new System.Drawing.Point(25, 143);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 20);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(280, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "מס\' תשלום";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(96, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "סכום תשלום כללי";
            // 
            // textAmountPaing
            // 
            this.textAmountPaing.BackColor = System.Drawing.SystemColors.Window;
            this.textAmountPaing.Location = new System.Drawing.Point(145, 144);
            this.textAmountPaing.Name = "textAmountPaing";
            this.textAmountPaing.Size = new System.Drawing.Size(72, 20);
            this.textAmountPaing.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(235, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "סכום תשלום הנוכחי";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(299, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "לתשלום";
            // 
            // textBalanceToPay
            // 
            this.textBalanceToPay.Location = new System.Drawing.Point(145, 76);
            this.textBalanceToPay.Name = "textBalanceToPay";
            this.textBalanceToPay.ReadOnly = true;
            this.textBalanceToPay.Size = new System.Drawing.Size(72, 20);
            this.textBalanceToPay.TabIndex = 17;
            // 
            // textGeneralAmountToPay
            // 
            this.textGeneralAmountToPay.BackColor = System.Drawing.SystemColors.Window;
            this.textGeneralAmountToPay.Location = new System.Drawing.Point(23, 50);
            this.textGeneralAmountToPay.Name = "textGeneralAmountToPay";
            this.textGeneralAmountToPay.ReadOnly = true;
            this.textGeneralAmountToPay.Size = new System.Drawing.Size(72, 20);
            this.textGeneralAmountToPay.TabIndex = 7;
            // 
            // textNumOfPament
            // 
            this.textNumOfPament.BackColor = System.Drawing.SystemColors.Window;
            this.textNumOfPament.Location = new System.Drawing.Point(247, 48);
            this.textNumOfPament.Name = "textNumOfPament";
            this.textNumOfPament.Size = new System.Drawing.Size(33, 20);
            this.textNumOfPament.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(177, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "בטל";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK.Location = new System.Drawing.Point(86, 259);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "אשר";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // loans_DS1
            // 
            this.loans_DS1.DataSetName = "Loans_DS";
            this.loans_DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controlerDate1
            // 
            this.controlerDate1.Location = new System.Drawing.Point(25, 36);
            this.controlerDate1.Name = "controlerDate1";
            this.controlerDate1.Size = new System.Drawing.Size(124, 20);
            this.controlerDate1.TabIndex = 0;
            // 
            // frmPaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 294);
            this.Controls.Add(this.textGeneralAmountToPay);
            this.Controls.Add(this.textNumOfPament);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPaments";
            this.Text = "frmPaments";
            this.Load += new System.EventHandler(this.frmPaments_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loans_DS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAmountPaing;
        private System.Windows.Forms.TextBox textGeneralAmountToPay;
        private System.Windows.Forms.TextBox textNumOfPament;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBalanceToPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private Loans_DS loans_DS1;
        private Gmach.ControlerDate controlerDate1;
     //   private.System.Windows.Forms .ControlerDate ControlerDate1;

    }
}