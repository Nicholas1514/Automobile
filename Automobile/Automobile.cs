using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Automobile
    {
        
        private int _velocità;
        private bool _accensione;
        
        public int Velocita
        {
            set { _velocità = value; }
            get { return _velocità; }
           
        }
        
        public bool Accensione
        {
            set { _accensione = value;}
            get { return _accensione; }
        }
        public Automobile(int velocità, bool accensione)
        {
            velocità = Velocita;
            accensione = Accensione;

           
        }
        public Automobile()
        {
            Velocita = 0;
            Accensione = false;
        }

        public string AccendiSpegni()
        {
            string a;
            if(Accensione)
            {
                if (Velocita == 0)
                {
                    a = "La macchina è spenta";
                    Accensione = false;
                }
                else
                    a = "Non puoi spegnere la macchina, sei in movimento";
                 

                
                    
               
            }
            else
            {
                a = "La macchina è accesa";
                Accensione = true;
            }
            return a;
            

            
        }
        public string Accellera()
        {
            string a;
            if (Accensione)
            {
                Velocita += 20;
                a = $"Hai accellerato, stai viaggiando a {Velocita}" + " Km/h";
            }
            else
            {
                a = "Non puoi accellerare, la macchina è spenta";
            }
           
            return a;

            
        }
        public string Frena()
        {
            string a;
            if (Accensione && Velocita > 0)
            {
                Velocita -= 10;
                a = $"Hai frenato, ora stai viaggiando a {Velocita}" + " Km/h";
            }
            else
            {
                a = $"Non puoi frenare, la macchina è spenta oppure sei fermo";
            }
            
            return a;
        }
       

    }

}

