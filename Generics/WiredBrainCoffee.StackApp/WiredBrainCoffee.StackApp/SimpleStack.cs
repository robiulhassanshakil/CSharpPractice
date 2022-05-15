public class SimpleStack
{
    public readonly double[] _items;
    public SimpleStack()
    {
        _items = new double[10];
    }
    public int curentIndex = -1;
    public int count => curentIndex +1;
    public void Push(double item) => _items[++curentIndex] = item;
    public double Pop() => _items[curentIndex--];

}