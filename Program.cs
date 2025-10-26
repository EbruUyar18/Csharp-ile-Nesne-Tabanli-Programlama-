using System;
using System.Security.AccessControl;
class Node
{
    public int Data;
    public Node Next;
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}
class LinkedList
{
    public Node Head;
    public LinkedList()
    {
        Head = null;
    }
    public void AddHead(int data)
    {
        <Node newNode = new Node(data);
        < newNode.Next = Head;
        Head = newNode;
    }
    public void Addlist(int data)
    {
        Node newNode = new Node(data);
        if (Head== null)
        {
            Head = newNode;
            return;
        }
        Node current = Head;
        while(current.Next !=null)
    }
}