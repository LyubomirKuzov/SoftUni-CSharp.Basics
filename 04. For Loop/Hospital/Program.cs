using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysPeriod = int.Parse(Console.ReadLine());

            int treatedPatients = 0;
            int untreatedPatients = 0;
            int doctorsCount = 7;

            for (int i = 0; i < daysPeriod; i++)
            {
                int newPatients = int.Parse(Console.ReadLine());

                if ((i + 1) % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        doctorsCount++;
                    }
                }

                if (newPatients <= doctorsCount)
                {
                    treatedPatients += newPatients;
                }

                else
                {
                    treatedPatients += doctorsCount;
                    newPatients -= doctorsCount;
                    untreatedPatients += newPatients;
                }
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
