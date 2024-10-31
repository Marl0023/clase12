using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    internal class Estudiantes
    {
        byte[] edades = new byte[0];
        int posicion = 0;
        public void insertar() {
            byte ed;
            string seguir;
            do
            {
                Console.Write("Ingrese edad: ");
                while (!byte.TryParse(Console.ReadLine(), out ed) || ed < 14 || ed > 120)
                {
                    Console.Write("Error: Ingrese edad: ");
                }
                Array.Resize(ref edades, edades.Length + 1);
                edades[posicion] = ed;
                posicion++;
                Console.WriteLine("\nEdad registrado correctamente");
                Console.WriteLine("\n Desea seguir continuando? [si]: ");
                seguir = Console.ReadLine();
            } while (seguir == "si");
        }
        public void mostrar() {
            Console.SetCursorPosition(10, 9);
            Console.Write("Posicion");
            Console.SetCursorPosition(30, 9);
            Console.Write("Edades\n");
            for (int i = 0; i < edades.Length; i++) {
                Console.SetCursorPosition(10, 10+i);
                Console.Write(i);
                Console.SetCursorPosition(30, 10+i);
                Console.Write(edades[i]);
            }
        }
        public void eliminar(byte ed)
        {
            int indice = Array.IndexOf(edades, ed);
            if (indice != -1)
            {
                for (int i = indice; i < edades.Length - 1; i++)
                {
                    edades[i] = edades[i + 1];
                }  
                Array.Resize(ref edades, edades.Length-1);
                posicion--;
                Console.WriteLine("\nEdad eliminado correctamente");
            }
            else {
                Console.WriteLine("No se puede eliminar porque no existe");
            }
        }
        public void ordenar() {
            for (int i = 0; i < edades.Length; i++) {
                for (int j = 0; j < edades.Length - 1; j++)
                {
                    if (edades[j] > edades[j + 1]) {
                        edades[j]=edades[j + 1];
                    }
                }
                
            }
            Console.WriteLine("El producto a sido ordenado");
            
        }

    }
}
