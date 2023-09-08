using System;
using System.Linq.Expressions;

class DumbWaysToFillAnArray
{
    static void Main()
    {
        TryCatch();
        //IndexOf();
        //List();
        //Diccionary();
    }

    static void TryCatch()
    {
        int[] arreglo = new int[128];
        int i = 0;
        while (true)
        {
            try
            {
                arreglo[i] = i;
                i++;
            }
            catch (System.IndexOutOfRangeException)
            {
                break;
            }
        }
        i = 0;
        while (true)
        {
            try
            {
                Console.WriteLine(arreglo[i]);
                i++;
            }
            catch (System.IndexOutOfRangeException)
            {
                break;
            }
        }
    }
    static void IndexOf()
    {
        int[] arreglo = new int[128];
        arreglo[127] = 1;
        for (int i = 0; i < Array.IndexOf(arreglo, 1); i++)
        {
            if (i != 1)
                arreglo[i] = i;
        }
        for (int i = 0; i < Array.IndexOf(arreglo, 1); i++)
        {
            Console.WriteLine(arreglo[i]);
        }
    }
    static void Diccionary()
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        int[] arreglo = new int[128];

        for (int i = 0; i < arreglo.Length; i++)
        {
            dictionary[i] = i;
        }

        foreach (var kvp in dictionary)
        {
            arreglo[kvp.Key] = kvp.Value;
        }

        foreach (var item in arreglo)
        {
            Console.WriteLine(item);
        }
    }
    static void List()
    {
        List<int> list = new List<int>();
        int[] arreglo = new int[128];
        int i = 0;
        foreach (int element in arreglo)
        {
            list.Add(i);
            i++;
        }
        i = 0;
        foreach (int element in list)
        {
            arreglo[i] = element;
        }
        i = 0;
        do
        {
            arreglo[i] = i;
            i++;
            list.RemoveAt(0);
        } while (list.Count > 0);
    }
}