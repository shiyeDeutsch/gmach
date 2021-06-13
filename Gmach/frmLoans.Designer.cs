namespace Gmach
{
    partial class frmLoans
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
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.checkBoxActiveLoans = new System.Windows.Forms.CheckBox();
            this.textSirech = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoans
            // 
            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(0, 66);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.Size = new System.Drawing.Size(534, 392);
            this.dgvLoans.TabIndex = 0;
            this.dgvLoans.DoubleClick += new System.EventHandler(this.dgvLoans_DoubleClick);
            // 
            // checkBoxActiveLoans
            // 
            this.checkBoxActiveLoans.AutoSize = true;
            this.checkBoxActiveLoans.Location = new System.Drawing.Point(428, 43);
            this.checkBoxActiveLoans.Name = "checkBoxActiveLoans";
            this.checkBoxActiveLoans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxActiveLoans.Size = new System.Drawing.Size(106, 17);
            this.checkBoxActiveLoans.TabIndex = 1;
            this.checkBoxActiveLoans.Text = "הלואות פעילים";
            this.checkBoxActiveLoans.UseVisualStyleBackColor = true;
            this.checkBoxActiveLoans.CheckedChanged += new System.EventHandler(this.checkBoxActiveLoans_CheckedChanged);
            // 
            // textSirech
            // 
            this.textSirech.Location = new System.Drawing.Point(176, 24);
            this.textSirech.Name = "textSirech";
            this.textSirech.Size = new System.Drawing.Size(147, 20);
            this.textSirech.TabIndex = 2;
            this.textSirech.TextChanged += new System.EventHandler(this.textSirech_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "חיפש";
            // 
            // frmLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSirech);
            this.Controls.Add(this.checkBoxActiveLoans);
            this.Controls.Add(this.dgvLoans);
            this.Name = "frmLoans";
            this.Text = "frmLoans";
            this.Load += new System.EventHandler(this.frmLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.CheckBox checkBoxActiveLoans;
        private System.Windows.Forms.TextBox textSirech;
        private System.Windows.Forms.Label label1;
    }
}