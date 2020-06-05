using System;
using System.Collections.Generic;

namespace Bank_Heist_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>();

            var drew = new Hacker()
            {
                Name = "Drew",
                SkillLevel = 40,
                PercentageCut = 20
            };

            var Steve = new Hacker()
            {
                Name = "Steve",
                SkillLevel = 40,
                PercentageCut = 20
            };

            var Shady = new Muscle()
            {
                Name = "Shady",
                SkillLevel = 40,
                PercentageCut = 20
            };

            var drPhilipew = new LockSpecialist()
            {
                Name = "Philip",
                SkillLevel = 40,
                PercentageCut = 20
            };

            var Tyler = new Muscle()
            {
                Name = "Tyler",
                SkillLevel = 40,
                PercentageCut = 20
            };

            rolodex.Add(Tyler);

            while (true)
            {
                Console.WriteLine("Choose robber name");
                string name = Console.ReadLine();

                Console.WriteLine("choose specialty");
                Console.WriteLine("1.Hacker");
                Console.WriteLine("2.Lockspecialist");
                Console.WriteLine("3.Muscle");
                int specialty = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Choose percentage");
                int percentage = Int32.Parse(Console.ReadLine());

                Console.WriteLine("choose skill level");
                int skillLevel = Int32.Parse(Console.ReadLine());

                string userSelect = Console.ReadLine();

                if (userSelect == "1")
                {
                    var hacker = new Hacker()
                    {
                    Name = name,
                    SkillLevel = skillLevel,
                    PercentageCut = percentage
                    };
                    Console.WriteLine($"Your name is {name}, your specialty is {skillLevel}, you get {percentage} percent.");
                }
                else if (userSelect == "2")
                {
                    var lockspecialist = new LockSpecialist()
                    {
                    Name = name,
                    SkillLevel = skillLevel,
                    PercentageCut = percentage
                    };
                    Console.WriteLine($"Your name is {name}, your specialty is {skillLevel}, you get {percentage} percent.");
                }
                else if (userSelect == "3")
                {
                    var muscle = new Muscle()
                    {
                    Name = name,
                    SkillLevel = skillLevel,
                    PercentageCut = percentage
                    };
                    Console.WriteLine($"Your name is {name}, your specialty is {skillLevel}, you get {percentage} percent.");
                }
                else if (userSelect == "")
                {
                    Console.WriteLine($"Your name is {name}, your specialty is {skillLevel}, you get {percentage} percent.");
                    break;
                }
            }
        }
    }
}