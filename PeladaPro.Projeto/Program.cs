using PeladaPro.Projeto;
using PeladaPro.Projeto.Enum;

namespace Pelada.Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            var team = new Team("Pelada do Cobaia");

            team.AddPlayer(new MonthlyPlayer(name: "Jefferson", age: 27, position: PlayerPosition.Forward, skillLevel: 7, monthlyFee: 80m));
            team.AddPlayer(new CasualPlayer(name: "Pirlo", age: 29, position: PlayerPosition.Midfielder, skillLevel: 8, pricePerGame: 15m));

            Console.WriteLine($"Time: {team.Name}");

            foreach (var player in team.Players)
                Console.WriteLine($"- {player.Name} ({player.Position})");
        }
    }
}