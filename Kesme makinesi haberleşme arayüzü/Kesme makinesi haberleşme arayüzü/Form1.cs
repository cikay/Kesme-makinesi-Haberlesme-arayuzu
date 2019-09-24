using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kesme_makinesi_haberleşme_arayüzü
{
    public partial class Form1 : Form
    {
        haberlesme kesme = new haberlesme { butonIde = 1 };
        haberlesme ileri = new haberlesme { butonIde = 2 };
        haberlesme geri = new haberlesme  { butonIde = 3 };
        haberlesme mm25 = new haberlesme  { butonIde = 4 };
        haberlesme mm50 = new haberlesme  { butonIde = 5 };
        haberlesme mm75 = new haberlesme  { butonIde = 6 };
        haberlesme mm100 = new haberlesme { butonIde = 7 };
        haberlesme mm150 = new haberlesme { butonIde = 8 };
        haberlesme mm200 = new haberlesme { butonIde = 9 };


        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(230, 230, 230);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            haberlesme.ConnectToServer(btnConnect, btnDisconnect, lbCntInfo);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            haberlesme.Disconnect(btnConnect, btnDisconnect, lbCntInfo);
        }

        //kesme

        private void btnCut_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnCut_MouseClickDown(object sender, MouseEventArgs e)
        {
            if (!kesme.butonState)
            {
                clicking(kesme, btnCut);
            }
        }

        private void btnCut_MouseClickLeaveOrUp(object sender, EventArgs e)
        {
            if (kesme.butonState)
            {
                clicking(kesme, btnCut);
            }
        }

       

        //ileri

        private void btnForward_Click(object sender, EventArgs e)
        {
            
        }

        private void btnForward_MouseClickDown(object sender, MouseEventArgs e)
        {
            if (!ileri.butonState)
            {
                clicking(ileri, btnForward);
            }
        }
        private void btnForward_MouseClickLeaveOrUp(object sender, EventArgs e)
        {
            if (ileri.butonState)
            {
                clicking(ileri, btnForward);
            }
        }
       
        //geri

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_MouseClickDown(object sender, MouseEventArgs e)
        {
            if (!geri.butonState)
            {
                clicking(geri, btnBack);
            }
        }

        private void btnBack_MouseClickLeaveOrUp(object sender, EventArgs e)
        {
            if (geri.butonState)
            {
                clicking(geri, btnBack);
            }
        }


        //25mm

        private void btn25mm_Click(object sender, EventArgs e)
        {
            
        }

        private void btn25mm_MouseClickDown(object sender, MouseEventArgs e)
        {
            if (!mm25.butonState)
            {
                clicking(mm25, btn25mm);
            }
        }

        private void btn25mm_MouseClickLeaveOrUp(object sender, EventArgs e)
        {
            if (mm25.butonState)
            {
                clicking(mm25, btn25mm);
            }
        }

        //50mm
        private void btn50mm_Click(object sender, EventArgs e)
        {
            
        }

        private void btn50mm_MouseClickDown(object sender, MouseEventArgs e)
        {
            if (!mm50.butonState)
            {
                clicking(mm50, btn50mm);
            }
        }

        private void btn50mm_MouseClickLeaveOrUp(object sender, EventArgs e)
        {
            if (mm50.butonState)
            {
                clicking(mm50, btn50mm);
            }
        }

        //75mm
        private void btn75mm_Click(object sender, EventArgs e)
        {
            
        }

        private void btn75mm_MouseClickDown(object sender, MouseEventArgs e)
        {
            if (!mm75.butonState)
            {
                clicking(mm75, btn75mm);
            }
        }

        private void btn75mm_MouseClickLeaveOrUp(object sender, EventArgs e)
        {
            if (mm75.butonState)
            {
                clicking(mm75, btn75mm);
            }
        }

        //100mm
        private void btn100mm_Click(object sender, EventArgs e)
        {
            
        }

        private void btn100mm_MouseClickDown(object sender, MouseEventArgs e)
        {
            if (!mm100.butonState)
            {
                clicking(mm100, btn100mm);
            }
        }

        private void btn100mm_MouseClickLeaveOrUp(object sender, EventArgs e)
        {
            if (mm100.butonState)
            {
                clicking(mm100, btn100mm);
            }
        }

        //150mm
        private void btn150mm_Click(object sender, EventArgs e)
        {
            
        }

        private void btn150mm_MouseClickDown(object sender, MouseEventArgs e)
        {
            if (!mm150.butonState)
            {
                clicking(mm150, btn150mm);
            }
        }

        private void btn150mm_MouseClickLeaveOrUp(object sender, EventArgs e)
        {
            if (mm150.butonState)
            {
                clicking(mm150, btn150mm);
            }
        }

        //200mm
        private void btn200mm_Click(object sender, EventArgs e)
        {
            
        }


        private void btn200mm_MouseClickDown(object sender, MouseEventArgs e)
        {
            if (!mm200.butonState)
            {
                clicking(mm200, btn200mm);
            }
        }

        private void btn200mm_MouseClickLeaveOrUp(object sender, EventArgs e)
        {
            if (mm200.butonState)
            {
                clicking(mm200, btn200mm);
            }
        }

        private void clicking(haberlesme hb, Button btn)
        {
            hb.butonState = !hb.butonState;
            hb.butonaTıklandıgında(btnCut, btnConnect, btnDisconnect, lbCntInfo);
        }

    }
}
