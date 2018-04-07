using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listOfSongs = new List<Song>();
            var numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                var currentSong = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var currentArtist = currentSong[0];
                var currentName = currentSong[1];
                var songDetails = currentSong[2];
                try
                {
                    if (string.IsNullOrWhiteSpace(currentArtist) || string.IsNullOrWhiteSpace(currentName) || string.IsNullOrWhiteSpace(songDetails))
                    {
                        throw new ArgumentException("Invalid song.");
                    }
                    if ((currentArtist.Length < 3 && currentName.Length < 3) || (currentArtist.Length > 20 && currentName.Length > 30))
                    {
                        throw new ArgumentException("Invalid song.");
                    }
                    
                    var length = currentSong[2].Split(':');
                    int digit1;
                    int digit2;
                    if (int.TryParse(length[0], out digit1) && int.TryParse(length[1], out digit2))
                    {
                        listOfSongs.Add(new Song(currentSong[0], currentSong[1], int.Parse(length[0]), int.Parse(length[1])));
                        Console.WriteLine("Song added.");
                    }
                    else
                    {
                        throw new ArgumentException("Invalid song length.");
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    continue;
                }
                
            }
            Console.WriteLine($"Songs added: {listOfSongs.Count}");

            int sumOfLengthOfAddedSongs = 0;

            foreach (var song in listOfSongs)
            {
                sumOfLengthOfAddedSongs += song.TotalLength;
            }
            var hoursToDisplay = sumOfLengthOfAddedSongs / 3600;
           sumOfLengthOfAddedSongs = sumOfLengthOfAddedSongs % 3600;
            var minutesToDisplay = sumOfLengthOfAddedSongs / 60;
           var secondsToDisplay = sumOfLengthOfAddedSongs % 60;

            Console.WriteLine($"Playlist length: {hoursToDisplay}h {minutesToDisplay}m {secondsToDisplay}s");
            
        }
    }
}
