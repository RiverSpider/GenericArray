public class GenericArray<T>
{
    private T[] array;
    private int size;

    public GenericArray(int capacity)
    {
        this.array = new T[capacity];
        this.size = 0;
    }

    public void Add(T element)
    {
        if (size == array.Length)
        {
            Array.Resize(ref array, array.Length * 2);
        }
        array[size++] = element;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= size)
        {
            throw new IndexOutOfRangeException();
        }
        return array[index];
    }

    public void Remove(int index)
    {
        if (index < 0 || index >= size)
        {
            throw new IndexOutOfRangeException();
        }
        Array.Copy(array, index + 1, array, index, size - index - 1);
        array[--size] = default(T);
    }
}

