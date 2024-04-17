class Store<T>
{
    public T[] AddInfoArr (T[] arr, T info)
    {
        T[] temp = new T[arr.Length + 1];

        for (int i = 0; i < arr.Length; i++)
        {
            temp[i] = arr[i];
        }
        temp[temp.Length - 1] = info;
        return temp;
    }
    public T[] DeleteInfoArr (T[] arr, T info)
    {
        T[] temp = new T[arr.Length - 1];

        for (int i = 0, k = 0; i < arr.Length; i++)
        {
            if (Convert.ToString(arr[i]) != Convert.ToString(info))
            {
                temp[k] = arr[i];
                k++;
            }
        }
        return temp;
    }
    public void GetInfoArr(T[] arr, int index) => Console.WriteLine($"{index} элемент массива - это {arr[index - 1]}");
    public void GetInfoLengthToArr(T[] arr) => Console.WriteLine($"Длина массива: {arr.Length}");
}
internal class Program
{
    private static void Main(string[] args)
    {
        Store <int> intStore = new();
        Store <double> doubleStore = new();
        Store <string> stringStore = new();

        int[] ints = { 1, 2, 3 };
        double[] doubles = { 1.2, 2.2, 3.3, 4.4 };
        string[] strings = { "one", "two", "three", "four","five" };

        intStore.GetInfoLengthToArr(ints);
        doubleStore.GetInfoLengthToArr(doubles);
        stringStore.GetInfoLengthToArr(strings);

        Console.WriteLine("\n");

        intStore.GetInfoArr(ints, 2);
        doubleStore.GetInfoArr(doubles, 4);
        stringStore.GetInfoArr(strings, 1);

        ints = intStore.AddInfoArr(ints, 5);
        doubles = doubleStore.AddInfoArr(doubles, 5.5);
        strings = stringStore.AddInfoArr(strings, "six");

        ints = intStore.DeleteInfoArr(ints, 3);
        doubles = doubleStore.DeleteInfoArr(doubles, 3.3);
        strings = stringStore.DeleteInfoArr(strings, "one");
    }
} 