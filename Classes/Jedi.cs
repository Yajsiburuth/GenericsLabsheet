using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Jedi : IInterns
    {
        private string Name { get; set; }
        private int Id { get; set; }

        public string NameId => $"Jedi - {Name}: {Id}";

        public Jedi(string name, int id)
        {
            Name = name;
            Id = id;
        }

    }
}
