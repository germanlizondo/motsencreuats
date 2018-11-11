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
            char[] rows =new char[row];
            char[] columns = new char[column];


        
            String word = "HELLO";

            Random rnd = new Random();
            int randomnumber = rnd.Next(0,row);

            char[] arrayword = word.ToCharArray();

            foreach (char i in arrayword)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine(randomnumber);

            Console.WriteLine(arrayword[1]);

            for (int x=0;x < row; x++)
            {
              
                if (x == randomnumber)
                {
                    rows[x] = arrayword[1];
                }
                else { rows[x] = (char)x; }
                
            }

            for (int x = 0; x < column; x++)
            {
                columns[x] = (char)x;
            }






            foreach (int y in rows)
            {
              
            foreach (int x in columns)
            {
                System.Console.Write(" " + rows[x]);
            }
            System.Console.Write("\r\n");
            }
            Console.ReadLine();
        }
    }
}
