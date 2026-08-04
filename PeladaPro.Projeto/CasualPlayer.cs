using PeladaPro.Projeto.Enum;

namespace PeladaPro.Projeto
{
    public class CasualPlayer : Player
    {
        public decimal PricePerGame { get; set; }
        public CasualPlayer(string name, int age, PlayerPosition position, int skillLevel, decimal pricePerGame)
            : base (name, age, position, skillLevel)
        {
            this.PricePerGame = pricePerGame;
        }

        public override decimal CalculateAmountDue(int gamesPlayed)
        {
            return PricePerGame * gamesPlayed;
        }
    }
}
