using PeladaPro.Projeto.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeladaPro.Projeto
{
    public class Warning
    {
        public CardType Type { get; set; }
        public DateTime Date { get; set; }

        public Warning(CardType type, DateTime date)
        {
            this.Type = type;
            this.Date = date;
        }
    }
}
