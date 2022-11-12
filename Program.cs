// See https://aka.ms/new-console-template for more information



/*
 * Შემოდის გამოსახულება სტრინგის სახით. 
 * დაწერეთ პროგრამა რომელიც ამ გამოსახულების შედეგს გამოთვლის (არითმეტიკული ოპერაციები ჩავთვალოთ რომ გვაქვს მხოლოდ + - * ) 
 * მაგ: “((1+2)*(3+4))*(5*(8+9))”
*/


// Extracting numbers from string 



static int[] ExtractNumbers(string expression)
{
    string[] splitResult = expression.Split('+', '-', '*');
    int[] resultNumbers = new int[splitResult.Length];
    for (int i = 0; i < splitResult.Length; i++)
    {
        resultNumbers[i] = int.Parse(splitResult[i]);
    }
    return resultNumbers;
}


int[] numbers = ExtractNumbers("1+2+3+4+5");

foreach (int number in numbers)
{
    Console.Write(" " + number);
}


Console.WriteLine("\n--------------");



//extracting operators from sting 
static char[] ExtractOperators(string expression)
{
    string operatorCharacters = "+-*";
    List<char> operators = new List<char>();
    foreach (char chars in expression)
    {
        if (operatorCharacters.Contains(chars))
        {
            operators.Add(chars);
        }
    }
    return operators.ToArray();
}

char[] operators = ExtractOperators("1+2*3-4*5");

foreach (char operat in operators)
{
    Console.Write(" " + operat);
}


//calculate extraction

static int CalculateExpression(int[] numbers,char[] operators)
{
    int result = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        char operation = operators[i - 1];
        int nextNumber = numbers[i];

        //  switch (operation)
        //{
        //    case '+':
        //        result += nextNumber;
        //        break;
        //    case '-':
        //        result -= nextNumber;
        //        break;
        //    case '*':
        //        result += nextNumber;
        //        break;
        //    default:
        //        return result;
        //        break;
        //}

        if (operation == '+')
        {
            result += nextNumber;
        }
        else if (operation == '-')
        {
            result -= nextNumber;
        }
        else if (operation == '*')
        {
            result *= nextNumber;
        }
    }
    return result;
}


int result = CalculateExpression(numbers, operators);

Console.WriteLine($"\n Result is  {result}");


