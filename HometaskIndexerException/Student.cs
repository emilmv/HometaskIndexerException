using System.Collections;

namespace HometaskIndexerException
{
    internal class Student:IComparable<Student>
    {
        private static int staticId;
        private int Id { get; }
        public string ?Name { get; set; }
        public string ?Surname { get; set; }
        public Student()
        {
            staticId++;
            Id=staticId;
        }
        public void Info()
        {
            Console.WriteLine("ID: "+Id);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Surname: "+Surname);
        }
        public int CompareTo(Student? other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
