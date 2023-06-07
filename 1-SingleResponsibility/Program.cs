using SingleResponsibility;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.ExportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");