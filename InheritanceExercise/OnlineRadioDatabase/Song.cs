using System;
public class Song
{
    private string artist;
    private string name;
    private int minutes;
    private int seconds;
    private int totalLength;

    //const for max length of track in seconds 
    private const int MaxLengthOfTrack = 899;

    public Song(string artist, string name, int minutes, int seconds)
    {
        this.Artist = artist;
        this.Name = name;
        this.Minutes = minutes;
        this.Seconds = seconds;
        SetTotalLength();
    }
    public string Artist
    {
        get { return artist; }
        set
        {
            if (value.Length<3 || value.Length>20)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            artist = value;
        }
    }
    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Song name should be between 3 and 20 symbols.");
            }
            name = value;
        }
    }
    public int Minutes
    {
        get { return minutes; }
        set
        {
            if (value<0 || value>14)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }
            minutes = value;
        }
    }
    public int Seconds
    {
        get { return seconds; }
        set
        {
            if (value<0 || value>59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }
            seconds = value;
        }
    }
    public int TotalLength
    {
        get { return totalLength; }
        set { totalLength = value; }
    }
    public void SetTotalLength()
    {
        if ((this.Minutes * 60 + this.Seconds)<=0 || (this.Minutes * 60 + this.Seconds)> MaxLengthOfTrack)
        {
            throw new ArgumentException("Invalid song length.");
        }
        this.TotalLength = this.Minutes * 60 + this.Seconds;
    }

}