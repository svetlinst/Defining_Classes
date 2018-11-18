using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members = new List<Person>();

        public void AddMember(Person person)
        {
            this.members.Add(person);
        }

        public Person GetOldestMember()
        {
            var oldestMember = this.members.OrderByDescending(m=>m.Age).First();
            return oldestMember;
        }
    }
}
