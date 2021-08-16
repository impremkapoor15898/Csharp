using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Exer5Day3
    {
        public int age { get; set; }
        public Exer5Day3(int age)
        {
            this.age = age;
        }
        public void validateDOB()
        {
            if(this.age<0)
            {
                throw (new InvalidAgeException("Age is invalid"));
            }
            else
            {
                Console.WriteLine( $"Age is {this.age}");
            }
        }
        public class InvalidAgeException : Exception
        {
            public InvalidAgeException(string message):base(message)
            {

            }
        }



    }
    public class Exer5Day3Test
    {
       public static void Main()
        {
            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());
            Exer5Day3 e = new Exer5Day3(age);
            try
            {
               e.validateDOB();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

}
