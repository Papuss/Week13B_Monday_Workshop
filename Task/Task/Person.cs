using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
        public struct Person
        {
            private string address;
            private int age;
            private int mobile;
            private string name;
            private Types type;
            private Types types;

        public Person(string name, string address, int age, int mobile, Types types) : this()
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.mobile = mobile;
            this.types = types;
        }

   

        public override string ToString()
        {
            return "Name: " + name + " Address: " + address + " Age: " + age + " Mobile: " + mobile + " Type: " + type;
        }

    }

    public enum Types
    {
        Home, Workplace, Mobile
    }


}
