namespace DangNhap
{
    partial class MainFrom
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnMain.Location = new System.Drawing.Point(0, 85);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(600, 255);
            this.pnMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btnDetail);
            this.panel1.Controls.Add(this.btnSummary);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 79);
            this.panel1.TabIndex = 1;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(457, 28);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(143, 48);
            this.btnDetail.TabIndex = 2;
            this.btnDetail.Text = "login";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(280, 28);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(156, 48);
            this.btnSummary.TabIndex = 1;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnMain);
            this.Name = "MainFrom";
            this.Text = "MainFrom";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.Resize += new System.EventHandler(this.MainFrom_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnSummary;
    }
}