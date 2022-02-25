using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose math operation to perform: ");
            Console.WriteLine("1. Integer math operation");
            Console.WriteLine("2. Vector math operation");
            Console.WriteLine("3. Matrix math operation");
            Console.WriteLine("4. Decimal math operation");

            int operation = 0;

            try
            {
                operation = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            if(operation >= 1 && operation <= 4)
            {
                switch (operation)
                {
                    case 1:
                        try
                        {
                            IntMathOperation intMath = new IntMathOperation();

                            Console.Write("Number 1: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Number 2: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Addition: {0}", intMath.Addition(num1, num2));
                            Console.WriteLine("Substraction: {0}", intMath.Substraction(num1, num2));
                            Console.WriteLine("Multiplication: {0}", intMath.Multiplication(num1, num2));
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.Write("First Vector: ");
                            double vect1 = Convert.ToDouble(Console.ReadLine());
                            double vect2 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Second Vector: ");
                            double vectt1 = Convert.ToDouble(Console.ReadLine());
                            double vectt2 = Convert.ToDouble(Console.ReadLine());

                            VectorMathOperation vector1 = new VectorMathOperation(vect1, vect2);
                            VectorMathOperation vector2 = new VectorMathOperation(vectt1, vectt2);

                            var addition = vector1 + vector2;
                            var substraction = vector1 - vector2;
                            var multiplication = vector1 * vector2;

                            Console.WriteLine($"Addition : {addition}");
                            Console.WriteLine($"Substraction: {substraction}");
                            Console.WriteLine($"Multiplication: {multiplication}");
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("2x2 Matrix math operation: ");

                            Console.WriteLine("Fill first matrix: ");

                            Console.Write("Enter element for 0:0: ");
                            int a1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter element for 0:1: ");
                            int b1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter element for 1:0: ");
                            int c1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter element for 1:1: ");
                            int d1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Fill second matrix: ");

                            Console.Write("Enter element for 0:0: ");
                            int a2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter element for 0:1: ");
                            int b2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter element for 1:0: ");
                            int c2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter element for 1:1: ");
                            int d2 = Convert.ToInt32(Console.ReadLine());

                            MatrixMathOperation2x2 matrix1 = new MatrixMathOperation2x2(a1, b1, c1, d1);
                            MatrixMathOperation2x2 matrix2 = new MatrixMathOperation2x2(a2, b2, c2, d2);

                            var matrixAddition = matrix1 + matrix2;
                            var matrixSubstraction = matrix1 - matrix2;
                            var matrixMultiplication = matrix1 * matrix2;

                            Console.WriteLine($"Addition {matrixAddition}");
                            Console.WriteLine($"Substraction {matrixSubstraction}");
                            Console.WriteLine($"Multiplication {matrixMultiplication}");
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 4:
                        try
                        {
                            DecimalMathOperation decimalMath = new DecimalMathOperation();

                            Console.Write("Enter decimal number 1: ");
                            double number1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter decimal number 2: ");
                            double number2 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Addition: {0}", decimalMath.Addition(number1, number2));
                            Console.WriteLine("Substraction : {0}", decimalMath.Substraction(number1, number2));
                            Console.WriteLine("Multiplication: {0}", decimalMath.Multiplication(number1, number2));
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
            }
            else if (operation < 1 || operation > 4)
            {
                Console.WriteLine("Given input does not correspond to any operation...");
            }
        }
    }
}
