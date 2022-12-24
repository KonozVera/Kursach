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
    class Library
    {
        private static Dictionary<int, Clients> clients;
        private static List<Books> books;
        public Library(Dictionary<int, Clients> clients1, List<Books> books1)
        {
            clients = clients1;
            books = books1;

        }

        public static List<Books> Books
        {
            get
            {
                return books;
            }
        }
        public static void Add_Book(int key, string name, string author, DateTime date_of_publishing, int number_of_copies/*, int kol_vo_vsego, int kol_vo_vzyat*/)
        {
            Books book = new Books(key, name, author, date_of_publishing, number_of_copies/*, kol_vo_vsego, kol_vo_vzyat*/);
            Books.Add(book);
        }
        public static void Delete_Book(int key)
        {
            for (int j = 0; j < books.Count; j++)
            {
                if (books[j].Key == key)
                {
                    if (books[j].Number_of_copies == 1)
                    {
                        Books.Remove(books[j]);
                    }
                    else
                    {
                        books[j].Number_of_copies--;
                    }

                    break;
                }
            }

        }

        public static void Add_To_Library(Dictionary<int, Clients> clients, int key, Clients client)
        {
            if (!clients.ContainsKey(key)) clients.Add(key, client);
        }

        public static bool Get_Book(Clients client, Books book)
        {
            DateTime taking_book = DateTime.Today;
            DateTime returning_book1;

            if (client.Role == Roles.STUDENT)
            {
                returning_book1 = taking_book.AddMonths(1);
            }
            else
            {
                returning_book1 = taking_book.AddYears(1);
            }

            foreach (var book1 in books)
            {
                if (book.Key == book1.Key)
                {
                    Recordings recording = new Recordings(returning_book1, taking_book, book);
                    client.Carta.Recordings.Add(recording);
                    //book.Kol_vo_vzyat += 1;
                    if (book.Number_of_copies != 0) { book.Number_of_copies -= 1; }
                    return true;
                }
            }

            return false;
        }

        public static Clients GetClient(string login)
        {
            foreach (var client in clients)
            {
                if (client.Value.Carta.Number.Equals(login))
                {
                    return client.Value;
                }
            }

            return null;
        }
        public static void Pass_Book(Books books, Clients client)
        {
            DateTime returning_book = DateTime.Today;
            foreach (var book1 in Library.books)
            {
                if (clients.ContainsKey(books.Key))
                {

                    if (books.Key == book1.Key)
                    {
                        books.Number_of_copies += 1;
                        foreach (var recording in client.Carta.Recordings)
                        {
                            if (recording.Books.Name.Equals(books.Name))
                            {
                                recording.IsAvailable = true;
                            }
                        }
                    }
                }
            }
        }

        public void SerializeResult()
        {
            Serialization.Serialisation(clients, books);
        }
    }
}