using System;

namespace QueueDemo
{
    class Program
    {
        static int [] num = new int[] { 0,0, 0, 0,0,0,0,0,0,0};
        static int front=-1;
        static int rear=-1;
        static void Main(string[] args)
        {

   string ch = "y";
    while(ch=="y")
    {
        Menu();
        int choice ;
        Console.WriteLine("Enter your choice");
        choice = Int32.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1: 
            {  Console.WriteLine("Enter number");
              int x = Int32.Parse(Console.ReadLine());
            Enqueue(x);
            //    Console.WriteLine("Front points to " + front + " location");
            //    Console.WriteLine("Rear points to " + rear + " location");
             break;
            }
            case 2: {
                    Dequeue(); 
                    //Console.WriteLine("Top points to " + top + " location");
                    break;
            }
            case 3 : Display(); break;

        }
         Console.WriteLine("Want to continue ? ");
         ch = Console.ReadLine();

    }      
        }
        static void Menu()
        {
            Console.WriteLine(" Main Menu ");
            Console.WriteLine("1. Insert ");
            Console.WriteLine("2. Delete ");
            Console.WriteLine("3. Display ");

        }
        static void Enqueue(int x)
        { 
           if(rear == num.Length)
            Console.WriteLine("Overflow");
            else if(front == -1 && rear ==-1 )
            {
                num[++front] = x;
                rear++;
            }
            else 
                        {
            num[++rear] = x;
                    }
        }
        static void Dequeue()
        {
            if(front ==-1 || front == num.Length)
            Console.WriteLine("Underflow");
            else 
            { 
             num[front] =0;
             front = front + 1;
            }
            }
        static void Display()
        {
           for(int i = front ;i<=rear; i++)
           Console.WriteLine(num[i]);
        }
    }
}
