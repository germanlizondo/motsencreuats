using System;
using System.Collections.Generic;

namespace HelloThere
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("¿Cuantas lineas quieres?\r\n");

            int row = int.Parse(Console.ReadLine());
            Console.Write("¿Cuantas columnas quieres?\r\n");
            int column = int.Parse(Console.ReadLine());


            Tablero tablero = new Tablero(row, column);

            tablero.crearTablero();
            tablero.dibujarTablero();



          
            Console.ReadLine();


        }
    }
}
