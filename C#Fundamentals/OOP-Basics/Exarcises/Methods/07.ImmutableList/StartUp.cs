using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _07.ImmutableList
{
    public class ImmutableList
    {
        public List<int> numbers;
        public List<int> Numbers => this.numbers;

        public ImmutableList GetNewList()
        {
            return  new ImmutableList();
        }
    }

    public class StartUp
    {
        public static void Main()
        {
            Type immutableList = typeof(ImmutableList);
            FieldInfo[] fields = immutableList.GetFields();
            if (fields.Length < 1)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(fields.Length);
            }

            MethodInfo[] methods = immutableList.GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("ImmutableList"));
            if (!containsMethod)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(methods[0].ReturnType.Name);
            }

        }
    }
}
