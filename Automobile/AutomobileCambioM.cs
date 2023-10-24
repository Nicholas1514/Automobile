using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
	internal class AutomobileCambioM : Automobile
	{
		private int _ngiri;

		public int Ngiri
		{
			set { _ngiri = value; }
			get { return _ngiri; }
		}
		public AutomobileCambioM() : base() 
		{
			Velocita = 0;
			Accensione = false;
			Marcia = 1;
			Ngiri = 0;
			Velcambio = 20;

		}
		public override string AccendiSpegni()
		{
			return base.AccendiSpegni();
		}
		public string Acc()
		{
			string a;

			if (Accensione)
			{
				if (_velcambio * _marcia != _velocità)
				{
					Velocita += 20;
					Marcia += 1;
					a = $"Hai accellerato, stai viaggiando a {Velocita}" + $" Km/h e sei in {Marcia}";
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
		public string F()
		{
			string a;
			if (Accensione && Velocita > 0)
			{
				Velocita -= 20;
				Marcia -= 1;
				a = $"Hai frenato, ora stai viaggiando a {Velocita}" + $" Km/h e sei in {Marcia}";
			}
			else
			{
				a = $"Non puoi frenare, la macchina è spenta oppure sei fermo";
			}

			return a;
		}

	}
}
