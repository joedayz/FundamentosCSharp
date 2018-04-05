using System;

namespace Grades
{
    class MainClass
    {
        internal static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.NameChanged += OnNameChanged;



          

            book.Name = "Joe Book";

            book.Name = "Book";
   
            book.AddGrade(91);
            book.AddGrade(89.75f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(book.Name);

            WriteResult("Average ", stats.AverageGrade);
            WriteResult("Highest ",(int)stats.HighestGrade);
            WriteResult("Lowest ", stats.LowestGrade);



        
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args){
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }



        static void WriteResult(string description, int result ){
            Console.WriteLine(description  + ":" +  result);
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0} : {1:F2}", description, result);
        }
    }
}
