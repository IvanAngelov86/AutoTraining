using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            byte Age;
            char Gender;
            string IDNumber;
            long EmployeeNumber;

            FirstName = "Ivan";
            LastName = "Angelov";
            Age = 30;
            Gender = 'M';
            IDNumber = "1212324433";
            EmployeeNumber = 212349876543211;

            Console.WriteLine("Name: {0} {1}\nAge: {2} Gender: {3}\nID Numbers:\nPersonal: {4}\nEmployee ID: {5}", FirstName, LastName, Age, Gender, IDNumber, EmployeeNumber);

        }
    }
}
