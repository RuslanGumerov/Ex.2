using System;
using System.Threading;

namespace Ex._2
{
    class Program
    {
        static void Main()
        {
            int curr_etaj, dir_etaj, passengersNumber;
            Elevator elev = new();
            Console.WriteLine("В здании 12 этажей.");
       
        a: Console.WriteLine("Текущий этаж: ");
            curr_etaj = Convert.ToInt32(Console.ReadLine());
            if ((curr_etaj > 12) || (curr_etaj < 1))
            {
                Console.WriteLine("Ошибка. Попробуйте еще раз");
                goto a;
            }
            elev.GoesToPassenger(curr_etaj);
            Console.WriteLine($"Лифт прибыл на {elev.ElevLevel} этаж" + $"");
            Thread.Sleep(1000);
            Elevator.OpenDoor();

        b: Console.WriteLine("Сколько вас: ");
            passengersNumber = Convert.ToInt32(Console.ReadLine());
            if (passengersNumber > elev.max_pass_number)
            {
                Console.WriteLine("Перегрузка, уменьшите количество пассажиров");
                Thread.Sleep(1000);
                goto b;
            }
       
        c: Console.WriteLine("На какой этаж:");
            dir_etaj = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(1200);
            Elevator.CloseDoor();
            Thread.Sleep(1200);
            if (dir_etaj > curr_etaj)
            {
                elev.GoesUp(dir_etaj);
                Console.WriteLine($"Лифт на {elev.ElevLevel} этаже");
                Thread.Sleep(1000);
                Elevator.OpenDoor();
                Thread.Sleep(3000);
                Elevator.CloseDoor();
            }
            else if (dir_etaj < curr_etaj)
            {
                elev.GoesDown(dir_etaj);
                Console.WriteLine($"Лифт на {elev.ElevLevel} этаже");
                Thread.Sleep(1400);
                Elevator.OpenDoor();
                Thread.Sleep(3000);
                Elevator.CloseDoor();
            }
            else
            {
                Console.WriteLine("Выберите этаж");
                Thread.Sleep(1000);
                goto c;
            }
            
            Console.ReadKey();
        }
        
    }
}
