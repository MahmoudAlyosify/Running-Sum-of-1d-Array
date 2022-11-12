using System;

namespace Running_Sum_of_1d_Array
{
    internal class Program
    {
        /*
         Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

         Return the running sum of nums.
         */
        static void Main(string[] args)
        {
         string nums=Console.ReadLine();
         int[] Numbers=int.nums.ToCharArray();
            if (Numbers.Length == 0)
            {
                Console.WriteLine("Enter again !!!");
            }
            else
            {
                int c = 0;
                int[] IntgerNumber=new int[(Numbers.Length/2)+1];
                for (int i  = 0; i < Numbers.Length; i ++)
                {

                    if (i % 2 != 0)
                    {
                        IntgerNumber[c]+=(Numbers[i]);
                        c++;
                    }
                }
            
              
            }
        }
    }
}
