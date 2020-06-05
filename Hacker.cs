using System;

namespace Bank_Heist_5
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has unlocked the vault");

            }
            else
            {
                Console.WriteLine($"{Name} is picking a lock to the vault. decrease security vault by {SkillLevel} points");
            }
        }
    }
}