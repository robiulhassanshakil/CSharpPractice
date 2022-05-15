public class SimpleStack<T>
{
    public readonly T[] _items;
    public SimpleStack()
    {
        _items = new T[10];
    }
    public int counter = -1;
    public int count => counter +1;
    public void Push(T item) => _items[++counter] = item;
    public T Pop() => _items[counter--];

}