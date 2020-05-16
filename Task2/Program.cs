using System;
using System.Collections.Generic;

namespace Classes_Task2_DanDavison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a Random ID
            Random random1 = new Random();
            int ID1  = random1.Next(1000, 9999);
            Random random2 = new Random();
            int ID2  = random2 .Next(1000, 9999);
            Random random3 = new Random();
            int ID3  = random3.Next(1000, 9999);

            //Instantiate a Subject
            Subject IT = new Subject("Information Technology", 2017);
            Subject GD = new Subject("Graphic Design", 2013);
            Subject SM = new Subject("Screen & Media", 2019);

            //Instantiate a Person
            Person P1 = new Person(ID1, "Dan", "Davison", new DateTime (2000, 01, 01), 180, GD);
            Person P2 = new Person(ID2, "Luke", "Baker", new DateTime (1998, 07, 03), 170, SM);
            Person P3 = new Person(ID3, "Caleb", "Parker", new DateTime (2001, 02, 09), 185, IT);

            //Write Height Differences
            System.Console.WriteLine();
            P1.GetHeightDifference(P2);
            P3.GetHeightDifference(P2);
            P1.GetHeightDifference(P3);

            //Write Subjects
            System.Console.WriteLine();
            P1.GetSubject();
            System.Console.WriteLine();
            P2.GetSubject();
            System.Console.WriteLine();
            P3.GetSubject();
            System.Console.WriteLine();
        }
    }
    //---------------------------------------------------------
    public class Person
    {
        //atributes
        public int ID;
        public string firstname;
        public string lastname;
        public DateTime dob;
        public int height;
        public Subject s;

        // constructors
        public Person(int id, string first, string last, DateTime dob, int height, Subject S) {
            this.ID = id;
            this.firstname = first;
            this.lastname = last;
            this.dob = dob;
            this.height = height;
            this.s = S;
        }

        //Methods
        public void GetFullName() {
            System.Console.Write(firstname + " " + lastname);
        }

        public void GetFullInfo() {
            System.Console.WriteLine("ID: " + ID + " Name: " + firstname + " " + lastname + " DOB: " + dob + " Height: " + height + "cm");
        }

        public void GetHeightDifference(Person other) {
            int difference = this.height - other.height;
            if(difference > 0){
                System.Console.WriteLine(this.firstname + " is taller than " + other.firstname + " by " + difference + " cm");
            }
            else if(difference < 0){
                System.Console.WriteLine(this.firstname + " is shorter than " + other.firstname + " by " + difference + " cm");
            }
            else {
                System.Console.WriteLine(this.firstname + " is the same height as " + other.firstname);
            }
        }

        public void GetSubject() {
            System.Console.WriteLine(firstname + " " + lastname + " studied the subject: " + s.name + " in the year: " + s.year);
        }
    }

    //---------------------------------------------------------
    public class Subject
    {
        //atributes
        public string name;
        public int year;

        // constructors
        public Subject(string name, int year) {
            this.name = name;
            this.year = year;
        }
    }    
}