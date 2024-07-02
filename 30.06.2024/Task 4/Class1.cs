using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Class
    {
        public static string ReturnSumAndAverage(params double[] grades)
        {
            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            };
            return $"the sum is: {sum} and the avarege is {sum / grades.Length}";
        }


        public static int GetYears(int[] years)
        {
            foreach (int year in years)
            {
                if (year > 1950)
                {
                    Console.WriteLine(year);
                }
            }
            return 0;
        }


        public static int CalculateAgeInDays(int years)
        {
            if(years <=0){
                Console.WriteLine("inter a valid age");
            }
            else
            {
                const int daysInYear = 365;
                Console.WriteLine($"the age in days is: {years * daysInYear}");
            }
            return 0;
        }

    }



    //Q5

    public class Person
    {
        int age;
        string gender;
        string name;
        string email;
        string id;
        string phone;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18 || value > 60)
                    throw new ArgumentOutOfRangeException("Age must be between 18 and 60.");
                age = value;
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value != "Male" && value != "Female")
                    throw new ArgumentException("Gender must be either 'Male' or 'Female'.");
                gender = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Email cannot be empty.");
                email = value;
            }
        }

        public string ID
        {
            get { return id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("ID cannot be empty.");
                id = value;
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (!IsValidPhone(value))
                    throw new ArgumentException("Phone number must start with 077, 078, or 079.");
                phone = value;
            }
        }

        public Person(int age, string gender, string name, string email, string id, string phone)
        {
            Age = age;
            Gender = gender;
            Name = name;
            Email = email;
            ID = id;
            Phone = phone;
        }
        public Person()
        {
            age = 18;
            gender = "Male";
            name = "Default Name";
            email = "example@example.com";
            id = "DefaultID";
            phone = "0770000000";
        }

        private bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^(077|078|079)\d{7}$");
        }
        public string ShowInfo()
        {
            return $"age: {age} gender: {gender} name:{name} email: {email} id: {id} phone: {phone}";
        }
    }
}
