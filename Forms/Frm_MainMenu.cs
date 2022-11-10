using NewTelemetryManager.Forms;

namespace NewTelemetryManager
{
    public partial class Frm_MainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Frm_MainMenu()
        {
            InitializeComponent();
            TelemetryManager.Instance.MainMenuForm = this;
            random = new Random();
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Pnl_Background.Controls.Add(childForm);
            this.Pnl_Background.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Lbl_Home.Text = childForm.Text;
        }

        private void OpenChildForWithoutClose(Form childForm, object btnSender)
        {
            ActivateButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Pnl_Background.Controls.Add(childForm);
            this.Pnl_Background.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Lbl_Home.Text = childForm.Text;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count); //Getting a random color
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    Pnl_Title.BackColor = color;
                    Pnl_Logo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in Pnl_Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(8, 32, 50);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            if (TelemetryManager.Instance.ServerForm == null)
            {
                TelemetryManager.Instance.DevicesForm = new Frm_Devices();
                OpenChildForm(TelemetryManager.Instance.ServerForm = new Forms.Frm_Server(), sender);
            }
            else
            {
                OpenChildForWithoutClose(TelemetryManager.Instance.ServerForm, sender);
            }
        }

        private void Btn_VariablesDevices_Click(object sender, EventArgs e)
        {
            OpenChildForWithoutClose(TelemetryManager.Instance.DevicesForm, sender);    
        }

        private void Btn_Configuration_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Frm_Configuration(), sender);
        }

        private void Btn_DevicesTCPIP_Click(object sender, EventArgs e)
        {
            if(TelemetryManager.Instance.TcpIpDevices == null)
            {
                OpenChildForm(TelemetryManager.Instance.TcpIpDevices = new Frm_TCP_IP_Devices(), sender);
            }
            else
            {
                OpenChildForWithoutClose(TelemetryManager.Instance.TcpIpDevices, sender);
            }
            
        }
    }
}