using System.Windows.Forms;

namespace Nu_te_supara_frate
{
    public partial class FereastraCastig : Form
    {
        public FereastraCastig(fereastraJoc ferJoc)
        {
            InitializeComponent();
            this.labelCastigator.Text = (ferJoc.getCastigator()+" A CASTIGAT!");
        }

        private void FereastraCastig_Load(object sender, System.EventArgs e)
        {

        }
    }
}
