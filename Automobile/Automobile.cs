﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
	internal class Automobile
	{

		private int _velocità;
		private bool _accensione;
		private int _marcia;
		private const short _velcambio = 20;

		public int Velocita
		{
			set { _velocità = value; }
			get { return _velocità; }

		}
		public int Velcambio
		{
			get { return _velcambio; }
		}
		public bool Accensione
		{
			set { _accensione = value; }
			get { return _accensione; }
		}

		public int Marcia
		{
			set { _marcia = value; }
			get { return _marcia; }
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
			Marcia = 0;
		}

		public string AccendiSpegni()
		{
			string a;
			if (Accensione)
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
				a = "La macchina è accesa, metti in prima";
				Accensione = true;
			}
			return a;



		}
		public string Accellera()
		{
			string a;

			if (Accensione)
			{
				if (_velcambio * _marcia != _velocità)
				{
					Velocita += 20;
					a = $"Hai accellerato, stai viaggiando a {Velocita}" + " Km/h";
				}
				else
				{
					a = "Non puoi accellerare, la macchina è spenta oppure non hai inserito la prima, oppure non ci sono le condizioni di cambiare";
				}
			}
			else
			{
				a = "La macchina è spenta";
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

		public string MarciaSu()
		{
			string a;
			if (Accensione && Velocita == 0)
			{
				Marcia += 1;
				a = $"Hai cambiato marcia, ora sei in {Marcia}^";

				
			}
			else if (Accensione && Velcambio == Velocita)
			{
				Marcia += 1;
				a = $"Hai cambiato marcia, ora sei in {Marcia} ^";


			}
			else
			{
				a = "Non ci sono le condizioni per cambiare la marcia";
			}
			return a;
		}



	}

}

