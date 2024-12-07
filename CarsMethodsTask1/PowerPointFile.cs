using System;

namespace CarsMethodsTask1;

public class PowerPointFile: File
{
    public void Present()
    {
        Console.WriteLine($"{FileName} presenting..");
    }
}
