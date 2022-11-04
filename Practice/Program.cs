using Practice.Models;
using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Implicit-Explicit
            //Manat manat = new Manat(100);
            //Dollar dollar = manat;
            //Console.WriteLine(dollar.Usd);

            //DateTime date = DateTime.Now;
            //Console.WriteLine(date.ToString("MMMM, dd"));
            #endregion

            #region Generic list
            //StringList list = new StringList();

            //list.Add("Qoshqar");
            //list.Add("Ramil");
            //list.Add("Resul");
            //list.Add("Lale");
            //list.Add("Novreste");
            //list.Add("Nihad");

            //list.GetAll();

            //IntList ages = new IntList();

            //ages.Add(29);
            //ages.Add(25);
            //ages.Add(15);
            //ages.Add(18);
            //ages.Add(25);
            //ages.Add(27);

            //ages.GetAll();


            //BookList books = new BookList();
            //books.Add(new Book { Name = "C#" });
            //books.Add(new Book { Name = "C++" });
            //books.Add(new Book { Name = "JS" });
            //books.Add(new Book { Name = "Python" });


            //books.GetAll();


            //DataList<int> ages = new DataList<int>();

            //ages.Add(29);
            //ages.Add(25);
            //ages.Add(15);
            //ages.Add(18);
            //ages.Add(25);
            //ages.Add(27);

            //var resultages = ages.GetAll();
            //foreach (var item in resultages)
            //{
            //    Console.WriteLine(item);
            //}

            //DataList<string> list = new DataList<string>();

            //list.Add("Qoshqar");
            //list.Add("Ramil");
            //list.Add("Resul");
            //list.Add("Lale");
            //list.Add("Novreste");
            //list.Add("Nihad");

            //list.GetAll();

            //DataList<bool> marries = new DataList<bool>();

            //marries.Add(true);
            //marries.Add(false);
            //marries.Add(true);

            //marries.GetAll();

            //Repository<Regex> number1 = new Repository<Regex>();

            //Repository<int> number1 = new Repository<int>();

            //Repository<double> number2 = new Repository<double>();

            //Repository<string> name = new Repository<string>();

            //Repository<Student> student = new Repository<Student>();

            //Repository<Employee> employee = new Repository<Employee>();

            //Repository<Student,Common> student1 = new Repository<Student,Common>();

            //Repository<Employee,Common> employee1 = new Repository<Employee, Common>();

            #endregion

            #region DateTime
            //DateTime start = DateTime.Now;
            //DateTime end = DateTime.Now.AddDays(-10);

            ////Console.WriteLine($"Start Date: {start} - End Date: {end}");

            //GetProductsByDate(start, end, 1500);
            #endregion         
        }


        public static void GetProductsByDate(DateTime start, DateTime end, double price)
        {
            DateTime productDate = DateTime.Now.AddDays(-20);

            if ((productDate > start && productDate < end) && price > 1000)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

    }

    public class DataList<T>
    {
        //private T[] datas;

        //public DataList()
        //{
        //    datas = new T[0];
        //}
        //public void Add(T data)
        //{
        //    Array.Resize(ref datas, datas.Length + 1);
        //    datas[datas.Length - 1] = data;
        //}

        ////public void GetAll()
        ////{
        ////    //for (int i = 0; i < _arr.Length; i++)
        ////    //{
        ////    //    Console.WriteLine(_arr[i]);
        ////    //}

        ////    foreach (var item in datas)
        ////    {
        ////        Console.WriteLine(item);
        ////    }
        ////}

        //public T[] GetAll()
        //{
        //    return datas;
        //}
    }

    public class BookList
    {
        private Book[] _arr;

        public BookList()
        {
            _arr = new Book[0];
        }

        public void Add(Book book)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = book;
        }

        public void GetAll()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine(_arr[i].Name);
            }
        }
    }

    public class StringList
    {
        private string[] _arr;

        public StringList()
        {
            _arr = new string[0];
        }

        public void Add(string str)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = str;
        }

        public void GetAll()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }

    public class IntList
    {
            private int[] _arr;

            public IntList()
            {
                _arr = new int[0];
            }

            public void Add(int num)
            {
                Array.Resize(ref _arr, _arr.Length + 1);
                _arr[_arr.Length - 1] = num;
            }

            public void GetAll()
            {
                for (int i = 0; i < _arr.Length; i++)
                {
                    Console.WriteLine(_arr[i]);
                }
            }
    }

    public class Dollar
    {
        //public double Usd { get; set; }

        //public Dollar(double usd)
        //{
        //    Usd = usd;
        //}
    }

    public class Manat
    {
        //public double Azn { get; set; }

        //public Manat(double azn)
        //{
        //    Azn = azn;
        //}

        //public static implicit operator Dollar(Manat manat)
        //{
        //    return new Dollar(manat.Azn / 1.7);
        //}
    }
}
