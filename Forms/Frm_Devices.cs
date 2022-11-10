using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NewTelemetryManager.TelemetryManager;

namespace NewTelemetryManager.Forms
{
    public partial class Frm_Devices : Form
    {
        public bool processExecuted = false;

        public Frm_Devices()
        {
            InitializeComponent();
            Trv_Variables.CheckBoxes = true;
            //PopulateTreeView("");
        }

        private void Ccb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Ccb_Type.Text)
            {
                case "Byte":
                    Msk_Type.Text = "00";
                    break;
                case "Short":
                    Msk_Type.Text = "00";
                    break;
                case "IP":
                    Msk_Type.Text = "000-00-0-000";
                    break;
                case "Serial Number":
                    Msk_Type.Text = "aaaaaaa";
                    break;
                default:
                    Msk_Type.Text = "";
                    break;
            }

            Msk_Type.Focus();
        }

        private void Ccb_SerialNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void Ccb_SerialNumber_Click(object sender, EventArgs e)
        {
          
        }

        private void Ccb_Slot_Click(object sender, EventArgs e)
        {
            
        }

        private void Ccb_SerialNumberUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void Txb_FilterVariable_TextChanged(object sender, EventArgs e)
        {           
        }
    }
}
