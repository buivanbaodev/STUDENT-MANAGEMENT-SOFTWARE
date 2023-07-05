namespace BT_chieu_t6
{
    partial class ContactUs
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
            this.label1 = new System.Windows.Forms.Label();
            this.btCallBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN is <NGUYEN NHU VU>";
            // 
            // btCallBack
            // 
            this.btCallBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCallBack.Location = new System.Drawing.Point(291, 170);
            this.btCallBack.Name = "btCallBack";
            this.btCallBack.Size = new System.Drawing.Size(149, 36);
            this.btCallBack.TabIndex = 1;
            this.btCallBack.Text = "Call Back";
            this.btCallBack.UseVisualStyleBackColor = true;
            this.btCallBack.Click += new System.EventHandler(this.btCallBack_Click);
            // 
            // ContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 273);
            this.Controls.Add(this.btCallBack);
            this.Controls.Add(this.label1);
            this.Name = "ContactUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactUs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCallBack;
    }
}