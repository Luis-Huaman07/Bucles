using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i =3; i>0; i--)
            {
                Console.Clear();
                Console.WriteLine("**"+i+"**");
                Console.Beep(900,600);
                Thread.Sleep(1000);
            }
            /*Un programa que pida las notas de n alumnos y muestre el promedio grupal, el número de aprobados y desaprobados.*/
            Console.Write("Ingrese N° de estudiantes a evaluar: ");
            int numero= int.Parse(Console.ReadLine());
            int aprobados=0, desaprobados = 0;
            //**   +=2 -- -=
            for (int i = 0; i < numero; i++) //repetitiva = interativa
            { //i=0 , 0<3
                Console.WriteLine("Ingrese Nota: ");
                float nota = float.Parse(Console.ReadLine());
                
                if (nota >= 11.5) 
                {
                    aprobados++;
                }
                else 
                {
                    desaprobados++;
                }
                
            }
            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Desaprovados: " + desaprobados);
            Console.WriteLine("FIN");

        }
    }
}
