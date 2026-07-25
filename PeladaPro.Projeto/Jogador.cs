namespace PeladaPro.Projeto
{
    internal class Jogador
    {
        private string _name { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("O nome não pode ser em branco");
                _name = value; 
            }
        }

        public int Age { get; set; }
        public string Position { get; set; }
        public int SkillLevel { get; set; }

    }
}
