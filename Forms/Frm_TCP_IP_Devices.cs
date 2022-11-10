using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NewTelemetryManager.TelemetryManager;

namespace NewTelemetryManager.Forms
{
    public partial class Frm_TCP_IP_Devices : Form
    {
        
        public Frm_TCP_IP_Devices()
        {
            InitializeComponent();

            Dgv_Devices.ColumnCount = 3;
            Dgv_Devices.Columns[0].Name = "SERIAL NUMBER";
            Dgv_Devices.Columns[1].Name = "IP PLACA";
            Dgv_Devices.Columns[2].Name = "IP";
            Dgv_Devices.RowHeadersVisible = false;
            Dgv_Devices.GridColor = Color.FromArgb(90, 106, 118);

        }
    }
}
