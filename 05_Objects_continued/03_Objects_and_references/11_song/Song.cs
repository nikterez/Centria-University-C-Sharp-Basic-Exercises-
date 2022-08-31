using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_011_song
{
    public class Song
    {
        public string songArtist;
        public string songName;
        public int songDuration;

        public Song(string artist, string name, int duration)
        {
            this.songArtist = artist;
            this.songName = name;
            this.songDuration = duration;
        }

        public override bool Equals(Object compared)
        {
            if (this == compared)
            {
                return true;
            }

            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }
            Song comparedSong = (Song)compared;

            if (this.songArtist == comparedSong.songArtist &&
            this.songName == comparedSong.songName &&
            this.songDuration == comparedSong.songDuration)
            {
                return true;
            }
            return false;
        }




    }
}