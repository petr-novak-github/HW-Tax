using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax
{
    interface Inter {
        double GetTax();
    }
    // interface vytvarim proto, abych to mohl vsechno nacpat do jednoho listu, nebo pole a pres smycku yavolal metodu a spocital
    // celkovou dan
    // v tom interfacu musi byt ta metoda jinak ve smycce nezavolam na prvku kolekce typu inter

        //abstraktni tridu vytvarim proto, protoze se po me chce v zadani aby to byla trida z ktere nejde vytvorit instance
        abstract class RealEstate:Inter
        {
        public abstract double GetTax();
        }
        class House : RealEstate
        {
            public House()
            {

            }
            //dan je stanovena jako 1.27* den v mesici

            public override double GetTax() { return Convert.ToInt32(DateTime.Now.Day) * 1.27; }

        }

        class Flat : RealEstate
        {
            public Flat()
            {

            }

            public override double GetTax() { return Convert.ToInt32(DateTime.Now.DayOfYear) * 1.27; }


        }

        abstract class Vehicle:Inter
        {
        public virtual double GetTax() { return 1500; }

    }

        class Motorcycle : Vehicle
        {
            public Motorcycle()
            {

            }
                
    }

        class Car : Vehicle
        {
            public Car()
            {

            }
       
    }

        class Trolleybus : Vehicle
        {
            public Trolleybus()
            {
            }

            public override double GetTax() { return base.GetTax() * 0.9; }

        }




        class Program
        {
            static void Main(string[] args)
            {
            var h1 = new House();
            var f1 = new Flat();
            var m1 = new Motorcycle();
            var c1 = new Car();
            var t1 = new Trolleybus();

            //pouziti listu
            //List<Inter> zdanit = new List<Inter>() { h1, f1, m1, c1, t1 };
            //foreach (Inter item in zdanit) {Console.WriteLine($"{item.GetType().Name} - sazba danne: {item.GetTax()}"); }
            //pouziti pole
            Inter[] zdanit = new Inter[] { h1, f1, m1, c1, t1 };
            for (int i = 0; i < zdanit.Length; i++)
            {
                Console.WriteLine($"{zdanit[i].GetType().Name} - sazba danne: {zdanit[i].GetTax()}");
            }
            Console.ReadLine();

        }
    }
    

}

