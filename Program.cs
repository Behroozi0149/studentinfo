using Students.Entities;
try
{
    Console.Clear();
    var menuitems = new string[]
    {
    "1-Add Student",
    "2-Student list",
    "0-Exit",
    };
    var students = new List<Student>();
    while (true)
    {
        foreach (var item in menuitems)
        {
            Console.WriteLine(item);
        }
        Console.Write("Your Choice:");
        var Choice = int.Parse(Console.ReadLine() ?? "0");
        if (Choice == 0)
        {
            break;
        }
        if (Choice == 1)
        {
            for (int i = 0; i < 3; i++)
            {
                Student student = new();
                student.Read();
                students.Add(student);
                Console.WriteLine(students);
            }
        }
        if (Choice == 2)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
catch
{
    Console.WriteLine();
    Console.ForegroundColor=ConsoleColor.DarkRed;
    Console.WriteLine("Error!");
    Console.ResetColor();
}