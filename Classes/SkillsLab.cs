using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class SkillsLab : IInterns
    {
        private string Name { get; set; }
        private int Id { get; set; }

        public string NameId => $"SkillsLab - {Name}: {Id}";

        public SkillsLab(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
