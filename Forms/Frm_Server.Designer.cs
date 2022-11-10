namespace NewTelemetryManager.Forms
{
    partial class Frm_Server
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
            this.Tlp_BackgroundDashboard = new System.Windows.Forms.Panel();
            this.Pnl_ServerBackground = new System.Windows.Forms.Panel();
            this.Lbl_Server = new System.Windows.Forms.Label();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Txb_ServerAddress = new System.Windows.Forms.TextBox();
            this.Tlp_BackgroundDashboard.SuspendLayout();
            this.Pnl_ServerBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp_BackgroundDashboard
            // 
            this.Tlp_BackgroundDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(106)))), ((int)(((byte)(118)))));
            this.Tlp_BackgroundDashboard.Controls.Add(this.Pnl_ServerBackground);
            this.Tlp_BackgroundDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_BackgroundDashboard.Location = new System.Drawing.Point(0, 0);
            this.Tlp_BackgroundDashboard.Name = "Tlp_BackgroundDashboard";
            this.Tlp_BackgroundDashboard.Size = new System.Drawing.Size(785, 404);
            this.Tlp_BackgroundDashboard.TabIndex = 0;
            // 
            // Pnl_ServerBackground
            // 
            this.Pnl_ServerBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.Pnl_ServerBackground.Controls.Add(this.Lbl_Server);
            this.Pnl_ServerBackground.Controls.Add(this.Btn_Connect);
            this.Pnl_ServerBackground.Controls.Add(this.Txb_ServerAddress);
            this.Pnl_ServerBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_ServerBackground.Location = new System.Drawing.Point(0, 0);
            this.Pnl_ServerBackground.Name = "Pnl_ServerBackground";
            this.Pnl_ServerBackground.Size = new System.Drawing.Size(785, 404);
            this.Pnl_ServerBackground.TabIndex = 2;
            // 
            // Lbl_Server
            // 
            this.Lbl_Server.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Server.AutoSize = true;
            this.Lbl_Server.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Server.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_Server.Location = new System.Drawing.Point(360, 53);
            this.Lbl_Server.Name = "Lbl_Server";
            this.Lbl_Server.Size = new System.Drawing.Size(73, 28);
            this.Lbl_Server.TabIndex = 0;
            this.Lbl_Server.Text = "Server";
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Connect.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Connect.Location = new System.Drawing.Point(343, 148);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(117, 39);
            this.Btn_Connect.TabIndex = 1;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Txb_ServerAddress
            // 
            this.Txb_ServerAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txb_ServerAddress.Location = new System.Drawing.Point(257, 103);
            this.Txb_ServerAddress.Name = "Txb_ServerAddress";
            this.Txb_ServerAddress.Size = new System.Drawing.Size(284, 23);
            this.Txb_ServerAddress.TabIndex = 0;
            // 
            // Frm_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 404);
            this.Controls.Add(this.Tlp_BackgroundDashboard);
            this.Name = "Frm_Server";
            this.Text = "Server";
            this.Tlp_BackgroundDashboard.ResumeLayout(false);
            this.Pnl_ServerBackground.ResumeLayout(false);
            this.Pnl_ServerBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Tlp_BackgroundDashboard;
        private Label Lbl_Server;
        private Button Btn_Connect;
        private TextBox Txb_ServerAddress;
        private Panel Pnl_ServerBackground;
    }
}