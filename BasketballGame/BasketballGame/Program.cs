// See https://aka.ms/new-console-template for more information
using BasketballGame;

string[] ops = new string[] { "5", "2", "C", "D", "+" };
string[] ops2 = new string[] { "14", "2", "5", "D", "D", "C", "+"};
string[] ops3 = new string[] { "C", "D", "5", "D", "2", "+", "C"};
string[] ops4 = new string[] { };
string[] ops5 = new string[] { "-34000", "40000", "C", "D", "45000", "+"};
string[] ops6 = new string[] { "-100000", "C", "D", "+"};
string[] ops7 = new string[] { "D", "100000", "C", "+" };

try
{
    Console.WriteLine(CalPoints(ops));
    Console.WriteLine(CalPoints(ops2));
    //Console.WriteLine(CalPoints(ops3));
    //Console.WriteLine(CalPoints(ops4));
    //Console.WriteLine(CalPoints(ops5));
    //Console.WriteLine(CalPoints(ops6));
    //Console.WriteLine(CalPoints(ops7));
}
catch (LengthLimitException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NumberLimitException ex)
{
    Console.WriteLine(ex.Message);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Scores can not be combined using given input");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




static int CalPoints(string[] ops)
{
    if(ops.Length < 1 || ops.Length > 1000)
    {
        throw new LengthLimitException("Minimum input length should be 1 and maximum 1000");
    }
    
    int result = 0;
    int[] scores = new int[ops.Length];
    int index = 0;

    for (int i = 0; i < ops.Length; i++)
    {
        if (ops[i] == "C")
        {
            scores[index - 1] = 0;
            index = index - 1;
        }
        else if (ops[i] == "D")
        {
            scores[index] = scores[index - 1] * 2;
            index++;
        }
        else if (ops[i] == "+")
        {
            scores[index] = scores[index - 1] + scores[index - 2];
            index++;
        }
        else
        {
            scores[index] = Convert.ToInt32(ops[i]);
            if(scores[index] < -30000)
            {
                throw new NumberLimitException("Minimum amount of input element should be -30 000 and maximum 30 000");
            }
            else if(scores[index] > 30000)
            {
                throw new NumberLimitException("Minimum amount of input element should be -30 000 and maximum 30 000");
            }
            index++;
        }
    }

    foreach (var item in scores)
    {
        result += item;
    }

    return result;
}
