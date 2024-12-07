using System;

namespace CarsMethodsTask1;

public class WordDocumentFile :File 
{
    public void Print()
    {
        Console.WriteLine($"{FileName} printing..");
    }
}
