using PeladaPro.Projeto.Enum;

namespace PeladaPro.Projeto
{
    internal class Player
    {
        private string _name;
        private int _skillLevel;
        private int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome não pode ser em branco.");
                _name = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18 || value > 40)
                    throw new ArgumentException("Jogador não tem idade permitida para a Pelada.");
                _age = value;
            }
        }
        public PlayerPosition Position { get; set; }

        public int SkillLevel
        {
            get { return _skillLevel; }
            set
            {
                if (value < 1 || value > 10)
                    throw new ArgumentException("O nivel precisa ser entre 1 e 10.");
                _skillLevel = value;

            }
        }

        public Player(string name, int age, PlayerPosition position, int skillLevel)
        {
            this.Name = name;
            this.SkillLevel = skillLevel;
            this.Age = age;
            this.Position = position;
        }

        public virtual decimal CalculateAmountDue(int gamesPlayed)
        {
            return 0;
        }
    }
}
