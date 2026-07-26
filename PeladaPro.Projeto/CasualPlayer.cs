using PeladaPro.Projeto.Enum;

namespace PeladaPro.Projeto
{
    internal class CasualPlayer : Player
    {
        public decimal PricePerGame { get; set; }
        public CasualPlayer(string name, int age, PlayerPosition position, int skillLevel, decimal pricePerGame)
            : base (name, age, position, skillLevel)
        {
            this.PricePerGame = pricePerGame;
        }
    }
}
