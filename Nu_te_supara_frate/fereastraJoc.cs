using System;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Nu_te_supara_frate
{
    public partial class fereastraJoc : Form
    {
        Zar zar;
        private Joc joc;
        int numar_zar;
        private string castigator;

        public fereastraJoc()
        {
            InitializeComponent();
            if(Login.numeJucator!="")
                labelNumeJucator.Text = Login.numeJucator;
            zar = new Zar();
            joc = new Joc(this);
        }
        public string getNumeJucator()
        {
            if (Login.numeJucator != "")
                return labelNumeJucator.Text;
            return "Jucator";
        }

        public string getCastigator()
        {
            return castigator;
        }

        public void castig(string numeCastigator)
        {
            castigator = numeCastigator;
            FereastraCastig ferCastig = new FereastraCastig(this);
            ferCastig.Show();
            this.Hide();
        }

        public void setLabelRand(string rand)
        {
            if (rand == "Rosu")
            {
                labelRandRosu.Visible = true;
                labelRandAlbastru.Visible = false;
            }
            else if (rand == "Albastru")
            {
                labelRandRosu.Visible = false;
                labelRandAlbastru.Visible = true;
            }
        }


        private void exitButton_Joc_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DaCuZarul(object sender, EventArgs e)
        {
            numar_zar=zar.daCuZarul(this);
            if (joc.getRand() == "Rosu" && (!joc.getRosuIesit()) && numar_zar!=6)
                joc.setRand("Albastru");
            else if (joc.getRand() == "Albastru" && (!joc.getAlbastruIesit()) && numar_zar!=6)
                joc.setRand("Rosu");

        }

        private void pRosu1_Click(object sender, EventArgs e)
        {
            //jucatorRosu.mutaPionRosu1(this,numar_zar);
            joc.Muta("Rosu",1,numar_zar,this);


        }

        private void pRosu2_Click(object sender, EventArgs e)
        {
            //jucatorRosu.mutaPionRosu2(this,numar_zar);
            joc.Muta("Rosu", 2, numar_zar, this);
        }

        private void pRosu3_Click(object sender, EventArgs e)
        {
            //jucatorRosu.mutaPionRosu3(this,numar_zar);
            joc.Muta("Rosu", 3, numar_zar, this);
        }

        private void pRosu4_Click(object sender, EventArgs e)
        {
            //jucatorRosu.mutaPionRosu4(this, numar_zar);
            joc.Muta("Rosu", 4, numar_zar, this);
        }

        private void pAlbastru1_Click(object sender, EventArgs e)
        {
            //jucatorAlbastru.mutaPionAlbastru1(this,numar_zar);
            joc.Muta("Albastru", 1, numar_zar, this);
        }

        private void pAlbastru2_Click(object sender, EventArgs e)
        {
            //jucatorAlbastru.mutaPionAlbastru2(this, numar_zar);
            joc.Muta("Albastru", 2, numar_zar, this);
        }

        private void pAlbastru3_Click(object sender, EventArgs e)
        {
            //jucatorAlbastru.mutaPionAlbastru3(this, numar_zar);
            joc.Muta("Albastru", 3, numar_zar, this);
        }

        private void pAlbastru4_Click(object sender, EventArgs e)
        {
            //jucatorAlbastru.mutaPionAlbastru4(this, numar_zar);
            joc.Muta("Albastru", 4, numar_zar, this);
        }

        private void labelNumeJucator_Click(object sender, EventArgs e)
        {

        }
    }
}
