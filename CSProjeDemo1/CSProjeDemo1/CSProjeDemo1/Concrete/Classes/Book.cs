using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSProjeDemo1.Concrete.Enum;

namespace CSProjeDemo1.Concrete.Classes
{
    public abstract class Book
    {
        public int Id { get; }
        public string ISBN { get; }
        public string Title { get; }
        public string Author { get; }
        public string Publisher { get; }
        public short PublishYear { get; }
        public Situation Situation { get; set; }

    }
}
