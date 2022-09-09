//=======================================================================
// # 0 Напишите программу, которая на вход принимает число и
// выжает его квадрат (число умноженное на себя).
//=======================================================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    //int outNumber = 0;
    //int outNumber = inputNumber * inputNumber;
    int outNumber = (int)Math.Pow(inputNumber,2);

    Console.WriteLine(outNumber);
}