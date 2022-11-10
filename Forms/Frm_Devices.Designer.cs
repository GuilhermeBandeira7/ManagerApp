namespace NewTelemetryManager.Forms
{
    partial class Frm_Devices
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("SerialNumber", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.Pnl_ServerBackground = new System.Windows.Forms.Panel();
            this.Lbl_SearchForVariable = new System.Windows.Forms.Label();
            this.Txb_FilterVariable = new System.Windows.Forms.TextBox();
            this.Btn_ClearVariables = new System.Windows.Forms.Button();
            this.Trv_Variables = new System.Windows.Forms.TreeView();
            this.Lbl_VariablesTitle = new System.Windows.Forms.Label();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pnl_ContainerVariables = new System.Windows.Forms.Panel();
            this.Btn_ExpandAllDevices = new System.Windows.Forms.Button();
            this.Btn_ClearAllDevices = new System.Windows.Forms.Button();
            this.Trv_Devices = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnl_ContainerUpdate = new System.Windows.Forms.Panel();
            this.Msk_Type = new System.Windows.Forms.MaskedTextBox();
            this.Ccb_Type = new System.Windows.Forms.ComboBox();
            this.Lbl_MsgValueType = new System.Windows.Forms.Label();
            this.Ccb_VariableUpdate = new System.Windows.Forms.ComboBox();
            this.Lbl_Variable = new System.Windows.Forms.Label();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Ccb_SlotUpdate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ccb_SerialNumberUpdate = new System.Windows.Forms.ComboBox();
            this.Lbl_ = new System.Windows.Forms.Label();
            this.Lbl_Update = new System.Windows.Forms.Label();
            this.Pnl_ContainerQuery = new System.Windows.Forms.Panel();
            this.Lbl_Start = new System.Windows.Forms.Button();
            this.Ccb_Slot = new System.Windows.Forms.ComboBox();
            this.Lbl_Slot = new System.Windows.Forms.Label();
            this.Ccb_SerialNumber = new System.Windows.Forms.ComboBox();
            this.Lbl_SerialNumber = new System.Windows.Forms.Label();
            this.Lbl_TitleQuery = new System.Windows.Forms.Label();
            this.Lbl_MessageType = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Pnl_ServerBackground.SuspendLayout();
            this.Pnl_ContainerVariables.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_ContainerUpdate.SuspendLayout();
            this.Pnl_ContainerQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_ServerBackground
            // 
            this.Pnl_ServerBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_ServerBackground.AutoScroll = true;
            this.Pnl_ServerBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.Pnl_ServerBackground.Controls.Add(this.Lbl_SearchForVariable);
            this.Pnl_ServerBackground.Controls.Add(this.Txb_FilterVariable);
            this.Pnl_ServerBackground.Controls.Add(this.Btn_ClearVariables);
            this.Pnl_ServerBackground.Controls.Add(this.Trv_Variables);
            this.Pnl_ServerBackground.Controls.Add(this.Lbl_VariablesTitle);
            this.Pnl_ServerBackground.Location = new System.Drawing.Point(497, 21);
            this.Pnl_ServerBackground.Name = "Pnl_ServerBackground";
            this.Pnl_ServerBackground.Size = new System.Drawing.Size(276, 483);
            this.Pnl_ServerBackground.TabIndex = 3;
            // 
            // Lbl_SearchForVariable
            // 
            this.Lbl_SearchForVariable.AutoSize = true;
            this.Lbl_SearchForVariable.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_SearchForVariable.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_SearchForVariable.Location = new System.Drawing.Point(3, 58);
            this.Lbl_SearchForVariable.Name = "Lbl_SearchForVariable";
            this.Lbl_SearchForVariable.Size = new System.Drawing.Size(129, 21);
            this.Lbl_SearchForVariable.TabIndex = 11;
            this.Lbl_SearchForVariable.Text = "Search Variable";
            // 
            // Txb_FilterVariable
            // 
            this.Txb_FilterVariable.Location = new System.Drawing.Point(138, 58);
            this.Txb_FilterVariable.Name = "Txb_FilterVariable";
            this.Txb_FilterVariable.Size = new System.Drawing.Size(129, 23);
            this.Txb_FilterVariable.TabIndex = 10;
            this.Txb_FilterVariable.TextChanged += new System.EventHandler(this.Txb_FilterVariable_TextChanged);
            // 
            // Btn_ClearVariables
            // 
            this.Btn_ClearVariables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ClearVariables.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ClearVariables.Location = new System.Drawing.Point(0, 451);
            this.Btn_ClearVariables.Name = "Btn_ClearVariables";
            this.Btn_ClearVariables.Size = new System.Drawing.Size(273, 29);
            this.Btn_ClearVariables.TabIndex = 9;
            this.Btn_ClearVariables.Text = "Clear";
            this.Btn_ClearVariables.UseVisualStyleBackColor = true;
            // 
            // Trv_Variables
            // 
            this.Trv_Variables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trv_Variables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.Trv_Variables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Trv_Variables.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Trv_Variables.ForeColor = System.Drawing.Color.Transparent;
            this.Trv_Variables.Location = new System.Drawing.Point(18, 84);
            this.Trv_Variables.Name = "Trv_Variables";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Node1";
            treeNode3.Name = "Tvn_Node1";
            treeNode3.Text = "SerialNumber";
            this.Trv_Variables.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.Trv_Variables.Size = new System.Drawing.Size(243, 364);
            this.Trv_Variables.TabIndex = 2;
            // 
            // Lbl_VariablesTitle
            // 
            this.Lbl_VariablesTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_VariablesTitle.AutoSize = true;
            this.Lbl_VariablesTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_VariablesTitle.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_VariablesTitle.Location = new System.Drawing.Point(80, 18);
            this.Lbl_VariablesTitle.Name = "Lbl_VariablesTitle";
            this.Lbl_VariablesTitle.Size = new System.Drawing.Size(101, 28);
            this.Lbl_VariablesTitle.TabIndex = 1;
            this.Lbl_VariablesTitle.Text = "Variables";
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Title.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_Title.Location = new System.Drawing.Point(54, 18);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(181, 28);
            this.Lbl_Title.TabIndex = 1;
            this.Lbl_Title.Text = "Available Devices";
            // 
            // Pnl_ContainerVariables
            // 
            this.Pnl_ContainerVariables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_ContainerVariables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.Pnl_ContainerVariables.Controls.Add(this.Btn_ExpandAllDevices);
            this.Pnl_ContainerVariables.Controls.Add(this.Btn_ClearAllDevices);
            this.Pnl_ContainerVariables.Controls.Add(this.Lbl_Title);
            this.Pnl_ContainerVariables.Controls.Add(this.Trv_Devices);
            this.Pnl_ContainerVariables.Location = new System.Drawing.Point(789, 21);
            this.Pnl_ContainerVariables.Name = "Pnl_ContainerVariables";
            this.Pnl_ContainerVariables.Size = new System.Drawing.Size(277, 483);
            this.Pnl_ContainerVariables.TabIndex = 4;
            // 
            // Btn_ExpandAllDevices
            // 
            this.Btn_ExpandAllDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ExpandAllDevices.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ExpandAllDevices.Location = new System.Drawing.Point(0, 451);
            this.Btn_ExpandAllDevices.Name = "Btn_ExpandAllDevices";
            this.Btn_ExpandAllDevices.Size = new System.Drawing.Size(273, 29);
            this.Btn_ExpandAllDevices.TabIndex = 11;
            this.Btn_ExpandAllDevices.Text = "Expand All";
            this.Btn_ExpandAllDevices.UseVisualStyleBackColor = true;
            // 
            // Btn_ClearAllDevices
            // 
            this.Btn_ClearAllDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ClearAllDevices.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ClearAllDevices.Location = new System.Drawing.Point(0, 419);
            this.Btn_ClearAllDevices.Name = "Btn_ClearAllDevices";
            this.Btn_ClearAllDevices.Size = new System.Drawing.Size(273, 29);
            this.Btn_ClearAllDevices.TabIndex = 10;
            this.Btn_ClearAllDevices.Text = "Clear All";
            this.Btn_ClearAllDevices.UseVisualStyleBackColor = true;
            // 
            // Trv_Devices
            // 
            this.Trv_Devices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trv_Devices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.Trv_Devices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Trv_Devices.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Trv_Devices.ForeColor = System.Drawing.Color.Transparent;
            this.Trv_Devices.Location = new System.Drawing.Point(13, 53);
            this.Trv_Devices.Name = "Trv_Devices";
            this.Trv_Devices.Size = new System.Drawing.Size(248, 360);
            this.Trv_Devices.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.Pnl_ContainerUpdate);
            this.panel1.Controls.Add(this.Lbl_Update);
            this.panel1.Controls.Add(this.Pnl_ContainerQuery);
            this.panel1.Controls.Add(this.Lbl_TitleQuery);
            this.panel1.Controls.Add(this.Lbl_MessageType);
            this.panel1.Location = new System.Drawing.Point(24, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 483);
            this.panel1.TabIndex = 5;
            // 
            // Pnl_ContainerUpdate
            // 
            this.Pnl_ContainerUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pnl_ContainerUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(106)))), ((int)(((byte)(118)))));
            this.Pnl_ContainerUpdate.Controls.Add(this.Msk_Type);
            this.Pnl_ContainerUpdate.Controls.Add(this.Ccb_Type);
            this.Pnl_ContainerUpdate.Controls.Add(this.Lbl_MsgValueType);
            this.Pnl_ContainerUpdate.Controls.Add(this.Ccb_VariableUpdate);
            this.Pnl_ContainerUpdate.Controls.Add(this.Lbl_Variable);
            this.Pnl_ContainerUpdate.Controls.Add(this.Btn_Update);
            this.Pnl_ContainerUpdate.Controls.Add(this.Ccb_SlotUpdate);
            this.Pnl_ContainerUpdate.Controls.Add(this.label1);
            this.Pnl_ContainerUpdate.Controls.Add(this.Ccb_SerialNumberUpdate);
            this.Pnl_ContainerUpdate.Controls.Add(this.Lbl_);
            this.Pnl_ContainerUpdate.Location = new System.Drawing.Point(14, 240);
            this.Pnl_ContainerUpdate.Name = "Pnl_ContainerUpdate";
            this.Pnl_ContainerUpdate.Size = new System.Drawing.Size(427, 228);
            this.Pnl_ContainerUpdate.TabIndex = 6;
            // 
            // Msk_Type
            // 
            this.Msk_Type.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Msk_Type.Location = new System.Drawing.Point(149, 183);
            this.Msk_Type.Name = "Msk_Type";
            this.Msk_Type.Size = new System.Drawing.Size(155, 25);
            this.Msk_Type.TabIndex = 13;
            // 
            // Ccb_Type
            // 
            this.Ccb_Type.FormattingEnabled = true;
            this.Ccb_Type.Items.AddRange(new object[] {
            "Byte",
            "Short",
            "IP",
            "Serial Number"});
            this.Ccb_Type.Location = new System.Drawing.Point(149, 139);
            this.Ccb_Type.Name = "Ccb_Type";
            this.Ccb_Type.Size = new System.Drawing.Size(155, 23);
            this.Ccb_Type.TabIndex = 12;
            this.Ccb_Type.SelectedIndexChanged += new System.EventHandler(this.Ccb_Type_SelectedIndexChanged);
            // 
            // Lbl_MsgValueType
            // 
            this.Lbl_MsgValueType.AutoSize = true;
            this.Lbl_MsgValueType.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_MsgValueType.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_MsgValueType.Location = new System.Drawing.Point(32, 139);
            this.Lbl_MsgValueType.Name = "Lbl_MsgValueType";
            this.Lbl_MsgValueType.Size = new System.Drawing.Size(55, 25);
            this.Lbl_MsgValueType.TabIndex = 11;
            this.Lbl_MsgValueType.Text = "Type";
            // 
            // Ccb_VariableUpdate
            // 
            this.Ccb_VariableUpdate.FormattingEnabled = true;
            this.Ccb_VariableUpdate.Location = new System.Drawing.Point(149, 95);
            this.Ccb_VariableUpdate.Name = "Ccb_VariableUpdate";
            this.Ccb_VariableUpdate.Size = new System.Drawing.Size(155, 23);
            this.Ccb_VariableUpdate.TabIndex = 10;
            // 
            // Lbl_Variable
            // 
            this.Lbl_Variable.AutoSize = true;
            this.Lbl_Variable.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Variable.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_Variable.Location = new System.Drawing.Point(26, 92);
            this.Lbl_Variable.Name = "Lbl_Variable";
            this.Lbl_Variable.Size = new System.Drawing.Size(85, 25);
            this.Lbl_Variable.TabIndex = 9;
            this.Lbl_Variable.Text = "Variable";
            // 
            // Btn_Update
            // 
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Update.Location = new System.Drawing.Point(324, 95);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(86, 29);
            this.Btn_Update.TabIndex = 8;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            // 
            // Ccb_SlotUpdate
            // 
            this.Ccb_SlotUpdate.FormattingEnabled = true;
            this.Ccb_SlotUpdate.Location = new System.Drawing.Point(149, 49);
            this.Ccb_SlotUpdate.Name = "Ccb_SlotUpdate";
            this.Ccb_SlotUpdate.Size = new System.Drawing.Size(155, 23);
            this.Ccb_SlotUpdate.TabIndex = 7;
            this.Ccb_SlotUpdate.Click += new System.EventHandler(this.Ccb_Slot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Slot";
            // 
            // Ccb_SerialNumberUpdate
            // 
            this.Ccb_SerialNumberUpdate.FormattingEnabled = true;
            this.Ccb_SerialNumberUpdate.Location = new System.Drawing.Point(149, 11);
            this.Ccb_SerialNumberUpdate.Name = "Ccb_SerialNumberUpdate";
            this.Ccb_SerialNumberUpdate.Size = new System.Drawing.Size(155, 23);
            this.Ccb_SerialNumberUpdate.TabIndex = 5;
            this.Ccb_SerialNumberUpdate.Click += new System.EventHandler(this.Ccb_SerialNumberUpdate_Click);
            // 
            // Lbl_
            // 
            this.Lbl_.AutoSize = true;
            this.Lbl_.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_.Location = new System.Drawing.Point(3, 11);
            this.Lbl_.Name = "Lbl_";
            this.Lbl_.Size = new System.Drawing.Size(140, 25);
            this.Lbl_.TabIndex = 4;
            this.Lbl_.Text = "Serial Number";
            // 
            // Lbl_Update
            // 
            this.Lbl_Update.AutoSize = true;
            this.Lbl_Update.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Update.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_Update.Location = new System.Drawing.Point(14, 197);
            this.Lbl_Update.Name = "Lbl_Update";
            this.Lbl_Update.Size = new System.Drawing.Size(83, 28);
            this.Lbl_Update.TabIndex = 5;
            this.Lbl_Update.Text = "Update";
            // 
            // Pnl_ContainerQuery
            // 
            this.Pnl_ContainerQuery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pnl_ContainerQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(106)))), ((int)(((byte)(118)))));
            this.Pnl_ContainerQuery.Controls.Add(this.Lbl_Start);
            this.Pnl_ContainerQuery.Controls.Add(this.Ccb_Slot);
            this.Pnl_ContainerQuery.Controls.Add(this.Lbl_Slot);
            this.Pnl_ContainerQuery.Controls.Add(this.Ccb_SerialNumber);
            this.Pnl_ContainerQuery.Controls.Add(this.Lbl_SerialNumber);
            this.Pnl_ContainerQuery.Location = new System.Drawing.Point(14, 84);
            this.Pnl_ContainerQuery.Name = "Pnl_ContainerQuery";
            this.Pnl_ContainerQuery.Size = new System.Drawing.Size(427, 90);
            this.Pnl_ContainerQuery.TabIndex = 4;
            // 
            // Lbl_Start
            // 
            this.Lbl_Start.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Start.Location = new System.Drawing.Point(324, 28);
            this.Lbl_Start.Name = "Lbl_Start";
            this.Lbl_Start.Size = new System.Drawing.Size(86, 29);
            this.Lbl_Start.TabIndex = 8;
            this.Lbl_Start.Text = "Start";
            this.Lbl_Start.UseVisualStyleBackColor = true;
            // 
            // Ccb_Slot
            // 
            this.Ccb_Slot.FormattingEnabled = true;
            this.Ccb_Slot.Location = new System.Drawing.Point(149, 49);
            this.Ccb_Slot.Name = "Ccb_Slot";
            this.Ccb_Slot.Size = new System.Drawing.Size(155, 23);
            this.Ccb_Slot.TabIndex = 7;
            this.Ccb_Slot.Click += new System.EventHandler(this.Ccb_Slot_Click);
            // 
            // Lbl_Slot
            // 
            this.Lbl_Slot.AutoSize = true;
            this.Lbl_Slot.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Slot.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_Slot.Location = new System.Drawing.Point(40, 49);
            this.Lbl_Slot.Name = "Lbl_Slot";
            this.Lbl_Slot.Size = new System.Drawing.Size(47, 25);
            this.Lbl_Slot.TabIndex = 6;
            this.Lbl_Slot.Text = "Slot";
            // 
            // Ccb_SerialNumber
            // 
            this.Ccb_SerialNumber.FormattingEnabled = true;
            this.Ccb_SerialNumber.Location = new System.Drawing.Point(149, 11);
            this.Ccb_SerialNumber.Name = "Ccb_SerialNumber";
            this.Ccb_SerialNumber.Size = new System.Drawing.Size(155, 23);
            this.Ccb_SerialNumber.TabIndex = 5;
            this.Ccb_SerialNumber.SelectedIndexChanged += new System.EventHandler(this.Ccb_SerialNumber_SelectedIndexChanged);
            this.Ccb_SerialNumber.Click += new System.EventHandler(this.Ccb_SerialNumber_Click);
            // 
            // Lbl_SerialNumber
            // 
            this.Lbl_SerialNumber.AutoSize = true;
            this.Lbl_SerialNumber.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_SerialNumber.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_SerialNumber.Location = new System.Drawing.Point(3, 11);
            this.Lbl_SerialNumber.Name = "Lbl_SerialNumber";
            this.Lbl_SerialNumber.Size = new System.Drawing.Size(140, 25);
            this.Lbl_SerialNumber.TabIndex = 4;
            this.Lbl_SerialNumber.Text = "Serial Number";
            // 
            // Lbl_TitleQuery
            // 
            this.Lbl_TitleQuery.AutoSize = true;
            this.Lbl_TitleQuery.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TitleQuery.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_TitleQuery.Location = new System.Drawing.Point(14, 53);
            this.Lbl_TitleQuery.Name = "Lbl_TitleQuery";
            this.Lbl_TitleQuery.Size = new System.Drawing.Size(71, 28);
            this.Lbl_TitleQuery.TabIndex = 3;
            this.Lbl_TitleQuery.Text = "Query";
            // 
            // Lbl_MessageType
            // 
            this.Lbl_MessageType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_MessageType.AutoSize = true;
            this.Lbl_MessageType.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_MessageType.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_MessageType.Location = new System.Drawing.Point(136, 18);
            this.Lbl_MessageType.Name = "Lbl_MessageType";
            this.Lbl_MessageType.Size = new System.Drawing.Size(149, 28);
            this.Lbl_MessageType.TabIndex = 2;
            this.Lbl_MessageType.Text = "Message Type";
            // 
            // Frm_Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(106)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1081, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_ContainerVariables);
            this.Controls.Add(this.Pnl_ServerBackground);
            this.Name = "Frm_Devices";
            this.Text = "Devices";
            this.Pnl_ServerBackground.ResumeLayout(false);
            this.Pnl_ServerBackground.PerformLayout();
            this.Pnl_ContainerVariables.ResumeLayout(false);
            this.Pnl_ContainerVariables.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pnl_ContainerUpdate.ResumeLayout(false);
            this.Pnl_ContainerUpdate.PerformLayout();
            this.Pnl_ContainerQuery.ResumeLayout(false);
            this.Pnl_ContainerQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Pnl_ServerBackground;
        private TreeView Trv_Variables;
        private Label Lbl_Title;
        private Panel Pnl_ContainerVariables;
        private TreeView Trv_Devices;
        private Label Lbl_VariablesTitle;
        private Panel panel1;
        private Label Lbl_TitleQuery;
        private Label Lbl_MessageType;
        private Panel Pnl_ContainerQuery;
        private Button Lbl_Start;
        private ComboBox Ccb_Slot;
        private Label Lbl_Slot;
        private ComboBox Ccb_SerialNumber;
        private Label Lbl_SerialNumber;
        private Panel Pnl_ContainerUpdate;
        private MaskedTextBox Msk_Type;
        private ComboBox Ccb_Type;
        private Label Lbl_MsgValueType;
        private ComboBox Ccb_VariableUpdate;
        private Label Lbl_Variable;
        private Button Btn_Update;
        private ComboBox Ccb_SlotUpdate;
        private Label label1;
        private ComboBox Ccb_SerialNumberUpdate;
        private Label Lbl_;
        private Label Lbl_Update;
        private Button Btn_ClearVariables;
        private Button Btn_ExpandAllDevices;
        private Button Btn_ClearAllDevices;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox Txb_FilterVariable;
        private Label Lbl_SearchForVariable;
    }
}