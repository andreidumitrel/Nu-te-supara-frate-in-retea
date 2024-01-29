using System;
using System.IO;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Nu_te_supara_frate
{
    public partial class FereastraJoc : Form
    {   //SERVER
        Zar zar;
        private Joc joc;
        int numar_zar;
        private string castigator;
        private Login login;

        public TcpListener listener;
        public String listener_data;
        Thread t;
        NetworkStream stream_server;
        bool work_thread;
        private static FereastraJoc server_form;

        public FereastraJoc(Login login)
        {   
            InitializeComponent();
            if(login.numeJucator!="")
                labelNumeJucator.Text = login.numeJucator;
            zar = new Zar();
            joc = new Joc(this);

            listener = new TcpListener(System.Net.IPAddress.Any, 5000);
            listener.Start();
            t = new Thread(new ThreadStart(asculta_server));
            work_thread = true;
            t.Start();

            server_form = this;
            //this.J1.Text = "";
        }

        public void asculta_server()
        {
            while (work_thread)
            {
                Socket socketServer = listener.AcceptSocket();
                try
                {
                    stream_server = new NetworkStream(socketServer);
                    StreamReader citireServer = new StreamReader(stream_server);

                    while (work_thread)
                    {

                        string dateServer = citireServer.ReadLine();
                        if (dateServer != null)
                            Console.WriteLine(dateServer);

                        MethodInvoker m = new MethodInvoker(() =>
                        {
                            //string dataaa = dateServer;
                            if (dateServer[0] == 'z')
                            {   numar_zar = int.Parse(dateServer[1] + "");
                                zar.setNumarZar(numar_zar,this);

                            }
                            else if (dateServer[0] == 'n')
                            {   labelNumeInamic.Text = "";
                                for (int i = 1; i < dateServer.Length; i++)
                                {   
                                    labelNumeInamic.Text += dateServer[i];
                                }
                                trimiteRand();
                            }
                            else if (dateServer[0] == 'p')
                            {   Console.WriteLine(dateServer);
                                switch (int.Parse(dateServer[1] + ""))
                                {
                                    case 1:
                                        joc.Muta("Rosu", 1, zar.getNumarZar(), this);
                                        break;
                                    case 2:
                                        joc.Muta("Rosu", 2, zar.getNumarZar(), this);
                                        break;
                                    case 3:
                                        joc.Muta("Rosu", 3, zar.getNumarZar(), this);
                                        break;
                                    case 4:
                                        joc.Muta("Rosu", 4, zar.getNumarZar(), this);
                                        break;
                                }
                                trimiteRand();
                            }
                            else if (dateServer[0] == 'r')
                            {
                                if (dateServer[1] == 'a')
                                {
                                    joc.setRand("Albastru");
                                }
                                else if (dateServer[1] == 'r')
                                {
                                    joc.setRand("Rosu");
                                }
                            }



                        });
                        server_form.Invoke(m);

                    }
                    stream_server.Close();
                }
                catch (Exception e)
                {
                    #if LOG
                        Console.WriteLine(e.Message);
                    #endif
                }
                socketServer.Close();
            }

        }

        public string getNumeJucator()
        {
                return labelNumeJucator.Text;
        }

        public string getCastigator()
        {
            return castigator;
        }

        public void trimiteRand()
        {
            if (joc.getRand() ==
                "Albastru") //verifica al cui jucator este randul si apoi trimite mesajul pentu a modifica si in client
            {
                StreamWriter scriere = new StreamWriter(stream_server);
                scriere.AutoFlush = true;
                scriere.WriteLine("ra");
            }

            if (joc.getRand() == "Rosu")
            {
                StreamWriter scriere = new StreamWriter(stream_server);
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
            if (joc.getRand() == "Albastru")
            {
                numar_zar = zar.daCuZarul(this);

                if (joc.getRand() == "Rosu" && (!joc.getRosuIesit()) && numar_zar != 6)
                    joc.setRand("Albastru");
                else if (joc.getRand() == "Albastru" && (!joc.getAlbastruIesit()) && numar_zar != 6)
                    joc.setRand("Rosu");

                if (joc.getAlbastruIesit() == false && numar_zar < 6)
                {
                    joc.setRand("Rosu");
                    trimiteRand();
                }

                StreamWriter scriere = new StreamWriter(stream_server);
                scriere.AutoFlush = true; // enable automatic flushing
                scriere.WriteLine("z" + Convert.ToString(numar_zar));
                //se trimit datele printr-un string care incepe cu "z"
                //pentru ca la momentul primirii sa ne dam seama ca stringul prmit este o informatie despre zar
            }
            else
                MessageBox.Show("Nu este randul tau!");
            

        }

        private void pRosu1_Click(object sender, EventArgs e) {} 
        private void pRosu2_Click(object sender, EventArgs e) {}
        private void pRosu3_Click(object sender, EventArgs e) {}
        private void pRosu4_Click(object sender, EventArgs e) {}

        private void pAlbastru1_Click(object sender, EventArgs e)
        {
            joc.Muta("Albastru", 1, numar_zar, this);
            StreamWriter scriere = new StreamWriter(stream_server);
            scriere.AutoFlush = true;
            scriere.WriteLine("p1");
        }

        private void pAlbastru2_Click(object sender, EventArgs e)
        {
            joc.Muta("Albastru", 2, numar_zar, this);
            StreamWriter scriere = new StreamWriter(stream_server);
            scriere.AutoFlush = true;
            scriere.WriteLine("p2");
        }

        private void pAlbastru3_Click(object sender, EventArgs e)
        {
            joc.Muta("Albastru", 3, numar_zar, this);
            StreamWriter scriere = new StreamWriter(stream_server);
            scriere.AutoFlush = true;
            scriere.WriteLine("p3");
        }

        private void pAlbastru4_Click(object sender, EventArgs e)
        {
            joc.Muta("Albastru", 4, numar_zar, this);
            StreamWriter scriere = new StreamWriter(stream_server);
            scriere.AutoFlush = true;
            scriere.WriteLine("p4");
        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
            while (true)
            {
                try
                {   
                    StreamWriter scriere = new StreamWriter(stream_server);
                    scriere.AutoFlush = true; // enable automatic flushing
                    scriere.WriteLine("n" + this.labelNumeJucator.Text);
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Waiting for other player to join");


                }
            }
        }
    }
}
