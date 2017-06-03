namespace WFAMayinTarlasi
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
            this.fltTarla = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMayinSayisi = new System.Windows.Forms.Label();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.lblYeniOyun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fltTarla
            // 
            this.fltTarla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fltTarla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fltTarla.Location = new System.Drawing.Point(12, 56);
            this.fltTarla.Name = "fltTarla";
            this.fltTarla.Size = new System.Drawing.Size(261, 210);
            this.fltTarla.TabIndex = 0;
            // 
            // lblMayinSayisi
            // 
            this.lblMayinSayisi.AutoSize = true;
            this.lblMayinSayisi.Location = new System.Drawing.Point(9, 15);
            this.lblMayinSayisi.Name = "lblMayinSayisi";
            this.lblMayinSayisi.Size = new System.Drawing.Size(22, 13);
            this.lblMayinSayisi.TabIndex = 0;
            this.lblMayinSayisi.Text = "M :";
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnYeniOyun.Location = new System.Drawing.Point(115, 6);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(36, 31);
            this.btnYeniOyun.TabIndex = 1;
            this.btnYeniOyun.Text = " ";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            this.btnYeniOyun.MouseEnter += new System.EventHandler(this.btnYeniOyun_MouseEnter);
            this.btnYeniOyun.MouseLeave += new System.EventHandler(this.btnYeniOyun_MouseLeave);
            // 
            // lblYeniOyun
            // 
            this.lblYeniOyun.AutoSize = true;
            this.lblYeniOyun.Location = new System.Drawing.Point(157, 15);
            this.lblYeniOyun.Name = "lblYeniOyun";
            this.lblYeniOyun.Size = new System.Drawing.Size(53, 13);
            this.lblYeniOyun.TabIndex = 2;
            this.lblYeniOyun.Text = "YeniOyun";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(285, 278);
            this.Controls.Add(this.lblYeniOyun);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.lblMayinSayisi);
            this.Controls.Add(this.fltTarla);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fltTarla;
        private System.Windows.Forms.Label lblMayinSayisi;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Label lblYeniOyun;
    }
}

