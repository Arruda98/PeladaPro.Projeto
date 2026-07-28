using PeladaPro.Projeto;
using PeladaPro.Projeto.Enum;

namespace Pelada.Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            var monthly = new MonthlyPlayer(name: "Carlos", age: 28, position: PlayerPosition.Midfielder, skillLevel: 7, monthlyFee: 80m);
            var casual = new CasualPlayer(name: "Jefferson", age: 28, position: PlayerPosition.Midfielder, skillLevel: 7, pricePerGame: 15m);

            Console.WriteLine($"{monthly.Name} deve pagar: R$ {monthly.CalculateAmountDue(gamesPlayed: 5)}");
            Console.WriteLine($"{casual.Name} deve pagar: R$ {casual.CalculateAmountDue(gamesPlayed: 5)}");
        }
    }
}