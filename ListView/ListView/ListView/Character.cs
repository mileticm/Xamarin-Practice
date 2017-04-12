using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView
{
    public class Character
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Name, Species);
        }

        public static IList<Character> Characters
        {
            get
            {
                return new List<Character>
                {
                    new Character
                    {
                        Name = "Frodo",
                        Species = "Hobbit"
                    },
                    new Character
                    {
                        Name = "Aragorn",
                        Species = "Human"
                    }
                };
            }
        }
    }
}
