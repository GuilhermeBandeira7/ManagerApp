namespace NewTelemetryManager
{
    partial class Frm_MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainMenu));
            this.Pnl_Menu = new System.Windows.Forms.Panel();
            this.Btn_DevicesTCPIP = new System.Windows.Forms.Button();
            this.Btn_VariablesDevices = new System.Windows.Forms.Button();
            this.Btn_Server = new System.Windows.Forms.Button();
            this.Pnl_Logo = new System.Windows.Forms.Panel();
            this.Lbl_Logo = new System.Windows.Forms.Label();
            this.Pnl_Title = new System.Windows.Forms.Panel();
            this.Lbl_Home = new System.Windows.Forms.Label();
            this.Pnl_Background = new System.Windows.Forms.Panel();
            this.Pnl_Menu.SuspendLayout();
            this.Pnl_Logo.SuspendLayout();
            this.Pnl_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Menu
            // 
            this.Pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.Pnl_Menu.Controls.Add(this.Btn_DevicesTCPIP);
            this.Pnl_Menu.Controls.Add(this.Btn_VariablesDevices);
            this.Pnl_Menu.Controls.Add(this.Btn_Server);
            this.Pnl_Menu.Controls.Add(this.Pnl_Logo);
            this.Pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Menu.Name = "Pnl_Menu";
            this.Pnl_Menu.Size = new System.Drawing.Size(162, 633);
            this.Pnl_Menu.TabIndex = 0;
            // 
            // Btn_DevicesTCPIP
            // 
            this.Btn_DevicesTCPIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_DevicesTCPIP.FlatAppearance.BorderSize = 0;
            this.Btn_DevicesTCPIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DevicesTCPIP.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_DevicesTCPIP.ForeColor = System.Drawing.Color.White;
            this.Btn_DevicesTCPIP.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DevicesTCPIP.Image")));
            this.Btn_DevicesTCPIP.Location = new System.Drawing.Point(0, 302);
            this.Btn_DevicesTCPIP.Name = "Btn_DevicesTCPIP";
            this.Btn_DevicesTCPIP.Size = new System.Drawing.Size(162, 93);
            this.Btn_DevicesTCPIP.TabIndex = 4;
            this.Btn_DevicesTCPIP.Text = " Devices TCP/IP";
            this.Btn_DevicesTCPIP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_DevicesTCPIP.UseVisualStyleBackColor = true;
            this.Btn_DevicesTCPIP.Click += new System.EventHandler(this.Btn_DevicesTCPIP_Click);
            // 
            // Btn_VariablesDevices
            // 
            this.Btn_VariablesDevices.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_VariablesDevices.FlatAppearance.BorderSize = 0;
            this.Btn_VariablesDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_VariablesDevices.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_VariablesDevices.ForeColor = System.Drawing.Color.White;
            this.Btn_VariablesDevices.Image = ((System.Drawing.Image)(resources.GetObject("Btn_VariablesDevices.Image")));
            this.Btn_VariablesDevices.Location = new System.Drawing.Point(0, 185);
            this.Btn_VariablesDevices.Name = "Btn_VariablesDevices";
            this.Btn_VariablesDevices.Size = new System.Drawing.Size(162, 117);
            this.Btn_VariablesDevices.TabIndex = 2;
            this.Btn_VariablesDevices.Text = " Devices";
            this.Btn_VariablesDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_VariablesDevices.UseVisualStyleBackColor = true;
            this.Btn_VariablesDevices.Click += new System.EventHandler(this.Btn_VariablesDevices_Click);
            // 
            // Btn_Server
            // 
            this.Btn_Server.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Server.FlatAppearance.BorderSize = 0;
            this.Btn_Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Server.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Server.ForeColor = System.Drawing.Color.White;
            this.Btn_Server.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Server.Image")));
            this.Btn_Server.Location = new System.Drawing.Point(0, 75);
            this.Btn_Server.Name = "Btn_Server";
            this.Btn_Server.Size = new System.Drawing.Size(162, 110);
            this.Btn_Server.TabIndex = 1;
            this.Btn_Server.Text = "Server";
            this.Btn_Server.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Server.UseVisualStyleBackColor = true;
            this.Btn_Server.Click += new System.EventHandler(this.Btn_Dashboard_Click);
            // 
            // Pnl_Logo
            // 
            this.Pnl_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.Pnl_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pnl_Logo.Controls.Add(this.Lbl_Logo);
            this.Pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Logo.Name = "Pnl_Logo";
            this.Pnl_Logo.Size = new System.Drawing.Size(162, 75);
            this.Pnl_Logo.TabIndex = 0;
            // 
            // Lbl_Logo
            // 
            this.Lbl_Logo.AutoSize = true;
            this.Lbl_Logo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Logo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Logo.Location = new System.Drawing.Point(53, 26);
            this.Lbl_Logo.Name = "Lbl_Logo";
            this.Lbl_Logo.Size = new System.Drawing.Size(65, 25);
            this.Lbl_Logo.TabIndex = 0;
            this.Lbl_Logo.Text = "MTW ";
            this.Lbl_Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Title
            // 
            this.Pnl_Title.Controls.Add(this.Lbl_Home);
            this.Pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Title.Location = new System.Drawing.Point(162, 0);
            this.Pnl_Title.Name = "Pnl_Title";
            this.Pnl_Title.Size = new System.Drawing.Size(1077, 75);
            this.Pnl_Title.TabIndex = 1;
            // 
            // Lbl_Home
            // 
            this.Lbl_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_Home.AutoSize = true;
            this.Lbl_Home.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Home.ForeColor = System.Drawing.Color.White;
            this.Lbl_Home.Location = new System.Drawing.Point(486, 26);
            this.Lbl_Home.Name = "Lbl_Home";
            this.Lbl_Home.Size = new System.Drawing.Size(69, 25);
            this.Lbl_Home.TabIndex = 0;
            this.Lbl_Home.Text = "HOME";
            // 
            // Pnl_Background
            // 
            this.Pnl_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Background.Location = new System.Drawing.Point(162, 75);
            this.Pnl_Background.Name = "Pnl_Background";
            this.Pnl_Background.Size = new System.Drawing.Size(1077, 558);
            this.Pnl_Background.TabIndex = 2;
            // 
            // Frm_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 633);
            this.Controls.Add(this.Pnl_Background);
            this.Controls.Add(this.Pnl_Title);
            this.Controls.Add(this.Pnl_Menu);
            this.Name = "Frm_MainMenu";
            this.Text = "Main";
            this.Pnl_Menu.ResumeLayout(false);
            this.Pnl_Logo.ResumeLayout(false);
            this.Pnl_Logo.PerformLayout();
            this.Pnl_Title.ResumeLayout(false);
            this.Pnl_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Pnl_Menu;
        private Panel Pnl_Logo;
        private Button Btn_VariablesDevices;
        private Button Btn_Server;
        private Panel Pnl_Title;
        private Label Lbl_Home;
        private Label Lbl_Logo;
        private Panel Pnl_Background;
        private Button Btn_DevicesTCPIP;
    }
}