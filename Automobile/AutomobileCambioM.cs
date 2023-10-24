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
			Marcia = 0;
			Ngiri = 0;

		}
		public override string AccendiSpegni()
		{
			return base.AccendiSpegni();
		}
		public override string Accellera()
		{
			return base.Accellera();
		}
		public override string Frena()
		{
			return base.Frena();
		}
	}
}
