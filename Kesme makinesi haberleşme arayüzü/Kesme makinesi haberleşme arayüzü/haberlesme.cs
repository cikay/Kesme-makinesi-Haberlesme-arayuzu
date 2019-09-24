using System;
using System.Text;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Linq;
using System.Collections;

namespace Kesme_makinesi_haberleşme_arayüzü
{
    class haberlesme
    {

        public static TcpClient tcp = new TcpClient();
        Ping ping = new Ping();
        PingOptions pOptions = new PingOptions();
        PingReply pingCevap;
        static NetworkStream network;


        public bool butonState { get; set; } = false;

        public byte butonIde { get; set; }

        public bool onay { get; set; } = false;

        byte[] tcpData;

        public static string IpAdress { get; set; } = "192.168.2.85";

        public static int PortNo { get; set; } = 80;



        public void OnOff(Button btn, byte[] gelen)
        {
            if (onay)
            {
                btn.BackColor = Color.DeepSkyBlue;
                btn.ForeColor = Color.White;
                onay = false;

            }
           else
           {
                btn.BackColor = Color.Gray;
                btn.ForeColor = Color.Black;
                onay = true;  
           }
        }

        public void butonaTıklandıgında(Button tıklananBtn, Button btnConnect, Button btnDisconnect, Label lbCntInfo)
        {
            try
            {

                PingAt();

                tcpData = new byte[] { butonIde, Convert.ToByte(butonState), Convert.ToByte(onay) };
                byte[] gelen = new byte[tcp.ReceiveBufferSize];
                ReadWrite(network, gelen, tcpData);
                OnOff(tıklananBtn, gelen);
                
            }
            catch
            {
                btnConnect.BackColor = Color.Blue;
                btnConnect.ForeColor = Color.White;
                btnDisconnect.BackColor = Color.Gray;
                btnDisconnect.ForeColor = Color.DimGray;
                lbCntInfo.Text= "Makineye bağlı değilsiniz!";
                MessageBox.Show("Makineye bağlı değilsiniz!");
            }
        }

        public static void ConnectToServer(Button btnConnect, Button btnDisconnect, Label lbCntInfo)
        {

            if (String.Compare(IpAdress, "") != 0)
            {
                try
                {
                    tcp = new TcpClient();
                    tcp.Connect(IpAdress, PortNo);
                    network = tcp.GetStream();
                    btnConnect.BackColor = Color.Gray;
                    btnConnect.ForeColor = Color.DimGray;
                    btnDisconnect.BackColor = Color.Blue;
                    btnDisconnect.ForeColor = Color.White;
                    lbCntInfo.Text = "Makineye bağlısınız!";
                    
                }
                catch
                {
                    btnConnect.BackColor = Color.Blue;
                    btnConnect.ForeColor = Color.White;
                    btnDisconnect.BackColor = Color.Gray;
                    btnDisconnect.ForeColor = Color.DimGray;
                    lbCntInfo.Text = "Makineye bağlı değilsiniz!";
                    MessageBox.Show("Bağlanılamadı!");
                }
            }
            else
            {
                MessageBox.Show("IP adresi veya port numarası girmediniz!");
            }
 
        }

        public void PingAt()
        {
            pOptions.DontFragment = true;
            byte[] myByte = new byte[32];
            pingCevap = ping.Send(IpAdress, PortNo, myByte, pOptions);
        }

        public void ReadWrite( NetworkStream network, byte[] gelen, byte[] mesaj_dizi)
        {
            
            if (network.CanWrite)
            {
                network.Write(mesaj_dizi, 0, mesaj_dizi.Length);
                
            }
            else
            {
                MessageBox.Show("veri gönderilemedi!");
                tcp.Close();
                return;
            }

            if (network.CanRead)
            {
                network.Read(gelen, 0, (int)tcp.ReceiveBufferSize);

                if (gelen[2] == 1) onay = true;
                
            }
            else
            {
                MessageBox.Show("veri alınmadı!!");
                tcp.Close();
                return;
            }
        }

        static public void Disconnect(Button btnConnect, Button btnDisconnect, Label lbCntInfo)
        {
            if(network.CanRead || network.CanWrite)
            {

                network.Close();
                tcp.Close();
                btnDisconnect.BackColor = Color.Gray;
                btnDisconnect.ForeColor = Color.DimGray;
                btnConnect.BackColor = Color.Blue;
                btnConnect.ForeColor = Color.White;
                lbCntInfo.Text = "Makineye bağlı değilsiniz!";

            }
        }

    }
    static class StructuralExtensions
    {
        public static bool StructuralEquals<T>(this T a, T b)
            where T : IStructuralEquatable
        {
            return a.Equals(b, StructuralComparisons.StructuralEqualityComparer);
        }

        public static int StructuralCompare<T>(this T a, T b)
            where T : IStructuralComparable
        {
            return a.CompareTo(b, StructuralComparisons.StructuralComparer);
        }
    }
}
