using Clase12;
using System.Timers;
string regresar;
int valor=0;
byte opc = 0;
int o=0;
int espacio;
/*Console.WriteLine("Bienvenidois al sistema de registro de edades\n");
Console.Write("Ingrese cuantos valores desea ingresar:");
o = int.Parse(Console.ReadLine());
 byte[] edades = new byte[o];
for (int i = 0; i < edades.Length; i++)
{
    do
    {
        Console.Write("Ingrese el valor numero {0}: ", i);
        edades[i] = byte.Parse(Console.ReadLine());
        if (edades[i] > 14 && edades[i] < 120)
        {
            Console.WriteLine("La edad se insertó con éxito");
            break;
        }
        else
        {
            Console.WriteLine("Edad no existe en el arreglo\nPor favor vuelva a intentarlo");
        }
    } while (true);

}
*/
Estudiantes e = new Estudiantes();
do
{
    Console.WriteLine("================Menu de opciones================");
    Console.WriteLine("* 1. Insertar");
    Console.WriteLine("* 2. Mostrar");
    Console.WriteLine("* 3. Eliminar");
    Console.WriteLine("* 4. Ordenar");
    Console.WriteLine("* 0. Salir del sistema");
    Console.WriteLine("================================================");

    Console.Write("Ingrese opcion: ");
    while (!byte.TryParse(Console.ReadLine(), out opc) || opc > 4)
    {
        Console.Write("Error, Ingrese opcion: ");
    }
    switch (opc)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            e.insertar();
            break;
        case 2:
            e.mostrar();
            break;
        case 3:
            Console.WriteLine("Ingrese una edad que desea eliminar");
            byte eliminado = byte.Parse(Console.ReadLine());
            e.eliminar(eliminado);
            break;
        case 4:
            e.ordenar();
            break;
        default:
            Console.WriteLine("Opcion no valida, veulva a intentarlo");
            break;
    }
    Console.WriteLine("\n \nDesea regresar al menu de opcion? [si]: ");
    regresar = Console.ReadLine().ToLower();
    Console.Clear();
}while (regresar=="si");



