
using Citas_médicas;

int maxCitas = 100;
Cita[] citas = new Cita[maxCitas];

int opcion;

do
{
	Console.WriteLine("*************************");
	Console.WriteLine("* BIENVENIDO ESTUDIANTE *");
	Console.WriteLine("* 1. Crear              *");
	Console.WriteLine("* 2. Listar             *");
	Console.WriteLine("* 3. Modifica Masivo    *");
	Console.WriteLine("* 4. Fin                *");
	Console.WriteLine("*************************");

	Console.WriteLine("Elija una opción");
	opcion = int.Parse(Console.ReadLine());

	switch (opcion)
	{
		case 1:
			CitaUtil.Crear(citas);
			Console.Clear();
			break;
		case 2:
			CitaUtil.Listar(citas);
			break;
		case 3:
			CitaUtil.ModificarMasivo(citas);
			break;
		case 4:
			Console.WriteLine("Saliendo del programa...");
			break;
		default:
			Console.WriteLine("Opción inválida. Intente de nuevo.");
			break;
	}

	Console.WriteLine(); 
	
} while (opcion != 4);

Console.WriteLine("Programa finalizado.");

