using System;

namespace _158BTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] str_numbers = Console.ReadLine().Split();

            int[] groups = new int[n];

            for(int i = 0; i < n; i++)
            {
                groups[i] = Convert.ToInt32(str_numbers[i]);
            }

            Array.Sort(groups);

            int result = 0;

            int left = 0;

            for(int i = n - 1; i >= 0; i--)
            {
                if (left > i) { break; }
                if (left == i) { result++; break;  }

                if (groups[i] == 4)
                {
                    result++;
                }
                else if(groups[i] == 3)
                {
                    if(left == i) { result++; break; }
                    if(groups[left] == 1)
                    {
                        left++;
                        result++;
                    }
                    else
                    {
                        result++;
                    }
                }
                else if(groups[i] == 2)
                {
                    if (left >= i) { result++; break; }
                    if (groups[left] == 1)
                    {
                        if(groups[left + 1] == 1 && left + 1 != i)
                        {
                            left += 2;
                            result++;
                        }
                        else
                        {
                            result++;
                            left++;
                        }
                    }
                }
                else if(groups[i] == 1)
                {
                    if (left >= i) { result++; break; }
                    int c = left + 4;
                    for(int j = left; j < c; j++)
                    {

                        if (left >= i) { result++; break; }
                        if (j == i)
                        {
                            result++;
                            break;
                        }
                        else
                        {
                            left++;
                            
                        }

                        if(j == c - 1)
                        {
                            result++;
                        }
                    }

                    
                }
            }

            Console.WriteLine(result);

        }
    }
}
