using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HometaskIndexerException
{
    internal class Group
    {
        private int staticId { get; }
        private int Id { get; }
        public string? Name { get; set; }
        public Student[] ?StudentArray { get; set; }
        public Group(int studentCount)
        {
            staticId++;
            Id = staticId;
            StudentArray = new Student[studentCount];
        }
        public Student this[int index]
        {
            get
            {
                if(index < 0 || index > StudentArray.Length)
                {
                    Console.WriteLine("OUT OF RANGE");
                    throw new ArgumentOutOfRangeException();
                }
                return StudentArray[index];
            }
            set
            {
                if (index < 0 || index > StudentArray.Length)
                {
                    Console.WriteLine("OUT OF RANGE");
                    throw new ArgumentOutOfRangeException();
                }
                StudentArray[index] = value;
            }
        }
    }
}
