using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("수식을 입력하세요 : ");
            string formulaInput = Console.ReadLine();

            if(input == null)
            {
                break;
            }

            formulaInput = formulaInput.Replace(" ", "");

            if(formulaInput == "")
            {
                continue;
            }
        }
    }

    
}