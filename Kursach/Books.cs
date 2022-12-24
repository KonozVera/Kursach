using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    [Serializable]
    public class Books
    {
        private int key;
        public string name { get; }
        public string author { get; }
        public DateTime date_of_publishing { get; }
        private int number_of_copies;
        //private int kol_vo_vzyat;
        //private int kol_vo_vsego;

        public Books(int key, string name, string author, DateTime date_of_publishing, int number_of_copies/*, int kol_vo_vzyat, int kol_vo_vsego*/)
        {
            this.key = key;
            this.name = name;
            this.author = author;
            this.date_of_publishing = date_of_publishing;
            this.number_of_copies = number_of_copies;
            //this.kol_vo_vzyat = kol_vo_vzyat;
            //this.kol_vo_vsego = kol_vo_vsego;
        }

        public static bool Is_Book_Inf_Valide(int number_of_copies)
        {
            if (number_of_copies <= 0) return false;
            return true;
        }

        public string Name { get { return name; } } 
        public int Number_of_copies
        {
            get { return number_of_copies; }
            set { number_of_copies = value; }
        }

        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        //public int Kol_vo_vzyat
        //{
        //    get { return kol_vo_vzyat; }
        //    set { kol_vo_vzyat = value; }
        //}

        //public int Kol_vo_vsego
        //{
        //    get { return kol_vo_vsego; }
        //    set { kol_vo_vsego = value; }
        //}


        public override string ToString()
        {
            return string.Format("Номер:{0} Название:{1} Автор:{2} Дата публикации:{3}, Количество оставшихся книг {4}", key, name, author, date_of_publishing.ToShortDateString(), number_of_copies);
        }
        
    }
}