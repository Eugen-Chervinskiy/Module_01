
namespace Module_01.Task_1
{
    public class SumCalculator
    {
        public static double SumByForLoop(params double[] inputArray)
        {
            if (inputArray != null)
            {
                double result = 0;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    result += inputArray[i];
                }

                return result;
            }

            else
            {
                return 0;
            }
            
        }

        public static double SumByWhileLoop(params double[] inputArray)
        {
            if (inputArray != null)
            {
                double result = 0;
                int counter = 0;
                while (counter != inputArray.Length)
                {
                    result += inputArray[counter++];
                }

                return result;
            }

            else
            {
                return 0;
            }
        }


        public static double SumByRecursion(params double[] inputArray)
        {   
            if (inputArray != null)
            {   
                return Recursion(0, inputArray);
            }

            else
            {
                return 0;
            }
        }

        private static double Recursion(int recursionCounter, params double[] inputArray)
        {
            if (recursionCounter == inputArray.Length)
            {
                return 0;
            }

            return (Recursion(recursionCounter + 1, inputArray) + inputArray[recursionCounter]);
        }
    }
}
