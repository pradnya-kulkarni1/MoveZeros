namespace MoveZeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Program to move zeros in an array to its end");
            Console.WriteLine("Please enter the length of the array of integers");
            String aLength = Console.ReadLine();
            int arrayLength = Convert.ToInt32(aLength);
            int[] firstArray = new int[arrayLength];

            Console.WriteLine($"Please enter {arrayLength} numbers of first array");
            for (int i = 0; i < arrayLength; i++)
            {
                String num = Console.ReadLine();
                int n = Convert.ToInt32(num);
                firstArray[i] = n;

            }
            MoveZeroes(firstArray);
        }
        public static void MoveZeroes(int[] nums)
        {
            for (int k = 0; k < nums.Length; k++)
            {
                Console.WriteLine("k=" + k);
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("i= " + i);
                    if (nums[i] == 0)
                    {
                        for (int j = i; j < nums.Length - 1; j++)
                        {

                            nums[j] = nums[j + 1];
                            nums[j + 1] = 0;
                        }
                    }

                }
                }
                Console.WriteLine("Result is :");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine(nums[i] + " ");
                }

            
        }
    }
}
