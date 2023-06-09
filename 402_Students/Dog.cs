using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _402_Students
{
    internal class Dog
    {
        //Fields
        int bitenPeopleCount;
        private string firstName;
        private string lastName;
        private int age;

        //Constructors

        //Properties
        public bool IsBadDog
        {
            get { return bitenPeopleCount > 1; }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;

                if (this.age <= 0)
                {
                    throw new ArgumentException("Age should be greater 0.");
                }
                if (this.age > 100)
                {
                    throw new ArgumentException("Age should be less than 100.");
                }
            }
        }

        public string Name
        {
            get { return firstName + " " + lastName; }
            set
            {
                var split = value.Split(' ');
                firstName = split[0];
                lastName = split[1];
            }
        }

        //Methods
        public void BitePerson()
        {
            bitenPeopleCount++;
        }
    }
}
