// See https://aka.ms/new-console-template for more information
using System;
using TicTacToe.Models;

Board TableMap = new Board();
Player PlayerOne = new Player('X',"Juan");
Player PlayerTwo = new Player('O', "Carlos");


int pos = 1;
while (TableMap.WhoIsTheWinner()==" ")
{
    Console.WriteLine("Ingrese un numero");
    if (TableMap.Turns % 2 == 0)
    {

        pos=Convert.ToInt32(Console.ReadLine());
        PlayerOne.Mark(pos, TableMap);
    
        
    }
    else
    {
        pos = Convert.ToInt32(Console.ReadLine());
        PlayerTwo.Mark(pos, TableMap);
               
    }
    


    TableMap.Draw();
    Console.WriteLine("Ganador: "+ TableMap.WhoIsTheWinner());
    
}

