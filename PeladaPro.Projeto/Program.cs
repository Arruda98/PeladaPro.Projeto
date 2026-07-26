using PeladaPro.Projeto;
using PeladaPro.Projeto.Enum;

namespace Pelada.Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var jogador = new Player(name: "Lucas", skillLevel: 8, position: PlayerPosition.Forward, age: 25);
                Console.WriteLine("Jogador adicionado com sucesso");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}