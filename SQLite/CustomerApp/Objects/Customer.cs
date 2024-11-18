﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CustomerApp.Objects {
    public class Customer {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 電話番号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 住所
        /// </summary>
        public string Address { get; set; }

        public string PictureImage { get; set; }

        public override string ToString() {
            return string.Format("{0} {1} {2} {3}", Id, Name, Phone,Address);
            //return $"{Id} {Name} {Phone} {Address}";
        }
    }
}
