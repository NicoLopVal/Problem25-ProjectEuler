using System.Numerics;


BigInteger currentNum = 0;
BigInteger previousNum = 2;
BigInteger lastNum = 1;
BigInteger index = 3;

while (true)
{

    currentNum = lastNum + previousNum;
    index++;
    if (currentNum.ToString().Length >= 1000)
        break;
    lastNum = previousNum;
    previousNum = currentNum;
}

Console.WriteLine(index);