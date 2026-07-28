using PeladaPro.Projeto;
using PeladaPro.Projeto.Enum;

namespace Pelada.Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogadores = new List<Player>
            {
                new MonthlyPlayer(name: "Jefferson", age: 28, position: PlayerPosition.Forward, skillLevel: 7, monthlyFee: 80m),
                new CasualPlayer(name: "Pirlo", age: 29, position: PlayerPosition.Forward, skillLevel: 9, pricePerGame: 15m),
                new MonthlyPlayer(name: "Bola", age: 28, position: PlayerPosition.Midfielder, skillLevel: 4, monthlyFee: 80m),
            };

            Console.WriteLine("Antes de ordenar:");
            foreach (var jogador in jogadores)
                Console.WriteLine($"{jogador.Name} - nível {jogador.SkillLevel}");

            jogadores.Sort();

            Console.WriteLine("\nDepois de ordenar:");
            foreach (var jogador in jogadores)
                Console.WriteLine($"{jogador.Name} - nível {jogador.SkillLevel}");
        }
    }
}