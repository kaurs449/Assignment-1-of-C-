Console.WriteLine("Alignment One:");
namespace StudentInfo
{
    public enum StudentType
    {
        Unknown,
        PartTime,
        FullTime
    }

    namespace Student { 
        class Program
        {
            static void Main(string[] args)
            {
                var student1 = StudentWork.CreateStudent(101, StudentType.FullTime, "Tom", "Doe");
                var student2 = StudentWork.CreateStudent(102, StudentType.PartTime, "Mike", "henry");
                var student3 = StudentWork.CreateStudent(103, StudentType.Unknown, "Alessa", "bently");


                StudentWork.OutputStudent(student1);
                StudentWork.OutputStudent(student2);
                StudentWork.OutputStudent(student3);
            }
        }
    }
}
