using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;
using System.Text;
using System.Globalization;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Songs> songs = new List<Songs>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split("_");

                string listSongs = input[0];
                string nameSongs = input[1];
                string timeSongs = input[2];

                Songs song = new Songs(listSongs, nameSongs, timeSongs);

                songs.Add(song);
            }
            string typeListSong = Console.ReadLine();

            if (typeListSong == "all")
            {
                foreach (var item in songs)
                {
                    Console.WriteLine(item.NameSong);
                }
            }
            else
            {
                foreach (var item in songs)
                {
                    if (item.ListSong == typeListSong)//.Contains(typeListSong))
                    {
                        Console.WriteLine(item.NameSong);
                    }
                }
            }
        }
    }
}
