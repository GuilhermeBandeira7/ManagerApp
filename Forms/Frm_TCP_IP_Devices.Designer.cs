namespace NewTelemetryManager.Forms
{
    partial class Frm_TCP_IP_Devices
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
            this.Pnl_DataGridContainer = new System.Windows.Forms.Panel();
            this.Pnl_DgvContainer = new System.Windows.Forms.Panel();
            this.Dgv_Devices = new System.Windows.Forms.DataGridView();
            this.Lbl_DevicesUDP = new System.Windows.Forms.Label();
            this.Pnl_DataGridContainer.SuspendLayout();
            this.Pnl_DgvContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Devices)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_DataGridContainer
            // 
            this.Pnl_DataGridContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_DataGridContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.Pnl_DataGridContainer.Controls.Add(this.Pnl_DgvContainer);
            this.Pnl_DataGridContainer.Controls.Add(this.Lbl_DevicesUDP);
            this.Pnl_DataGridContainer.Location = new System.Drawing.Point(0, 0);
            this.Pnl_DataGridContainer.Name = "Pnl_DataGridContainer";
            this.Pnl_DataGridContainer.Size = new System.Drawing.Size(800, 450);
            this.Pnl_DataGridContainer.TabIndex = 5;
            // 
            // Pnl_DgvContainer
            // 
            this.Pnl_DgvContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_DgvContainer.Controls.Add(this.Dgv_Devices);
            this.Pnl_DgvContainer.Location = new System.Drawing.Point(12, 56);
            this.Pnl_DgvContainer.Name = "Pnl_DgvContainer";
            this.Pnl_DgvContainer.Size = new System.Drawing.Size(776, 382);
            this.Pnl_DgvContainer.TabIndex = 2;
            // 
            // Dgv_Devices
            // 
            this.Dgv_Devices.AllowUserToAddRows = false;
            this.Dgv_Devices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dgv_Devices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Devices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Devices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_Devices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(106)))), ((int)(((byte)(118)))));
            this.Dgv_Devices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Devices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(106)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Devices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Devices.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Devices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(106)))), ((int)(((byte)(118)))));
            this.Dgv_Devices.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Devices.Name = "Dgv_Devices";
            this.Dgv_Devices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dgv_Devices.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Devices.RowTemplate.Height = 25;
            this.Dgv_Devices.Size = new System.Drawing.Size(776, 382);
            this.Dgv_Devices.TabIndex = 0;
            // 
            // Lbl_DevicesUDP
            // 
            this.Lbl_DevicesUDP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_DevicesUDP.AutoSize = true;
            this.Lbl_DevicesUDP.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_DevicesUDP.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_DevicesUDP.Location = new System.Drawing.Point(323, 25);
            this.Lbl_DevicesUDP.Name = "Lbl_DevicesUDP";
            this.Lbl_DevicesUDP.Size = new System.Drawing.Size(158, 28);
            this.Lbl_DevicesUDP.TabIndex = 1;
            this.Lbl_DevicesUDP.Text = "Devices TCP/IP";
            // 
            // Frm_TCP_IP_Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(106)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pnl_DataGridContainer);
            this.Name = "Frm_TCP_IP_Devices";
            this.Text = "TCP/IP Devices";
            this.Pnl_DataGridContainer.ResumeLayout(false);
            this.Pnl_DataGridContainer.PerformLayout();
            this.Pnl_DgvContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Devices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Pnl_DataGridContainer;
        private Label Lbl_DevicesUDP;
        private DataGridView Dgv_Devices;
        private Panel Pnl_DgvContainer;
    }
}