using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Node a = new Node("a");
		Node b = new Node("b");
		Node c = new Node("c");
		Node d = new Node("d");
		Node e = new Node("e");
		Node f = new Node("f");
		
		a.Left = b;
		a.Right = c;
		b.Left = d;
		b.Right = e;
		c.Right = f;
		
		Stack<Node> stack = new Stack<Node>();
		stack.Push(a);
		while(stack.Count > 0) {
			Node current = stack.Pop();
			Console.Write($"{current.Value} ");
			if(current.Right is not null) stack.Push(current.Right);
			if(current.Left is not null) stack.Push(current.Left);
		}
		
	}
}

public class Node {
	public Node Left { get; set; } = null!;
	public Node Right { get; set; } = null!;
	public String Value { get; set; }
	public Node(String v) {
		Value = v;
	}
}
