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

		public Cita(int num, Estudiante est, string enfermedad, double precio)
		{
			Num = num;
			Est = est;
			Enfermedad = enfermedad;
			Precio = precio;
		}

		public override string ToString()
		{
			return $"Número de Cita: {Num}, {Est}, Enfermedad: {Enfermedad}, Precio: {Precio:C}";
		}
	

}

}
