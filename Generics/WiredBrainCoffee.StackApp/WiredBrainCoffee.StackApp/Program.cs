stackDoubles();
stackString();

static void stackDoubles()
{
    var stack = new SimpleStack<double>();

    stack.Push(1.2);
    stack.Push(3.7);
    stack.Push(5.6);

    while (stack.count > 0)
    {
        var item = stack.Pop();

        Console.WriteLine(item);
    }
}

static void stackString()
{
    var stack = new SimpleStack<string>();

    stack.Push("shakil");
    stack.Push("yousuf");
    stack.Push("robin");

    while (stack.count > 0)
    {
        var item = stack.Pop();

        Console.WriteLine(item);
    }
}