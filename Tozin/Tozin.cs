using Bunifu.Framework.UI;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management; // need to add System.Management to your project references.



namespace Tozin
{
    public partial class Main_Toain : Form
    {
        public Main_Toain()
        {
            InitializeComponent();
            MainPages.SelectedIndex = 2;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //Task.Delay(200).Wait();

            //bunifuTransition1.ShowSync(bunifuCards1, false, Animation.Mosaic);
            //bunifuTransition1.ShowSync(bunifuCards2, false, Animation.ScaleAndHorizSlide);
            //bunifuTransition1.ShowSync(bunifuCards3, false, Animation.Particles);
            //bunifuTransition1.ShowSync(bunifuCards4, false, Animation.Leaf);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintListIn_Click(object sender, EventArgs e)
        {
            panelMenuToolbar.Visible = !panelMenuToolbar.Visible;
        }
         

        

        private void ControlTonaz_ValueChanged(object sender, DevComponents.Instrumentation.ValueChangedEventArgs e)
        {
            labelToneBaschol.Text =ControlTonaz.Value.ToString();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                  
        private void checkPort_CheckedChanged(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
               foreach (string port in ports)
                    comPort.Items.Add(port );
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
                        
            //foreach (var usbDevice1 in getusb)
            //{
            //    comPort.Items.Add(usbDevice.DeviceID);
            //}
        }
    }
}


//With SerialPort
//            '.PortName = COM1
//            .BaudRate = 9600
//            .DataBits = 8
//            .Parity = Parity.None
//            .StopBits = 1
//            .NewLine = Chr(10)
//        End With