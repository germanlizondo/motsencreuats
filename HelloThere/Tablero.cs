using System;
using System.Collections.Generic;
using System.Text;

namespace HelloThere
{
  public class Tablero
    {
        private int row;
        private int column;
        private char[,] celdas;
        private String todaslasletras = "abcdefghijklmnopqrstuvwxyz".ToUpper();
      

        public Tablero(int row,int column)
        {
            this.row = row;
            this.column = column;
            this.celdas = new char[this.row, this.column];

        }

        public void crearTablero()
        {

            int rowLength = this.celdas.GetLength(0);
            int colLength = this.celdas.GetLength(1);


            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Random rnd = new Random();
                    int randomnumber = rnd.Next(0, this.todaslasletras.Length);


                    this.celdas[i, j] = this.todaslasletras[randomnumber];
                }

            }
        }
        public void dibujarTablero()
        {
            int rowLength = this.celdas.GetLength(0);
            int colLength = this.celdas.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(this.celdas[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }






        //GETTER & SETTERS
        public int Row {
            get { return this.row; }
            set { this.row = value; }
        }
        public int Column
        {
            get { return this.column; }
            set { this.column = value; }
        }

        public char[,] Celdas
        {
            get { return this.celdas; }
           
        }
    }
}
