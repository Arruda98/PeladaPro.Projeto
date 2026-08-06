using PeladaPro.Projeto.Enum;

namespace PeladaPro.Projeto
{
    public class MonthlyPlayer : Player
    {
        public decimal MonthlyFee { get; set; }
        public MonthlyPlayer(string name, int age, PlayerPosition position, int skillLevel, decimal monthlyFee)
        : base(name, age, position, skillLevel)
        {
            this.MonthlyFee = monthlyFee;
        }

        public override decimal CalculateAmountDue(int gamesPlayed)
        {
            return MonthlyFee;
        }

        public static MonthlyPlayer PromoteFromCasual (CasualPlayer casual, decimal monthlyFee)
        {
            var promoted = new MonthlyPlayer(casual.Name, casual.Age, casual.Position, casual.SkillLevel, monthlyFee);
            promoted.Warnings = casual.Warnings;
            return promoted;
        }
    }
}
