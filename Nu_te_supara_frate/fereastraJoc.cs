using System;
using System.Windows.Forms;

namespace Nu_te_supara_frate
{
    public partial class fereastraJoc : Form
    {
        Zar zar;
        JucatorRosu jucatorRosu;
        JucatorAlbastru jucatorAlbastru;
        int numar_zar;

        public fereastraJoc()
        {
            InitializeComponent();
            labelNumeJucator.Text = Login.numeJucator;
            zar = new Zar();
            jucatorRosu = new JucatorRosu();
            jucatorAlbastru = new JucatorAlbastru();
            
        }

        private void panelJoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Joc_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DaCuZarul(object sender, EventArgs e)
        {
            numar_zar=zar.daCuZarul(this);
            jucatorRosu.setPoateMuta(true);
            jucatorAlbastru.setPoateMuta(true);

        }

        private void pRosu1_Click(object sender, EventArgs e)
        {
            jucatorRosu.mutaPionRosu1(this,numar_zar);
        }

        private void pRosu2_Click(object sender, EventArgs e)
        {
            jucatorRosu.mutaPionRosu2(this,numar_zar);
        }

        private void pRosu3_Click(object sender, EventArgs e)
        {
            jucatorRosu.mutaPionRosu3(this,numar_zar);
        }

        private void pRosu4_Click(object sender, EventArgs e)
        {
            jucatorRosu.mutaPionRosu4(this, numar_zar);
        }

        private void pAlbastru1_Click(object sender, EventArgs e)
        {
            jucatorAlbastru.mutaPionAlbastru1(this,numar_zar);
        }

        private void pAlbastru2_Click(object sender, EventArgs e)
        {
            jucatorAlbastru.mutaPionAlbastru2(this, numar_zar);
        }

        private void pAlbastru3_Click(object sender, EventArgs e)
        {
            jucatorAlbastru.mutaPionAlbastru3(this, numar_zar);
        }

        private void pAlbastru4_Click(object sender, EventArgs e)
        {
            jucatorAlbastru.mutaPionAlbastru4(this, numar_zar);
        }
    }
}
