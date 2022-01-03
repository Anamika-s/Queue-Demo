using System;
public class Node
{
    public Node Next;
    public object Value;
}
public class LinkedList
{
   private Node first;
   private Node last;//This will have latest node
   public int Count;

public LinkedList()
{
  first = new Node();
  last = first;
}
public void AddAtfirst(object data)
{
   Node newNode = new Node();
   newNode.Value = data;
   last.Next = newNode;
   last = newNode;
   Count++;
}
// public void AddInBetween(object data)
// {

// }
public void AddAtStart(object data)
{
  Node newNode = new Node() { Value = data};
  newNode.Next = first.Next;//new node will have reference of first's next reference
  first.Next = newNode;//and now first will refer to new node
  Count++;
}
public void RemoveFromStart()
{
   if (Count > 0)
   {
     first.Next = first.Next.Next;
     Count--;
   }
   else
   {
     Console.WriteLine("No element exist in this linked list.");
   }
}/// <summary>
/// Traverse from first and print all nodes value
/// </summary>

public void PrintAllNodes()
{
//Traverse from first
Console.Write("first ->");
Node curr = first;
while (curr.Next != null)
{
curr = curr.Next;
Console.Write(curr.Value);
Console.Write("->");
}
Console.Write("NULL");
}
}
class Program
{
    static void Main(string[] args)
    {           
        LinkedList lnklist = new LinkedList();
        lnklist.PrintAllNodes();
        Console.WriteLine();

        lnklist.AddAtfirst(12);
        lnklist.AddAtfirst("John");
        lnklist.AddAtfirst("Peter");
        lnklist.AddAtfirst(34);
        lnklist.PrintAllNodes();
        Console.WriteLine();

        lnklist.AddAtStart(55);
        lnklist.PrintAllNodes();
        Console.WriteLine();

        lnklist.RemoveFromStart();
        lnklist.PrintAllNodes();

        Console.ReadKey();
    }
}