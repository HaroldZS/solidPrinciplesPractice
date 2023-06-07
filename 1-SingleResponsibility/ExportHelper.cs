using System.Text;

namespace SingleResponsibility
{
    public class ExportHelper
    {
        private const string CsvFileName = "Students.csv";

        public void ExportStudents(IEnumerable<Student> students)
        {
            string csv = GetCsvContent(students);
            SaveCsvToFile(csv);
        }

        private string GetCsvContent(IEnumerable<Student> students)
        {
            var csvContent = new StringBuilder();
            csvContent.AppendLine("Id,Fullname,Grades");

            foreach (var student in students)
            {
                string grades = string.Join("|", student.Grades);
                csvContent.AppendLine($"{student.Id},{student.Fullname},{grades}");
            }

            return csvContent.ToString();
        }

        private void SaveCsvToFile(string csv)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CsvFileName);
            File.WriteAllText(filePath, csv, Encoding.Unicode);
        }
    }
}