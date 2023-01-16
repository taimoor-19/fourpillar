using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace fourpillar
{
    public class Program
    {
        List<int> id = new List<int>();
        static void Main(string[] args)
        {
            
            subtract s1= new subtract();
            s1.input();
            s1.sub();
           
            
            Thread childThread = new Thread(s1.output);
            childThread.Start();

            ADD s2 = new ADD();
            s2.input();
            s2.add();
            
            Thread chil= new Thread(s2.output);
           
           
              chil.Start();
            

              Console.ReadLine();

        }
    }
   

    interface icalulator
    {

        void input();
        void output();
    }

    class ADD : icalulator
    {

        protected int x;
        public int y;
        public int ans;
        public void input()
        {
            Console.WriteLine("enter the numbers you want to add : ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
        }
        public void add()
        {
            ans = x + y;

        }
        public void output()
        {
            Console.WriteLine("your answer is : {0}", ans);

        }
    }

    class subtract : ADD
    {

        public new void input()
        {
            Console.WriteLine("enter the numbers you want to subtract : ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
        }
        public void sub()
        {
            ans = x - y;
        }
        public new  void output()
        {
            Console.WriteLine("your answer is : {0}", ans);

        }


    }



}
