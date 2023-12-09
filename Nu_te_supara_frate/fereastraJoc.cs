using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nu_te_supara_frate.Properties;

namespace Nu_te_supara_frate
{
    public partial class fereastraJoc : Form
    {
        Zar zar;
        Rosu rosu;
        public fereastraJoc()
        {
            InitializeComponent();
            labelNumeJucator.Text = Login.numeJucator;
            zar = new Zar();
            rosu = new Rosu();
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
            
            pRosu1.Location =  rosu.Coordonate[zar.daCuZarul(this)];


        }

    }
}
