using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            Dictionary<int, Clients> cl = new Dictionary<int, Clients>();
            List<Books> b = new List<Books>();
            //var tuple = Serialization.Deserialize();
            //cl = tuple.Item1;
            //b = tuple.Item2;


            DateTime d_p_1 = new DateTime(1994, 1, 1);
            Books book1 = new Books(1, "Мастер и Маргарита", "М.А.Булгаков", d_p_1, 9);
            Clients client_1 = new Clients("Алеся", "Ананко", "S001", Roles.STUDENT);
            cl.Add(1, client_1);
            b.Add(book1);

            DateTime d_p_2 = new DateTime(1999, 1, 1);
            Books book2 = new Books(2, "Гордость и предубеждение", "Д.Остен", d_p_2, 9);
            Clients client_2 = new Clients("Вера", "Коноз", "S002", Roles.STUDENT);
            cl.Add(2, client_2);
            b.Add(book2);


            DateTime d_p_3 = new DateTime(2000, 1, 1);
            Books book3 = new Books(3, "Мультиплатформенная разработка на C#", "Хокинг", d_p_3, 9);

            DateTime d_p_4 = new DateTime(2009, 1, 1);
            Books book4 = new Books(4, "C#. Программирование на языке высокого уровня", "T.A.Павловская", d_p_4, 9);

            Clients client_3 = new Clients("Ольга", "Урбан", "T001", Roles.TEACHER);
            cl.Add(3, client_3);
            b.Add(book3);
            b.Add(book4);

            DateTime d_p_5 = new DateTime(2019, 1, 1);
            Books book5 = new Books(5, "Программное управление технологическими комплексами", "С.О.Новиков", d_p_5, 9);
            DateTime d_p_6 = new DateTime(2009, 1, 1);
            Books book6 = new Books(6, "C#. Программирование на языке высокого уровня", "T.A.Павловская", d_p_6, 8);
            Clients client_4 = new Clients("Анна", "Карканица", "T002", Roles.TEACHER);
            cl.Add(4, client_4);
            b.Add(book5);
            b.Add(book6);


            DateTime d_p_7 = new DateTime(1796, 1, 1);
            Books book7 = new Books(7, "Беднаялиза", "Н.М.Карамзин", d_p_7, 9);
            Clients client_5 = new Clients("Алексей", "Кот", "S003", Roles.STUDENT);
            cl.Add(5, client_5);
            b.Add(book7);


            DateTime d_p_8 = new DateTime(2020, 1, 1);
            Books book8 = new Books(8, "Философия Java", "Эккель", d_p_8, 9);
            Clients client_6 = new Clients("Александр", "Николоёнок", "S004", Roles.STUDENT);
            cl.Add(6, client_6);
            b.Add(book8);


            DateTime d_p_9 = new DateTime(2020, 1, 1);
            Books book9 = new Books(9, "Изучаем C#", "Стиллмен", d_p_9, 9);
            Clients client_7 = new Clients("Михаил", "Токарев", "S005", Roles.STUDENT);
            cl.Add(7, client_7);
            b.Add(book9);

            Books book10 = new Books(10, "Технология разработки программного обеспечения", "Брауде", new DateTime(1985, 2, 1), 9);
            Clients client_8 = new Clients("Елена", "Банюкевич", "T003", Roles.TEACHER);
            cl.Add(8, client_8);
            b.Add(book10);


            Clients client_9 = new Clients("Валерия", "Дубовик", "S006", Roles.STUDENT);
            cl.Add(9, client_9);

            //Books book12 = new Books(12, "Изучаем C#", "Стиллмен", new DateTime(2005, 10, 12), 8, 2, 120);
            Clients client_10 = new Clients("Максим", "Бирило", "S007", Roles.STUDENT);
            cl.Add(10, client_10);
            //b.Add(book12);
            Serialization.Serialisation(cl, b);
            Serialization.Deserialize();


            Library library = new Library(cl, b);


            Library.Get_Book(client_1, book1);
            Library.Get_Book(client_2, book2);
            Library.Get_Book(client_3, book3);
            Library.Get_Book(client_3, book4);
            Library.Get_Book(client_4, book5);
            Library.Get_Book(client_4, book6);
            Library.Get_Book(client_5, book7);
            Library.Get_Book(client_6, book8);
            Library.Get_Book(client_7, book9);
            Library.Get_Book(client_9, book9);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
            library.SerializeResult();
        }
    }

}    
