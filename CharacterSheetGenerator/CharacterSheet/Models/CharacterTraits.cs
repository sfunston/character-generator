using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Models
{
    public class CharacterTraits
    {
        // general traits
        public string Name { get; set; }
        public string Alignment { get; set; }
        public string Race { get; set; }
        public string Size { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public int HitPoints { get; set; }
        public string Speed { get; set; }

        // abilities
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        // for skills that are selected
        public bool Acrobatics { get; set; }
        public bool Bluff { get; set; }
        public bool Climb { get; set; }
        public bool Diplomacy { get; set; }
        public bool Fly { get; set; }
        public bool Heal { get; set; }
        public bool Intimidate { get; set; }
        public bool Perception { get; set; }
        public bool Stealth { get; set; }

    }
}
