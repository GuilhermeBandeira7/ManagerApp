using Microsoft.VisualBasic.ApplicationServices;
using NewTelemetryManager.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;


namespace NewTelemetryManager
{
    //Responsável por salvar instâncias das form e fazer a ponte entre interface + library
    public sealed class TelemetryManager
    {
        #region SINGLETON
       
        public TelemetryManager()
        {
        }

        public static TelemetryManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TelemetryManager();
                }
                return instance;
            }
        }
        #endregion

        static private TelemetryManager instance = null;

        public delegate void DelegateStatus(bool status);
        public DelegateStatus statusDelegate;

        public delegate void UpdateDataGridDelegate(List<byte> data);
        public UpdateDataGridDelegate updateDataGrid;

        public const int listenPort = 8888;

        private Frm_Devices devicesForm;
        private Frm_Server serverForm;
        private Frm_MainMenu mainMenuForm;
        private Frm_TCP_IP_Devices tcpIpDevices;

        public Frm_Server ServerForm
        {
            get { return serverForm; }
            set { serverForm = value; } 
        }
        public Frm_MainMenu MainMenuForm
        {
            get { return mainMenuForm; }   
            set { mainMenuForm = value; }
        }
        public Frm_Devices DevicesForm
        {
            get { return devicesForm; }
            set { devicesForm = value; }
        }
        public Frm_TCP_IP_Devices TcpIpDevices
        {
            get { return tcpIpDevices; }
            set { tcpIpDevices = value; }   
        }

        public UdpClient listener = new UdpClient(listenPort);

        /// <summary>
        /// Gets the input from a listening port and update a datagridview
        /// </summary>
        /// <param name="listOfBoards">list of byte from the listener(connected port)</param>

        public void GetDataFromListener()
        {
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);
            while (true)
            {
                try
                {
                    byte[] dataFromListener = listener.Receive(ref groupEP);
                    updateDataGrid.Invoke(dataFromListener.ToList());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        public bool IsValidIP(string addr)
        {
            string pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            Regex check = new Regex(pattern);
            bool valid = false;
            if (addr == "")
            {
                valid = false;
            }
            else
            {
                valid = check.IsMatch(addr, 0);
            }
            return valid;
        }

    }
}
