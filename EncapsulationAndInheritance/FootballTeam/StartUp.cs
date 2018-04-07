using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    static void Main(string[] args)
    {
        var currentPlayer = new Player(" Pesho", 75, 85, 84, 92, 67);
        var currentTeam = new Team("Pesho");
        currentTeam.Add(currentPlayer);
        currentTeam.GetRating();
        Console.ReadKey();
    }
}