using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas_médicas
{
	internal class Cita
	{
		public int Num { get; set; }
		public Estudiante Est { get; set; }
		public string Enfermedad { get; set; }
		public double Precio { get; set; }

		public override string ToString()
		{
			return $"Número de Cita: {Num}, Enfermedad: {Enfermedad}, Estudiante: {Est.Nombre}, Universidad: {Estudiante.Universidad}, Precio: {Precio:C}";
		}
	}

}
