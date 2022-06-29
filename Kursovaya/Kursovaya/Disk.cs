using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    [Serializable]
    class Disk
    {
        private string name;
        private string singer;
        private string genre;
        public List<Song> songs = new List<Song>();

        public Disk() { }

        public Disk(string name, string singer, string genre)
        {
            this.name = name;
            this.singer = singer;
            this.genre = genre;
        }

        public string Name { get => name; set => name = value; }
        public string Singer { get => singer; set => singer = value; }
        public string Genre { get => genre; set => genre = value; }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void DeleteSong(int index)
        {
            songs.RemoveAt(index);
        }


    }
}
