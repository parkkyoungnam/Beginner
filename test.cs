
using System;

namespace test
{
    public class Program
    {
        private string name;
        private int age;

        public Program()
        {
            name = string.Empty;
            age = 0;
        }

        public string name_bulid    
        {
            get {return this.name;}

            set
            {
                this.name = value;
            }
        }

        public int age_bulid
        {
            get { return this.age; }

            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            return "Name = " + name + ", Age = " + age;
        }
    }
}
