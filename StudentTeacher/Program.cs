namespace StudentTeacher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;
            Person MyPerson = new Person();
            MyPerson.Greet();


            // Student setAge, Greet And Display Age

            Student MyStudent = new Student();
            MyStudent.SetAge(21);
            MyStudent.Greet();
            MyStudent.ShowAge();


            // Teacher 30 year old, Greet and Explain     

            Teacher MyTeacher = new Teacher();
            MyTeacher.SetAge(30);
            MyTeacher.Greet();
            MyTeacher.Explain();

            if (debug)
                Console.ReadLine();
        }


    }
}