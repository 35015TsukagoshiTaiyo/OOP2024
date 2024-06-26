﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    internal class Program {
        static void Main(string[] args) {

            var songs = new Song[] {
                new Song("アイドル","YOASOBI",226),
                new Song("夜に駆ける","YOASOBI",262),
                new Song("群青","YOASOBI",263),
            };
            PrintSongs(songs);
        }

        private static void PrintSongs(Song[] songs) {

            foreach (var song in songs) {
                Console.WriteLine(@"{0} {1} {2:mm\:ss}",
                                        song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}
