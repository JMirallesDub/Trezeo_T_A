using System;

namespace Trezeo_T_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var processFile = new ProcessFile();
            processFile.Word_Unique_First("test.txt");
        }
    }
}
