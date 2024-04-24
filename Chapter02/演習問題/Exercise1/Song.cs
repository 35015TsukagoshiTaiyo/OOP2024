﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    internal class Song {

        //歌のタイトル
        public string Title { get; set; }
        //アーティスト名
        public string ArtistName { get; set; }
        //演奏時間、単位は秒
        public int Length { get; set; }

        //コンストラクタ
        public Song(string title, string artistName, int length) {
            Title = title;
            ArtistName = artistName;
            Length = length;
        }

    }
}
