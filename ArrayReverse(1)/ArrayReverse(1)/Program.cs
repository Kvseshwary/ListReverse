using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayReverse_1_
{
    class Program
    {

         
        static void Main(string[] args)
        {
                int temp = 0, i;
                string value =  null ;
                int no = 0;
                //do
                //{
                    
                    Console.WriteLine("Enter Positive  Number(1 to N)");
                    value = Console.ReadLine();
                    
                    bool success = Int32.TryParse(value, out no);
                    if (success)
                    {
                        //Console.WriteLine("Converted {0} to {1}", value, no);
                       // no = int.Parse(Console.ReadLine());
                        no = int.Parse(value);
                        temp = 1;
                    }
                    /*else
                    {
                        Console.WriteLine("Attempted conversion {0} failed",value??"null");
                    }*/
                    
                //} while (no <= 0);                      // checking for negative number



                if (temp == 1)
                {
                    string[] values = Console.ReadLine().Split(' ');
                   
                    

                    if (values.Length == no)
                    {

                        string[] number = new string[values.Length];

                        for (i = 0; i < values.Length; i++)
                        {
                            number[i] = values[i];
                        }


                        Array.Reverse(number);

                        /* for (int j = 0, m = number.Length - 1; j < m; j++, m--)
                         {
                             temp = number[j];
                             number[j] = number[m];
                             number[m] = temp;
                         }*/


                        foreach (string num in number)
                            Console.Write(num + " ");


                        /*   string strName = Console.ReadLine();
                           char[] charArray = strName.ToCharArray();
                           Array.Reverse(charArray);
                           foreach (char ch in charArray)
                               Console.Write(ch);*/
                        // Console.WriteLine("Enter {0} Numbers(1 to 10)", a);
                        /* foreach (int arr in intArray)
                             Console.Write(arr + " ");
                         Array.Reverse(intArray);
                         foreach (int arr in intArray)
                             Console.Write(arr + " ");
                         Console.ReadLine();*/

                        //Console.ReadLine()

                        Console.ReadLine();
                    }

                }

            }


   }
    }

