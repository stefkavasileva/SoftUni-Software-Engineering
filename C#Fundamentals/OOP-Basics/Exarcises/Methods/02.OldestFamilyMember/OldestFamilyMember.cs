using System;
using System.Reflection;

namespace _02.OldestFamilyMember
{    
    public class OldestFamilyMember
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < count; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                var person = new Person(name,age);
                family.AddMember(person);
            }

            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine(oldestMember);
        }
    }
}
