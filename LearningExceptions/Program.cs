using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningExceptions
{
    class Person 
    {
        private String name;

        public String Name
        {
            get { return name; }
            set 
            {
                try 
                {
                    if (value == null)
                        throw new NullReferenceException("name must have a value");

                    name = value;
                } 
                catch
                {
                    Console.WriteLine("name cannot be null");
                    // throw makes the exceptions further up the line to get output as well as this one.
                    throw;
                }

                
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person();
                person.Name = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
