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
			// Verificar espacio disponible
			if (indice >= citas.Length)
			{
				Console.WriteLine("No se pueden agregar más citas. Espacio lleno.");
				return;
			}

			// Solicitar datos del estudiante
			Console.Write("Ingrese el código del estudiante: ");
			int codigo = int.Parse(Console.ReadLine());
			Console.Write("Ingrese el nombre del estudiante: ");
			string nomb = Console.ReadLine();
			Console.Write("Ingrese la universidad del estudiante: ");
			string uni = Console.ReadLine();
			Estudiante est = new Estudiante(codigo, nomb, uni);

			// Generar automáticamente el número de cita
			int num = contadorCitas;
			Console.Write("Ingrese la enfermedad del estudiante: ");
			string enfermedad = Console.ReadLine();
			Console.Write("Ingrese el precio de la consulta: ");
			double precio = double.Parse(Console.ReadLine());

			// Crear la cita directamente en el arreglo
			citas[indice] = new Cita 
			{
				Num = num,
				Est = est,
				Enfermedad = enfermedad,
				Precio = precio
			};

			contadorCitas++;
			indice++;

			Console.WriteLine("Cita agregada exitosamente.");
		}

		public static void Listar(Cita[] citas)
		{
			if (indice == 0)
			{
				Console.WriteLine("No hay citas registradas.");
				return;
			}

			double sumaPrecios = 0;
			Console.WriteLine("\n=== Lista de Citas ===");
			for (int i = 0; i < indice; i++)
			{
				Console.WriteLine(citas[i].ToString());
				sumaPrecios += citas[i].Precio;
			}

			Console.WriteLine($"\nSuma total de los precios: {sumaPrecios:C}");
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
			Console.Write("Ingrese el texto de reemplazo: ");
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