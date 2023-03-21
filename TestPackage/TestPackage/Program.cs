//version 0.0.1-beta
Wintellect.PowerCollections.Stack<int> stack = new Wintellect.PowerCollections.Stack<int>(5);
for (int i = 0; i < stack.capacity; i++)
{
    stack.Push(i);
}
for (int i = 0; i < stack.capacity; i++)
{
    Console.WriteLine(stack.Pop());
}

Console.WriteLine("\n");
//version 0.0.2-beta
Wintellect.PowerCollections.Stack<int> stack2 = new Wintellect.PowerCollections.Stack<int>(100);
for (int i = 0; i < stack2.capacity; i++)
{
    stack2.Push(i);
}
for (int i = 0; i < stack2.capacity; i++)
{
    Console.WriteLine(stack2.Pop());
}