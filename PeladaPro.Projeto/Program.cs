using PeladaPro.Projeto;
using PeladaPro.Projeto.Enum;

namespace Pelada.Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            var casualPlayer = new CasualPlayer(
                name: "Jefferson",
                age: 28,
                position: PlayerPosition.Midfielder,
                skillLevel: 7,
                pricePerGame: 45.00m
            );

            Console.WriteLine($"{casualPlayer.Name} - Valor por jogo: R$ {casualPlayer.PricePerGame}");
        }
    }
}