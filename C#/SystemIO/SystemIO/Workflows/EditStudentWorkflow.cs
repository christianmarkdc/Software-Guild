using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemIO.Data;
using SystemIO.Helpers;
using SystemIO.Models;

namespace SystemIO.Workflows
{
    public class EditStudentWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Edit Student");

            StudentRepository repo = new StudentRepository(Settings.FilePath);
            List<Student> students = repo.List();

            ConsoleIO.PrintPickListOfStudents(students);
            Console.WriteLine(0);

            int index = ConsoleIO.GetStudentIndexFromUser("Which student would you like to edit?", students.Count());
            index--;

            Console.WriteLine();
            Console.WriteLine("Enter new GPA for {0} {1}", students[index].FirstName, students[index].LastName);

            students[index].GPA = ConsoleIO.GetRequiredDecimalFromUser(string.Format("Enter new GPA for {0} {1}", students[index].FirstName, students[index].LastName));

            repo.Edit(students[index], index);
            Console.WriteLine("GPA updated");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
