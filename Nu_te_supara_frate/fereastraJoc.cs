using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nu_te_supara_frate
{
    public partial class fereastraJoc : Form
    {
        Zar zar;
        PictureBox zar1Poza;
        PictureBox zar2Poza;
        PictureBox zar3Poza;
        PictureBox zar4Poza;
        PictureBox zar5Poza;
        PictureBox zar6Poza;

        public fereastraJoc()
        {
           // zar = new Zar();
            InitializeComponent();
           // int fataZar;
            //fataZar = zar.getZar();
           // string fataZarStr=fataZar.ToString();
            labelNumeJucator.Text = Login.numeJucator;
           // labelNumeJucator.Text = fataZarStr;




            
            zar1Poza.Image = Image.FromFile("C:\\Users\\andre\\OneDrive\\Desktop\\ProiectPOO\\Nu_te_supara_frate\\zar1.png");
            zar2Poza.Image = Image.FromFile("C:\\Users\\andre\\OneDrive\\Desktop\\ProiectPOO\\Nu_te_supara_frate\\zar2.png");
            zar3Poza.Image = Image.FromFile("C:\\Users\\andre\\OneDrive\\Desktop\\ProiectPOO\\Nu_te_supara_frate\\zar3.png");
            zar4Poza.Image = Image.FromFile("C:\\Users\\andre\\OneDrive\\Desktop\\ProiectPOO\\Nu_te_supara_frate\\zar4.png");
            zar5Poza.Image = Image.FromFile("C:\\Users\\andre\\OneDrive\\Desktop\\ProiectPOO\\Nu_te_supara_frate\\zar5.png");
            zar6Poza.Image = Image.FromFile("C:\\Users\\andre\\OneDrive\\Desktop\\ProiectPOO\\Nu_te_supara_frate\\zar6.png");

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

        private void daCuZarul(object sender, EventArgs e)
        {
            zar = new Zar();
            int fataZar = zar.getZar();
            switch (fataZar)
            {
                case 1:
                    zar1.Image = zar1Poza.Image;
                    break;
                case 2:
                    zar1.Image = zar2Poza.Image;
                    break;
                case 3:
                    zar1.Image = zar3Poza.Image;
                    break;
                case 4:
                    zar1.Image = zar4Poza.Image;
                    break;
                case 5:
                    zar1.Image = zar5Poza.Image;
                    break;
                case 6:
                    zar1.Image = zar6Poza.Image;
                    break;
            }

        }
    }
}
