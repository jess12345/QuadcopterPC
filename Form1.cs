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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_portType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_portType.SelectedText)
            {
                case "WIFI":
                    System.Console.WriteLine("Selected WIFI");
                    break;
                case "SERIAL":
                    System.Console.WriteLine("Selected SERIAL");
                    break;
                default:
                    System.Console.WriteLine("Unknown port type");
                    break;
            }
        }

        sdfsa


    }
}
