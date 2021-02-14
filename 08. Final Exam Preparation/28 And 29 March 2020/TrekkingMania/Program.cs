using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());

            int totalPeople = 0;
            int musala = 0;
            int monblan = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int g = 0; g < groupsCount; g++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                totalPeople += peopleInGroup;

                if (peopleInGroup <= 5)
                {
                    musala += peopleInGroup;
                }

                else if (peopleInGroup <= 12)
                {
                    monblan += peopleInGroup;
                }

                else if (peopleInGroup <= 25)
                {
                    kilimanjaro += peopleInGroup;
                }

                else if (peopleInGroup <= 40)
                {
                    k2 += peopleInGroup;
                }

                else if (peopleInGroup > 40)
                {
                    everest += peopleInGroup;
                }
            }

            Console.WriteLine($"{(double)musala / totalPeople * 100:f2}%");
            Console.WriteLine($"{(double)monblan / totalPeople * 100:f2}%");
            Console.WriteLine($"{(double)kilimanjaro / totalPeople * 100:f2}%");
            Console.WriteLine($"{(double)k2 / totalPeople * 100:f2}%");
            Console.WriteLine($"{(double)everest / totalPeople * 100:f2}%");
        }
    }
}
