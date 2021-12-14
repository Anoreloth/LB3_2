using System;

namespace LB3_2
{
    class User
    {
        protected string name;
        protected int age;
        public string setName
        {
            set { name = value; }
        }
        public string getName
        {
            get { return name; }
        }
        public int setAge
        {
            set { age = value; }
        }
        public int getAge
        {
            get { return age; }
        }
        public User(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
    class Worker : User
    {
        private int salary;
        public int getSalary
        {
            get { return salary; }
        }
        public int setSalary
        {
            set { salary = value; }
        }
        public Worker(int age, string name, int salary) : base(age, name)
        {
            this.salary = salary;
        }
    }
    class Student : User
    {
        private int scholarship;
        private int course;
        public int getStipend
        {
            get { return scholarship; }
        }
        public int getCourse
        {
            get { return course; }
        }
        public Student(int age, string name, int scholarship, int course) : base(age, name)
        {
            this.scholarship = scholarship;
            this.course = course;
        }
    }
    class Driver : Worker
    {
        private int drivingExperience;
        private string category;
        public int getCategory
        {
            get { return drivingExperience; }
        }
        public string getExperience
        {
            get { return category; }
        }
        public Driver(int age, string name, int salary, int drivingExperience, string category) : base(age, name, salary)
        {
            this.drivingExperience = drivingExperience;
            this.category = category;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var i = new Worker(25, "Ivan", 1000);
            var v = new Worker(26, "Vasya", 2000);
            Console.WriteLine("Name: " + i.getName + ", Age: " + i.getAge + ", Salary: " + i.getSalary);
            Console.WriteLine("Name: " + v.getName + ", Age: " + v.getAge + ", Salary: " + v.getSalary);
            Console.WriteLine("The amount of salaries: " + (i.getSalary + v.getSalary));

            var l = new Student(18, "Lera", 800, 2);
            Console.Write("Student: " + l.getName + ", Age: " + l.getAge);
            Console.WriteLine(", Scholarship: " + l.getStipend + ", Сourse: " + l.getCourse);

            var t = new Driver(45, "Tom", 18000, 20, "B");
            Console.Write("Name: " + t.getName + ", Age: " + t.getAge + ", Salary: " + t.getSalary);
            Console.WriteLine(", Driving experience: " + t.getCategory + ", Driving category: " + t.getExperience);
        }
    }
}
