using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Kursach
{
    class Serialization
    {
        public static void Serialisation(Dictionary<int, Clients> cl, List<Books> b)
        {
            DataContractJsonSerializer F_Clients = new DataContractJsonSerializer(typeof(Dictionary<int, Clients>));
            using (FileStream fs1 = new FileStream("clients.json", FileMode.Create))
            {
                F_Clients.WriteObject(fs1, cl);
            }
            F_Clients = new DataContractJsonSerializer(typeof(List<Books>));
            using (FileStream fs2 = new FileStream("books.json", FileMode.Create))
            {
                F_Clients.WriteObject(fs2, b);
            }
        }
        public static (Dictionary<int, Clients>, List<Books>) Deserialize()
        {
            DataContractJsonSerializer F_Clients = new DataContractJsonSerializer(typeof(Dictionary<int, Clients>));
            Dictionary<int, Clients> new_client;
            using (FileStream fs1 = new FileStream("clients.json", FileMode.OpenOrCreate))
            {
                new_client = (Dictionary<int, Clients>)F_Clients.ReadObject(fs1);
            }
            F_Clients = new DataContractJsonSerializer(typeof(List<Books>));
            List<Books> new_book;

            using (FileStream fs2 = new FileStream("books.json", FileMode.OpenOrCreate))
            {
                new_book = (List<Books>)F_Clients.ReadObject(fs2);
            }
            return (new_client, new_book);
        }

    }
}