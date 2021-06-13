namespace Gmach
{
    partial class ControlerDate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlerDate));
            this.btnOpenDate = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenDate
            // 
            resources.ApplyResources(this.btnOpenDate, "btnOpenDate");
            this.btnOpenDate.Name = "btnOpenDate";
            this.btnOpenDate.UseVisualStyleBackColor = true;
            this.btnOpenDate.Click += new System.EventHandler(this.btnOpenDate_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtData, "txtData");
            this.txtData.Name = "txtData";
            this.txtData.Validated += new System.EventHandler(this.txtData_Validated);
         //   this.txtData.Validating += new System.ComponentModel.CancelEventHandler(this.txtData_Validating);
            // 
            // ControlerDate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnOpenDate);
            this.Name = "ControlerDate";
            this.Load += new System.EventHandler(this.ControlerDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenDate;
        public System.Windows.Forms.TextBox txtData;
    }
}
