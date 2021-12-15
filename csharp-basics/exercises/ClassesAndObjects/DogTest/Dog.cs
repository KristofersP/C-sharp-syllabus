using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class Dog
    {
        public string name;
        public string sex;
        public string father;
        public string mother;

        public Dog(string name, string sex, string father, string mother)
        {
            this.name = name;
            this.sex = sex;
            this.father = father;
            this.mother = mother;
        }

        public string FathersName()
        {
            return father == null ? "Unknown" : father;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return mother == otherDog.mother;
        }
    }
}
