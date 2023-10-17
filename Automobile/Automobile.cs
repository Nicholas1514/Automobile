using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Automobile
    {
        private string _azione;
        private int _velocità;
        
        public int velocità
        {
            set { velocità = value; }
            get { return velocità; }
           
        }
        public string azione
        {
            set { azione = value; }
            get { return azione; }
        }

        public bool AccendiSpegni(bool accendi)
        {
            return accendi;
        }
        

    }

}

