using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using GSB;
using MySql.Data.MySqlClient;

namespace WindowsServices
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer = new Timer(); 
        private MySqlCommand maCo;
        private ConnexionSql maConnexion;
        private GestionDate GD = new GestionDate();
        private int dateJour ;
        private string dateTest;
        public Service1()
        {
            InitializeComponent();
            InitializeTimer();

        }

        protected override void OnStart(string[] args) //Lancement du service
        {
            InitializeTimer();
        }

        protected override void OnStop() //Arrêt du service
        {
         
        }

        private void InitializeTimer() //Initialisation du Timer
        {
            timer.Interval = 10000;
            timer.Elapsed += timer1_Tick;

            // Enable timer.  
            timer.Enabled = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e) //Fonction qui change les états des fiches en fonction de la date
        {
            try
            {
                maConnexion = ConnexionSql.getInstance("localhost", "gsb", "root", "");
                dateJour = Convert.ToInt32(GD.getJour());


                if (dateJour >= 1 && dateJour <= 10)
                {
                    maConnexion.openConnection();

                    maCo = maConnexion.reqExec("update fichefrais set idEtat ='CL' where idEtat ='CR' and mois = '" + GD.getDateMoisPrecedent() + "'");
                    maCo.ExecuteNonQuery();

                    maConnexion.closeConnection();
                }
                else if (dateJour >= 20 && dateJour <= 31)
                {
                    maConnexion.openConnection();

                    maCo = maConnexion.reqExec("update fichefrais set idEtat ='RB' where idEtat ='VA' and mois = '" + GD.getDateMoisPrecedent() + "'");
                    maCo.ExecuteNonQuery();
                    dateTest = GD.getDateMoisPrecedent();

                    maConnexion.closeConnection();
                }

            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }
    }
}

