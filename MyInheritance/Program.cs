using System;

namespace MyInheritance
{
    public class Intec
    {
        public string naam { get; set; }
        public int age { get; set; }

        public double btw = 21;
        public int x;                               //300 700 200 (zie in main)                    

        public Intec(int a)                         //300 700 200 (zie in main)             
        {
            x = a;
        }

        public void ToonIntec()
        {
            Console.WriteLine("Ik ben de parent Intec");
        }
    }

    public class Leerling : Intec                   //  : maakt inhetirance
    {
        public int leerjaar { get; set; }
        public int rapport { get; set; }
        public Leerling(int x) : base(x)     //constructor            //base stuurt nodige parameters van child naar parent class
        {
            Console.WriteLine("Test Leerling van Intec");
        }

        public void ToonLeerlingIntec()
        {
            Console.WriteLine("Ik ben Leerling van parent Intec");
        }

        public override string ToString()
        {
            //btw = 3;
            // return base.ToString();
            Console.WriteLine();
            string s = $"Leerling: {naam} age: {age} BTW: {btw}%    Dit is mijn versie(override)\n";
            Console.WriteLine();
            return s;
        }
    }

    public class Leerkracht : Intec                  //  : maakt inhetirance
    {
        public string vak { get; set; }

        public Leerkracht(int x) : base(x)    //constructor              //base stuurt nodige parameters van child naar parent class
        {
            Console.WriteLine("Test Leerkracht van Intec");
        }

        public void ToonLeerkrachtIntec()
        {
            Console.WriteLine("Ik ben Leerkracht van parent Intec");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Leerkracht It = new Leerkracht(300);
            It.naam = "Kenan";
            It.age = 45;
            It.vak = "C scharp";
            Console.WriteLine($"Leerkracht: {It.naam} geeft {It.vak}");
            Console.WriteLine(It.ToString());
            Console.WriteLine(It.x);
            Console.WriteLine();

            Leerling Id77 = new Leerling(700);
            Id77.naam = "Mauritius";
            Id77.age = 25;
            Id77.leerjaar = 3;
            Id77.rapport = 75;
            Console.WriteLine($"\n{Id77} {Id77.naam} is {Id77.age} oud. \n" +
                $"volgt les in het {Id77.leerjaar} en haalt rapport {Id77.rapport}%");
            Console.WriteLine(Id77.x);
            Console.WriteLine();
            Console.WriteLine(Id77.ToString());


            Leerling Id88 = new Leerling(200);
            Console.WriteLine(Id88.x);
            Console.WriteLine(Id88.btw);

            Console.WriteLine();
            Console.WriteLine(Id88.GetType());
            Console.WriteLine();
            Console.WriteLine(Id88.ToString());
        }
    }
}
