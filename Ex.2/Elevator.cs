using System;
using System.Threading;

namespace Ex._2
{
    class Elevator
    {
        private int elev_lev;
        public int ElevLevel
        {
            get { return elev_lev; }
            set { elev_lev = value; }
        }
        public int max_pass_number;

        public Elevator()
        {
            ElevLevel = elev_lev;
            max_pass_number = 8;
        }

        public void GoesToPassenger(int passLevel)
        {
            int diff = 0;
            if ((ElevLevel - passLevel) > 0)
            {
                diff = ElevLevel - passLevel;
            }
            if ((ElevLevel - passLevel) < 0)
            {
                diff = (ElevLevel - passLevel) * (-1);
            }
            for (int i = 1; i <= diff; i++)
            {
                Console.WriteLine($"В пути... {i} этаж");
                Thread.Sleep(1000);
                ElevLevel = i;
            }
        }

        public void GoesUp(int dirLevel)
        {
            for (int i = (ElevLevel + 1); i <= dirLevel; i++)
            {
                Console.WriteLine($"Поднимаюсь на {i} этаж");
                Thread.Sleep(1000);
            }
            ElevLevel = dirLevel; 
        }

        public void GoesDown(int dirLevel)
        {
            for (int i = ElevLevel; i >= dirLevel; i--)
            {
                Console.WriteLine($"Опускаюсь на {i} этаж");
                Thread.Sleep(1000);
            }
            ElevLevel = dirLevel;
        }

        public static void OpenDoor()
        {
            Console.WriteLine("Двери открываются");
        }
       
        public static void CloseDoor()
        {
            Console.WriteLine("Двери закрываются");
        }
    }
}
