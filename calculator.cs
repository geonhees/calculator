using System;

class Program
{
    static int index = 0;
    static void Main()
    {
        while (true)
        {
            Console.Write("수식을 입력하세요(종료하려면 Q) : ");
            string formulaInput = Console.ReadLine();

            if (formulaInput == "q" || formulaInput == "Q")
            {
                break;
            }

            formulaInput = formulaInput.Replace(" ", "");

            if (formulaInput == "")
            {
                continue;
            }

            try
            {
                index = 0;
                
                while (index < formulaInput.Length)
                {
                    char c = formulaInput[index];

                    if (c == '*' || c == '/')
                    {
                        int leftIndex = index - 1;
                        while (leftIndex >= 0 && char.IsDigit(formulaInput[leftIndex]))
                        {
                            leftIndex--;
                        }

                        int leftStartIndex = leftIndex + 1;
                        int leftLength = index - leftStartIndex;
                        string leftNumber = formulaInput.Substring(leftStartIndex, leftLength);


                        int rightIndex = index + 1;
                        while (rightIndex < formulaInput.Length && char.IsDigit(formulaInput[rightIndex]))
                        {
                            rightIndex++;
                        }
                        int rightStartIndex = index + 1;
                        int rightLength = rightIndex - rightStartIndex;
                        string rightNumber = formulaInput.Substring(rightStartIndex, rightLength);

                        int LNumber = int.Parse(leftNumber);
                        int RNumber = int.Parse(rightNumber);
                        int resultNumber = 0;

                        if (c == '*')
                        {
                            resultNumber = LNumber * RNumber;
                        }
                        else
                        {
                            resultNumber = LNumber / RNumber;
                        }


                        formulaInput = formulaInput.Substring(0, leftStartIndex) + resultNumber.ToString() + formulaInput.Substring(rightIndex);
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                }

                index = 0;


                while (index < formulaInput.Length)
                {
                    char c = formulaInput[index];

                    if (c == '+' || c == '-')
                    {

                        if (index == 0)
                        {
                            index++;
                            continue;
                        }


                        int leftIndex = index - 1;
                        while (leftIndex >= 0 && char.IsDigit(formulaInput[leftIndex]))
                        {
                            leftIndex--;
                        }
                        int leftStartIndex = leftIndex + 1;
                        int leftLength = index - leftStartIndex;
                        string leftNumber = formulaInput.Substring(leftStartIndex, leftLength);

                        int rightIndex = index + 1;
                        while (rightIndex < formulaInput.Length && char.IsDigit(formulaInput[rightIndex]))
                        {
                            rightIndex++;
                        }
                        int rightStartIndex = index + 1;
                        int rightLength = rightIndex - rightStartIndex;
                        string rightNumber = formulaInput.Substring(rightStartIndex, rightLength);

                        int LNumber = int.Parse(leftNumber);
                        int RNumber = int.Parse(rightNumber);
                        int resultNumber = 0;

                        if (c == '+')
                        {
                            resultNumber = LNumber + RNumber;
                        }
                        else
                        {
                            resultNumber = LNumber - RNumber;
                        }

                        formulaInput = formulaInput.Substring(0, leftStartIndex) + resultNumber.ToString() + formulaInput.Substring(rightIndex);
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                }
                Console.WriteLine("결과 : " + formulaInput);
            }
            catch
            {
                Console.WriteLine("잘못된 수식입니다.");
            }
        }
    }
}