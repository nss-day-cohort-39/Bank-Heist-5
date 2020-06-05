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
        }
    }
}