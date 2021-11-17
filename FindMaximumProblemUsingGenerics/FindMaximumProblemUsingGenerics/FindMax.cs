using System;
using System.Collections.Generic;
using System.Text;

class Printer
{
    public void Print<T>(T data)
    {
        Console.WriteLine(data);
    }
}