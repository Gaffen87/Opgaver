namespace Disaheim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 61 / 60;
            Console.WriteLine(i);
            Course c1 = new Course("Nuru Massage using Chia Oil", 157);
            CourseRepository courses = new CourseRepository();
            
            courses.AddCourse(c1);

            Course c = courses.GetCourse("Nuru Massage using Chia Oil");

            Console.WriteLine(c);
            
            Console.ReadLine();
        }
    }
}