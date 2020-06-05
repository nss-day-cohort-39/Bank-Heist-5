using System;

namespace Bank_Heist_5
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        void PerformSkill(Bank bank)
        {
            //return none
        }
    }
}