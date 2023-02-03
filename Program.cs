using System.Diagnostics.Tracing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello lucy!");

            double x = 0.0f;
            double y = 0.0f;
            double sum = 0.0f;
            
            Console.Write("enter first number\n");
            x = Convert.ToInt16(Console.ReadLine());

            Console.Write("enter second number\n");
            y = Convert.ToInt16(Console.ReadLine());

            sum = x + y;
            Console.WriteLine("Lucy the sum is " + sum.ToString());
            //lower case is object name, Capital if you want to access the Class
            Arith arith = new Arith();
            // Atrith summer = new Arith()
            //int sum2 = 0;
            sum = arith.Add(3, 4);
            Console.WriteLine(sum);
            //waits for key line
            //string a = Console.ReadLine();
            //y = Console.ReadLine();
            //Console.WriteLine(a);
            //Question 1
            string cathal = "";
            cathal = "121103100241000021031000613000";
            Console.WriteLine(cathal);
            int cont = 0;
            for (int counter =0; counter < cathal.Length; counter++)
            {
                
                if (cathal[counter].ToString() == "0")
                {
                    cont++;
                    Console.WriteLine(cont.ToString());

                }
                else if (cathal[counter].ToString() != "0")
                {
                    Console.WriteLine(cont.ToString());
                    cont= 0;
                }
                //Console.WriteLine(cathal[counter].ToString());
                //Console.WriteLine(cont.ToString());

            }
            //Question 2
            string rats = "rats";
            string star = "star";
            //Need to loop through array of words but also check if they are the same length
            //Console.WriteLine(star+" "+rats);
            string newWord = "";
            for (int counter=0; counter < rats.Length; counter++)
            {
                for (int counter2 = 0; counter2 < star.Length; counter2++)
                {
                    
                    //string newWord = "";
                    if (rats[counter].ToString() == star[counter2].ToString())
                    {
                        //Console.WriteLine(rats[counter].ToString());
                        newWord += rats[counter].ToString();
                        
                    }
                    //This is handy Console.WriteLine($"{counter}.{newWord}");
                    

                    
                }
                
            }
            Console.WriteLine(newWord);

            //
            //Question 3
            //
            //int n = 5;
            for (int i=0;i<5;i++)
            {
                int n = 2 * i + 1;
                //Console.WriteLine(n);
                Console.WriteLine(string.Concat(Enumerable.Repeat("*", n)));
            }
            //Console.WriteLine(ss * (2 * n + 1);
            //
            //Qustion 4
            //
            for (int i = 0; i < 5; i++)
            {
                int n = 2 * i + 1;
                //Console.WriteLine(n);
                Console.WriteLine(string.Concat(Enumerable.Repeat("*", n)));
            }
            for (int i = 3; i > 0; i--)
            {
                int n = 2 * i + 1;
                //Console.WriteLine(n);
                Console.WriteLine(string.Concat(Enumerable.Repeat("*", n)));
            }
            //Console.WriteLine(rss);

            //
            //Question 5
            //
            string hello = "hello world";
            string world = "";
            for (int i = hello.Length-1; i > -1; i--)
            {
                world+=hello[i].ToString();
            }
            Console.WriteLine(world);

            //
            //Question 6
            string palindrome = "";
            string maybepal = "madam";
            for (int i = maybepal.Length - 1; i > -1; i--)
            {
                palindrome += maybepal[i].ToString();
            }
            
            if (palindrome == maybepal )
            {
                Console.WriteLine("palindrome");
            }
            else if (palindrome == maybepal)
            {
                Console.WriteLine("not palindrome");
            }

            //
            //Question 7
            //
            //string number1 = "1";
            //string number2 = "2";
            //int addthem = Int32.Parse(number2);
            //Arith arith = new Arith();
            // Atrith summer = new Arith()
            //int sumss = 0;
            //sumss = arith.Sums(12);
            //Console.WriteLine(sumss);
            int num = 123;
            string s=num.ToString();
            Console.WriteLine(s);
            Console.WriteLine(s.Length);
            int addThem = 0;
            for (int i = 0; i < s.Length ; i++)
            {
                //Console.WriteLine(s[i]);
                //char v = s[i];
                int v = s[i]-'0';
                //Console.WriteLine(v.ToString());
                addThem += v;
                //Console.WriteLine(typeof(s[i]));

                //addThem += s[i];
            }
            Console.WriteLine(addThem);
            int sumss = 0;
            sumss = arith.Sums(123);
            Console.WriteLine(sumss);
            //int newnum = number1.ToInt() + number2.ToInt();
            //Console.WriteLine(newnum.ToString);


            //Console.WriteLine(cont.ToString());

            //Console.WriteLine(cont.ToString());
            //Console.WriteLine("sum is" + y.ToString());
            List<int> numberList = new List<int> {1, 3, 5, 3, 4, 2};
            //numberList.Add(420);
            //Console.WriteLine(numberList[0]);
            //Tuple<int> newTuple= new Tuple<int> { };
            //newTuple.add(420);
            //git change
            List<int> resultList = new List<int>();
            
            int match = 4;

            for (int i=0; i<numberList.Count; i++)
            {
                //Console.WriteLine(numberList.ElementAt(i));
                for (int j=0; j<numberList.Count; j++)
                {
                    //if i==j break maybe continue
                    if ( i==j)
                    {
                        break;
                    }
                    //Console.WriteLine(numberList.ElementAt(i));
                    //Console.WriteLine(numberList.ElementAt(j));
                    else if ( i!=j)
                    {
                        //Console.WriteLine(numberList.ElementAt(i) + numberList.ElementAt(j));
                        //resultList.Add(i);
                        //resultList.Add(j);
                        if ((numberList.ElementAt(i) + numberList.ElementAt(j)) == match)
                        {
                            Console.WriteLine(numberList.ElementAt(i));
                            Console.WriteLine(numberList.ElementAt(j));
                            resultList.Add(i);
                            resultList.Add(j);
                        }
                    }
                        
                        
                    //Console.WriteLine(numberList.ElementAt(i) + numberList.ElementAt(j));

                }
            }
            Console.WriteLine(resultList.Count);
            //int func = 0;
            Console.WriteLine("the list is");
            int varr = findtwosum(numberList,match);
            Console.WriteLine(varr);

            //func = arith.FindTwoSum(numberList);

            //
            // Question 9
            //
            int nprime = arith.nthPrime(3);
            Console.WriteLine("The nth prime is " + nprime);

            //
            //Question 10
            //
            int nn = 6;
            for (int i=1; i<nn;i++)
            {
                if (arith.nthPrime(i) > nn)
                {
                    Console.WriteLine(arith.nthPrime(i));
                    break;
                }
            }
        }

        private static int findtwosum(List<int> theList, int v2)
        {
            List<int> resultList2 = new List<int>();
            for (int i = 0; i < theList.Count; i++)
            {
                //Console.WriteLine(numberList.ElementAt(i));
                for (int j = 0; j < theList.Count; j++)
                {
                    //if i==j break maybe continue
                    if (i == j)
                    {
                        break;
                    }
                    //Console.WriteLine(numberList.ElementAt(i));
                    //Console.WriteLine(numberList.ElementAt(j));
                    else if (i != j)
                    {
                        //Console.WriteLine(numberList.ElementAt(i) + numberList.ElementAt(j));
                        //resultList.Add(i);
                        //resultList.Add(j);
                        if ((theList.ElementAt(i) + theList.ElementAt(j)) == v2)
                        {
                            Console.WriteLine(theList.ElementAt(i));
                            Console.WriteLine(theList.ElementAt(j));
                            resultList2.Add(i);
                            resultList2.Add(j);
                        }
                    }


                    //Console.WriteLine(numberList.ElementAt(i) + numberList.ElementAt(j));

                }
            }
            Console.WriteLine(resultList2.Count);
            return resultList2.Count;
        }
    }
}