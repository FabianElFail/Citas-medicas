using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas_médicas
{
	internal class Estudiante
	{
		public int Codigo { get; set; }
		public string Nombre { get; set; }
		public string Universidad { get; set; }

		public Estudiante(int codigo, string nomb, string uni)
		{
			Codigo = codigo;
			Nombre = nomb;
			Universidad = uni;
		}

		public override string ToString()
		{
			return $"Código: {Codigo}, Nombre: {Nombre}, Universidad: {Universidad}";
		}
	}

}

}
