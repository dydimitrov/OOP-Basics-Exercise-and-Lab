using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Team
{
    private string name;
    private List<Player> players;
    private double rating;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<Player> Players
    {
        get { return players; }
        set { players = value; }
    }

    public double Rating
    {
        get { return rating; }
        set { rating = value; }
    }

    public Team(string name)
    {
        this.Name = name;
        this.Players = new List<Player>();
    }

    public void Add(Player player)
    {
        players.Add(player);
    }

    public void Remove(Player player)
    {
        if (players.Contains(player))
        {
            throw new ArgumentException($"Player {player.Name} is not in {this.Name} team.");
        }
        foreach (var p in players)
        {
            if (p.Name == player.Name)
            {
                players.Remove(p);
            }
        }
    }

    public int GetRating()
    {
        double currentRating = 0 ;
        foreach (var p in players)
        {
            currentRating += p.Rating;
        }
        var countOfPlayers = players.Count;
        int result = (int)currentRating / (int)countOfPlayers;
        return result;
    }
}
