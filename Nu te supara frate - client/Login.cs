using System;
using System.Windows.Forms;

namespace Nu_te_supara_frate
{

    public partial class Login : Form
    {
        public string numeJucator;


        public Login()
        {
            InitializeComponent();

        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStart_click(object sender, EventArgs e)
        {
            numeJucator = textBoxNume.Text;
            fereastraJoc fereastraJoc = new fereastraJoc(this);
            fereastraJoc.Show();
            this.Hide();
        }

        /*private void enterButtonDown(object sender, KeyEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.buttonStart_click(sender, e);
        }
        */
        private void enterButtonDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                buttonStart.PerformClick();
        }
    }
}
