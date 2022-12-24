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
    class Recordings
    {
        private DateTime taking_book;
        private DateTime returning_book;
        private Books book;
        private bool isAvailable;

        public static void Is_Data_Valide(DateTime taking_book, DateTime returning_book)
        {
            if (returning_book < taking_book)
            {
                DateTime time = taking_book;
                taking_book = returning_book;
                returning_book = time;
            }
        }

        public Recordings(DateTime taking_book, DateTime returning_book, Books book)
        {
            this.taking_book = taking_book;
            this.returning_book = returning_book;
            this.book = book;
            this.isAvailable = false;
        }

        public Books Books
        {
            get { return book; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public override string ToString()
        {
            return string.Format("Дата взятия книги: {0}  Дата возврата книги: {1} Книга: {2} ", taking_book.ToShortDateString(), returning_book.ToShortDateString(), book);
        }
    }
}