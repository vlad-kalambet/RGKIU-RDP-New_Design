﻿namespace RGKIU_VCH
{
    partial class VPN
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
            this.inf_lbl = new System.Windows.Forms.Label();
            this.CHK_on_VPN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inf_lbl
            // 
            this.inf_lbl.AutoSize = true;
            this.inf_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inf_lbl.Location = new System.Drawing.Point(13, 165);
            this.inf_lbl.Name = "inf_lbl";
            this.inf_lbl.Size = new System.Drawing.Size(225, 17);
            this.inf_lbl.TabIndex = 0;
            this.inf_lbl.Text = "Подключение к серверам RKIU...";
            this.inf_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHK_on_VPN
            // 
            this.CHK_on_VPN.AutoSize = true;
            this.CHK_on_VPN.Location = new System.Drawing.Point(90, 9);
            this.CHK_on_VPN.Name = "CHK_on_VPN";
            this.CHK_on_VPN.Size = new System.Drawing.Size(75, 13);
            this.CHK_on_VPN.TabIndex = 1;
            this.CHK_on_VPN.Text = "CHK_on_VPN";
            this.CHK_on_VPN.Visible = false;
            // 
            // VPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 200);
            this.Controls.Add(this.CHK_on_VPN);
            this.Controls.Add(this.inf_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPN";
            this.Load += new System.EventHandler(this.VPN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inf_lbl;
        private System.Windows.Forms.Label CHK_on_VPN;
    }
}