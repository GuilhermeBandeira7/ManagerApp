using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTelemetryManager.Forms
{
    public partial class Frm_Server : Form
    {
        public Frm_Server()
        {
            InitializeComponent();
            Txb_ServerAddress.Text = "172.16.2.170";
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connected.", "Connection complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Btn_Connect.Text = "Connected";
            //TelemetryManager.Instance.SetButtonsVisibilityToTrue();                                              
        }
    }
}
