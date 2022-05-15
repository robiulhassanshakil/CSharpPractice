stackDoubles();

static void stackDoubles()
{
    var stack = new SimpleStack();

    stack.Push(1.2);
    stack.Push(3.7);
    stack.Push(5.6);

    while (stack.count > 0)
    {
        var item = stack.Pop();

        Console.WriteLine(item);
    }
}