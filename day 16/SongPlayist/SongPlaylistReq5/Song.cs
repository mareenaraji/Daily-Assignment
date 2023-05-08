using System;
using System.Collections.Generic;

namespace SongPlaylistReq5
{
    class Song
    {
        private string _name;
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        private string _artist;
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        private string _songType;
        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }
        }
        private DateTime _dateDownloaded;
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set { _dateDownloaded = value; }
        }
        private double _rating;
        public double Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
            }
        }
        private int _numberOfDownloads;
        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set
            {
                _numberOfDownloads = value;
            }
        }
        public Song()
        {

        }
        public Song(string name, string artist, string songType
            , double rating,  int numberOfDownloads, DateTime dateDownloaded)
        {
            Name = name;       
            Artist = artist;
            SongType = songType;
            DateDownloaded = dateDownloaded;
            Rating = rating;         
            NumberOfDownloads = numberOfDownloads;
        }
        public static SortedDictionary<string,int>CalculateTypeCount(List<Song> list)
        {
            SortedDictionary<string,int> sd1=new SortedDictionary<string,int>();
            foreach(var item in list)
            {
                if (sd1.ContainsKey(item.SongType))
                {
                    sd1[item.SongType]++;
                }
                else
                {
                    sd1.Add(item.SongType, 1);
                }
            }
            return sd1;
        }
    }
}
