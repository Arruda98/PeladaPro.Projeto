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
            
            var pirlo = new CasualPlayer(name: "Pirlo", age: 29, position: PlayerPosition.Midfielder, skillLevel: 8, pricePerGame: 15m);
            team.AddPlayer(pirlo);

            Console.WriteLine("Antes da promoção");
            foreach (var p in team.Players)
                Console.WriteLine($"- {p.Name} ({p.GetType().Name})");

            team.PromotePlayer(pirlo, monthlyFee: 80m);

            Console.WriteLine("\nDepois da promoção: ");
            foreach(var p in team.Players)
                Console.WriteLine($"- {p.Name} ({p.GetType().Name})");
            
        }
    }
}