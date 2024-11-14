using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas_médicas
{
	internal class CitaUtil
	{

		private static int contadorCitas = 1; 
		private static int indice = 0;  

		public static void Crear(Cita[] citas)
		{
			
			if (indice >= citas.Length)
			{
				Console.WriteLine("No se pueden agregar más citas. Espacio lleno (Máximo 100).");
				return;
			}


			int codigo;
			do
			{
				Console.Write("Ingrese el código del estudiante (número entero): ");
			} while (!int.TryParse(Console.ReadLine(), out codigo));

			Console.Write("Ingrese el nombre del estudiante: ");
			string nomb = Console.ReadLine();

			
			Console.Write("Ingrese la universidad del estudiante: ");
			string uni = Console.ReadLine();
			Estudiante est = new Estudiante(codigo, nomb, uni);

			int num = contadorCitas;
			
			Console.Write("Ingrese la enfermedad del estudiante: ");
			string enfermedad = Console.ReadLine();

			double precio;
			do
			{
				Console.Write("Ingrese el precio de la consulta: ");
			} while (!double.TryParse(Console.ReadLine(), out precio));




			citas[indice] = new Cita 
			{
				Num = num,
				Est = est,
				Enfermedad = enfermedad,
				Precio = precio
			};

			contadorCitas++;
			indice++;

			Console.WriteLine("Cita registrada.");
		}

		public static void Listar(Cita[] citas)
		{
			if (indice == 0)
			{
				Console.WriteLine("No hay citas registradas.");
				return;
			}

			double sPrecios = 0;
			Console.WriteLine("\n*** Lista de Citas ***");
			for (int i = 0; i < indice; i++)
			{
				Console.WriteLine(citas[i].ToString());
				sPrecios += citas[i].Precio;
			}

			Console.WriteLine($"\nSuma total de los precios: {sPrecios:C}");
		}

		public static void ModificarMasivo(Cita[] citas)
		{
			if (indice == 0)
			{
				Console.WriteLine("No hay citas registradas para modificar.");
				return;
			}

			Console.Write("Ingrese el texto a buscar en las universidades: ");
			string textoBuscar = Console.ReadLine();
			Console.Write("Ingrese el texto a reemplazar: ");
			string textoReemplazo = Console.ReadLine();

			int cambiosRealizados = 0;
			for (int i = 0; i < indice; i++)
			{
				if (citas[i].Est.Universidad.Contains(textoBuscar))
				{
					citas[i].Est.Universidad = citas[i].Est.Universidad.Replace(textoBuscar, textoReemplazo);
					cambiosRealizados++;
				}
			}

			Console.WriteLine($"Se realizaron {cambiosRealizados} cambios en las universidades.");
		}
	}
}