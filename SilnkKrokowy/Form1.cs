using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using FTD2XX_NET;

namespace SilnkKrokowy
{


    public partial class Form1 : Form
    {

        FTD2XX_NET.FTDI.FT_STATUS ftstatus;

        FTDI device = new FTDI();

        byte[] LeftP = { 0x08, 0x02, 0x04, 0x01 };
        byte[] RightP = { 0x01, 0x04, 0x02, 0x08 };

        byte[] stop = { 0x00 };

        UInt32 numBytesWritten = 0;
        int index = 0;
        int direction = 0;
        int speed = 150; //min 140 

        


        public Form1()
        {
            InitializeComponent();

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enablebtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                UInt32 ftdiDeviceCount = 0;
                device.GetNumberOfDevices(ref ftdiDeviceCount);
                FTD2XX_NET.FTDI.FT_DEVICE_INFO_NODE[] devicelist = new FTD2XX_NET.FTDI.FT_DEVICE_INFO_NODE[ftdiDeviceCount];
                device.GetDeviceList(devicelist);
         
                ftstatus = device.OpenBySerialNumber(devicelist[0].SerialNumber);
                ftstatus = device.SetBitMode(0xff, 1);
                Console.WriteLine("Urzadzenie: " + ftstatus.ToString());
                stepLeftbtn.Enabled = true;
                stepRightbtn.Enabled = true;
            }
            catch (Exception ee)
            {
                Console.WriteLine("Urzadzenie nie zostalo podlaczone!\nNacisnij [ENTER] aby zamknac program");
                Console.ReadLine();
                Environment.Exit(0);
            }
        } 
       
        private void rotate(int count, int direction)
        {
            
                numBytesWritten = 0;
                Int32 bytesToWrite = 1;


                for (int i = 0; i < count; i++)
                {
                    index += direction;
                    if (index < 0)
                    {
                        index = 3;
                    }
                    else if (index > 3)
                    {
                        index = 0;
                    }

                if (trackBar2.Value == 1)
                {
                    byte[] y = { (byte)(LeftP[index] << 4) };
                    device.Write(y, bytesToWrite, ref numBytesWritten);
                }
                else
                {
                    byte[] x = { LeftP[index] };
                    device.Write(x, bytesToWrite, ref numBytesWritten);

                }

                    Thread.Sleep(speed - trackBar1.Value * 28);
                }
            


        }
        

        private void stepLeftbtn_Click(object sender, EventArgs e)
        {
            double degree = Convert.ToInt32(degreeTB.Text)/7.5;
            int count = (int)degree;


           
            rotate(count, -1);
        }

        private void stepRightbtn_Click(object sender, EventArgs e)
        {
            double degree = Convert.ToInt32(degreeTB.Text) / 7.5;
            int count = (int)degree;

            rotate(count, 1);
        }

        private void degreeTB_TextChanged(object sender, EventArgs e)
        {

        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void disablebtn_Click(object sender, EventArgs e)
        {
            stepLeftbtn.Enabled = false;
            stepRightbtn.Enabled = false;
            ftstatus = device.Close();
        }

        private void trackBar2_Scroll_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
