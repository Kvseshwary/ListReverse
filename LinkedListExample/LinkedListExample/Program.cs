using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListExample
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }
        public void print()
        {
            Console.Write("|" + data + "|->");
            if (next != null)
            {
                next.print();
            }
           

        }

        public void AddSorted(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }

            else if (data < next.data)
            {
                Node temp = new Node(data);//Only new data
                temp.next = this.next;//new pointer=existing pointer
                this.next = temp;     //existing pointer=new  pointer
            }
            else
            {
                next.AddSorted(data);
            }
        }
        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }

      


    }

    public class MyList
    {
        public Node headNode;

        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }
        public void AddSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }
        public void AddToBeginning(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp.next;
            }
        }

       

        public void print()
        {
            if (headNode != null)
                headNode.print();
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            Console.WriteLine("Enter Positive  Number(1 to N)");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} Numbers(1 to 10)", a);
            var result = Console.ReadLine().Split(new[] { ' ' })
                       .Select(j => int.Parse(j))
                       .ToList();
            
            MyList list = new MyList();
            ArrayList myArrayList = new ArrayList();
            List<int> myGenList = new List<int>();

            for (int i = 0; i < a; i++)
            {
                int first = result[i];
                list.AddToEnd(first);
                myArrayList.Add(result[i]);
                myGenList.Add(result[i]);
                
            }
            list.print();

            Console.WriteLine("\n ArrayList Follows");
            foreach (int lst in myArrayList)
            {

                Console.WriteLine(lst);

            }
            //LINQ Method

            
            //LINQ Query

            Console.WriteLine("\n GenericList Follows");
            /*var MaxNum = from varList in myGenList
                         group varList by varList into g
                         orderby g.Max() descending
                         select g;*/
            var MaxNum = from varList in myGenList
                         
                         group varList by varList into g
                         orderby g.Max() descending
                         select g;

             foreach(var car in MaxNum)
                 Console.WriteLine("No of times no appear {0}",car.Key);

          //   var MaxNum1=myGenList.where(p=>

            

            /*IGrouping<int, int> max =
                               myGenList.GroupBy(n => n)
                               
                               .OrderByDescending(g=>g.Count())
                               .First();
            */
             IGrouping<int, int> max =
              myGenList.GroupBy(n => n)
              .OrderByDescending(g => g.Count())
              .ThenByDescending(g=>g.Key)
              .First();

             //Console.WriteLine("\nValues that have the key '{0}':", group.Key);
                                 Console.WriteLine(
                                   "Maximum number repeated is " + max.Key +
                                   " and it is repeated " + max.Count() + " times");

                               //  myGenList.ForEach(p => Console.WriteLine(p));

                                /* var studentQuery2 =
                         from student in myGenList
                         group student by student into g
                         orderby g descending
                         
                         select g;*/


                                 var query = myGenList.GroupBy(p =>p)
                                                               .OrderByDescending(g => g.Count())
                                                               .ThenByDescending(g=>g.Key)
                                                               .First();
                                 Console.WriteLine("Maximum number repeated is " + query.Key +
                                                  " and it is repeated " + query.Count() + " times");
                                 Console.WriteLine("{0}", query.Key);

            /*list.AddToEnd(first);
            list.AddToEnd(5);
            list.AddToEnd(7);
            list.AddToEnd(11);
            list.print();*/

            /*list.AddSorted(9);
            list.AddSorted(5);
            list.AddSorted(7);
            list.AddSorted(11);
            list.print();*/
            /*
            list.AddToBeginning(9);
            list.AddToBeginning(5);
            list.AddToBeginning(7);
            list.AddToBeginning(11);
            list.print();
            */
            
            /*Node myNode = new Node(7);
            myNode.AddToEnd(5);
            myNode.AddToEnd(4);
            myNode.AddToEnd(11);

            myNode.print();*/

                /*Adding using next next at end of node
                  * myNode.next = new Node(5);
                   myNode.next.next = new Node(11);
                   myNode.next.next.next = new Node(4);
                   myNode.print();*/                                              
            Console.ReadLine();
        }
    }
}
