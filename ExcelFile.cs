using System;

namespace CarsMethodsTask1;

public class ExcelFile : File
{
    public void GenerateReport()
    {
        Console.WriteLine($"{FileName} report..");
    }
}
