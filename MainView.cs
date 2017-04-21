using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuadcopterPC
{
    public partial class MainView : Form
    {
        private bool commPortOpen = false;


        public MainView()
        {
            InitializeComponent();
        }


        private void comboBox_portType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_portType.SelectedItem.ToString())
            {
                case "WIFI":
                    //System.Console.WriteLine("Selected WIFI");
                    label_portName.Text = "IP Address";
                    textBox_portName.Text = "192.168.1.11";
                    label_additionalPortInfo.Text = "Port";
                    textBox_additonalPortInfo.Text = "5003";
                    break;
                case "SERIAL":
                    //System.Console.WriteLine("Selected SERIAL");
                    label_portName.Text = "COM Port";
                    textBox_portName.Text = "COM3";
                    label_additionalPortInfo.Text = "Baud Rate";
                    textBox_additonalPortInfo.Text = "2400";
                    break;
                default:
                    System.Console.WriteLine("Unknown port type "+comboBox_portType.SelectedItem.ToString());
                    break;
            }
        }


        private void button_OpenCloseCommPort_Click(object sender, EventArgs e)
        {
            if (commPortOpen)
            {
                System.Console.WriteLine("Trying to close port");

            }
            else
            {
                System.Console.WriteLine("Trying to open port");

            }
        }


    }
}
