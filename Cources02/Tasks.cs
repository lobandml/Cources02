using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02
{
    static class Tasks
    {

        private static void DoubleParseInput(ref double inputvalue, string message)
        {
            do
            {
                Console.WriteLine(message);
            }
            while (!Double.TryParse(Console.ReadLine(), out inputvalue));
        }

       public static void Task1()
        {
            Address StudentHouse = new Address("47000", "Украина", "Днепропетровск", "Пушкина", "1", "1");
            StudentHouse.PostIndex = "9000";
            Console.WriteLine(StudentHouse.ToString());

        }
        public static void Task2()
        {
            double FirstSide=0.0;
            double SecondSide=0.0;
            DoubleParseInput(ref FirstSide, "Введите первую сторону");
            DoubleParseInput(ref SecondSide, "Введите вторую сторону");
            
            Recktangle TestRecktangle = new Recktangle(FirstSide, SecondSide);
            Console.WriteLine("Площадь равна "+TestRecktangle.Area.ToString());
            Console.WriteLine("Периметр равен " + TestRecktangle.Perimeter.ToString());

        }
        public static void Task3()
        {
            Library.Book TestBook=new Library.Book(new Library.Author("Author"),new Library.Content("Content"),new Library.Title("Title"));
            TestBook.Show();
        }
        public static void Task4()
        {

            Figures.Point[] points = new Figures.Point[5];

            points[0] = new Figures.Point(0, 0, "A");
            points[1] = new Figures.Point(3, 1, "B");
            points[2] = new Figures.Point(3, 2, "C");
            points[3] = new Figures.Point(2, 3, "D");
            points[4] = new Figures.Point(1, 1, "E");

            Figures.Figure rectangle = new Figures.Figure( points[0],points[1], points[2], points[3], points[4]);
            Console.WriteLine("Многоугольник = " + rectangle.ToString());
            Console.WriteLine("Периметр многоугольника = " + rectangle.PerimeterCalculator());
            
            

        }
        public static void Task5()
        {
            User user = new User("oleg.lobanov", "Oleg", "Lobanov", 19, new DateTime(2016, 2, 5));
            Console.WriteLine(user.ToString());
        }
        public static void Task6()
        {
            Converter TemporaryConverter=new Converter(27.234,30.200, 0.33);
            Console.WriteLine(TemporaryConverter.ToAnother("UsD",300));
        }
        public static void Task7()
        {
            Employee OneOfUs = new Employee("Василий", "Иванов");
            OneOfUs.Work = "консультант";
            OneOfUs.Time = 4;
            Console.WriteLine(OneOfUs.ToString());
            Console.WriteLine(OneOfUs.GetMoneys());
            Console.WriteLine(OneOfUs.Tax());
        }
        public static void Task8()
        {
            Invoice TestInvoice=new Invoice(777,"Oleg","Something","Nmae",3,34.8);
            Console.WriteLine("с НДС = " + TestInvoice.OfferPrice(true).ToString());
            Console.WriteLine("без НДС = " + TestInvoice.OfferPrice(false).ToString());

        }
    }
}
