using System;
using System.IO;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Nu_te_supara_frate
{
    public partial class fereastraJoc : Form
    {   //client
        Zar zar;
        private Joc joc;
        int numar_zar;
        private string castigator;
        private string ip;
        private Login login;

        public TcpClient client;
        public NetworkStream clientStream;
        public bool ascult;
        public fereastraJoc clientForm;
        public Thread t;

        public fereastraJoc(Login login)
        {
            InitializeComponent();
            if(login.numeJucator!="")
                labelNumeJucator.Text = login.numeJucator;
            zar = new Zar();
            joc = new Joc(this);
            ip = login.textBoxIP.Text;

            clientForm = this;
        }
        public string getNumeJucator()
        {
                return labelNumeJucator.Text;
        }

        public void Asculta_client()
        {
            StreamReader citire = new StreamReader(clientStream);
            String dateClient;
            while (ascult)
            {
                dateClient = citire.ReadLine();
                MethodInvoker m = new MethodInvoker(() =>
                {
                    if (dateClient[0] == 'z')
                    {
                        numar_zar = int.Parse(dateClient[1] + "");
                        zar.setNumarZar(numar_zar, this);

                    }
                    else if (dateClient[0] == 'n')
                    {
                        labelNumeInamic.Text = ""; 
                        for (int i = 1; i < dateClient.Length; i++){
                            labelNumeInamic.Text += dateClient[i];
                        }
                        trimiteRand();
                    }
                    else if (dateClient[0] == 'p')
                    {   Console.WriteLine(dateClient);
                        switch (int.Parse(dateClient[1] + ""))
                        {
                            case 1:
                                joc.Muta("Albastru",1,zar.getNumarZar(),this);
                                break;
                            case 2:
                                joc.Muta("Albastru",2,zar.getNumarZar(),this);
                                break;
                            case 3:
                                joc.Muta("Albastru",3,zar.getNumarZar(),this);
                                break;
                            case 4:
                                joc.Muta("Albastru",4,zar.getNumarZar(),this);
                                break;
                        }
                        trimiteRand();
                    }
                    else if (dateClient[0] == 'r')
                    {
                        if (dateClient[1] == 'a')
                        {
                            joc.setRand("Albastru");
                        }
                        else if (dateClient[1] == 'r')
                        {
                            joc.setRand("Rosu");
                        }
                    }

                });
                clientForm.Invoke(m);
            }
        }

        public string getCastigator()
        {
            return castigator;
        }

        public void trimiteRand()
        {
            if (joc.getRand() ==
                "Albastru") //verifica al cui jucator este randul si apoi trimite mesajul pentu a modifica si in server
            {
                StreamWriter scriere = new StreamWriter(clientStream);
                scriere.AutoFlush = true;
                scriere.WriteLine("ra");
            }

            if (joc.getRand() == "Rosu")
            {
                StreamWriter scriere = new StreamWriter(clientStream);
                scriere.AutoFlush = true;
                scriere.WriteLine("rr");
            }
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
                labelRandAlbastru.Visible = false;
                labelRandRosu.Visible = true;
            }
            else if (rand == "Albastru")
            {
                labelRandAlbastru.Visible = true;
                labelRandRosu.Visible = false;
            }
        }


        private void exitButton_Joc_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DaCuZarul(object sender, EventArgs e)
        {
            if (joc.getRand() == "Rosu")
            {
                numar_zar = zar.daCuZarul(this);
            

                if (joc.getRand() == "Rosu" && (!joc.getRosuIesit()) && numar_zar != 6)
                    joc.setRand("Albastru");
                else if (joc.getRand() == "Albastru" && (!joc.getAlbastruIesit()) && numar_zar != 6)
                    joc.setRand("Rosu");

                if (joc.getRosuIesit() == false && numar_zar < 6)
                {
                    joc.setRand("Albastru");
                    trimiteRand();
                }
                StreamWriter scriere = new StreamWriter(clientStream);
                scriere.AutoFlush = true; // enable automatic flushing
                scriere.WriteLine("z" + Convert.ToString(numar_zar));
                //se trimit datele printr-un string care incepe cu "z"
                //pentru ca la momentul primirii sa ne dam seama ca stringul prmit este o informatie despre zar
            }
            else
            {
                MessageBox.Show("Nu este randul tau!");
            }

        }

        private void pRosu1_Click(object sender, EventArgs e)
        {
            joc.Muta("Rosu",1,numar_zar,this);
            StreamWriter scriere = new StreamWriter(clientStream);
            scriere.AutoFlush = true;
            scriere.WriteLine("p1");

        }

        private void pRosu2_Click(object sender, EventArgs e)
        {
            joc.Muta("Rosu", 2, numar_zar, this);
            StreamWriter scriere = new StreamWriter(clientStream);
            scriere.AutoFlush = true;
            scriere.WriteLine("p2");
        }

        private void pRosu3_Click(object sender, EventArgs e)
        {
            joc.Muta("Rosu", 3, numar_zar, this);
            StreamWriter scriere = new StreamWriter(clientStream);
            scriere.AutoFlush = true;
            scriere.WriteLine("p3");
        }

        private void pRosu4_Click(object sender, EventArgs e)
        {
            joc.Muta("Rosu", 4, numar_zar, this);
            StreamWriter scriere = new StreamWriter(clientStream);
            scriere.AutoFlush = true;
            scriere.WriteLine("p4");
        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            client = new TcpClient(ip, 5000);//127.0.0.1
            ascult = true;
            t = new Thread(new ThreadStart(Asculta_client)); 
            //se conecteaza pe ip local si porneste metoda
            //de asculta pe un th separat
            t.Start();
            clientStream = client.GetStream();

            StreamWriter scriere = new StreamWriter(clientStream);
            scriere.AutoFlush = true; // enable automatic flushing
            scriere.WriteLine("n" + this.labelNumeJucator.Text);



        }
    }
}
