using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _402_Students
{
    class Student
    {
        /// <summary>
        /// Access modifiers:
        ///  - private      - accessed only in this Class
        ///  - internal     - accessed only in this Project (Students.csproj)
        ///  - protected    - accessed only by Inheritance
        ///  - public       - accessed anywhere
        /// </summary>

        //Fields - private data used in the Class
        private string name;
        private int age;

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get
            { 
                return age; 
            }

            set
            {
                if (this.age <= 0)
                {
                    throw new ArgumentException("Age should be greater 0.");
                }
                if (this.age > 100)
                {
                    throw new ArgumentException("Age should be less than 100.");
                }

                age = value;
            }
        }

        //Methods

        //Constructors



    }
}
