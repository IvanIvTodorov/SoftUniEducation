using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Song
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> music = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("_");

                string type = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song();

                song.Type = type;
                song.Name = name;
                song.Time = time;

                music.Add(song);                
            }

            string last = Console.ReadLine();


            List<Song> filtered = music
                .Where(n => n.Type == last)
                .ToList();
            if (last == "all")
            {
                foreach (Song item in music)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (Song item in filtered)
                {
                    Console.WriteLine(item.Name);
                }
            }
            
        }
    }
}
