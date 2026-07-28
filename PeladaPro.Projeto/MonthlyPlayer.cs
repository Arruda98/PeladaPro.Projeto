using PeladaPro.Projeto.Enum;

namespace PeladaPro.Projeto
{
    internal class MonthlyPlayer : Player
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

    }
}
