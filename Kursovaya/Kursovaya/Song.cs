using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    [Serializable]
    class Song
    {
        private string name;
        private int duration;

        public Song() { }

        public Song(string name, int duration)
        {
            this.name = name;
            this.duration = duration;
        }

        public string Name { get => name; set => name = value; }
        public int Duration { get => duration; set => duration = value; }
    }
}
