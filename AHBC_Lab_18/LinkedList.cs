using System;
using System.Collections.Generic;
using System.Linq;

public static class LinkedList
{
    public static bool InsertAt<T>(this LinkedList<T> list, int index, T o)
    {
        var count = list.Count;
        var boolValue = false;

        if (index >= count)
        {
            boolValue = false;
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                if (i == index)
                {
                    list.AddLast(o);
                }
                list.AddLast(list.ElementAt(i));
            }
            for (int i = 0; i < count; i++)
            {
                list.RemoveFirst();
            }
            boolValue = true;
        }
        return boolValue;
    }

    public static bool RemoveAt<T>(this LinkedList<T> list, int index)
    {
        var count = list.Count;
        var boolValue = false;
        if (index >= count)
        {
            boolValue = false;
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                if (i != index)
                {
                    list.AddLast(list.ElementAt(i));
                }
            }
            for (int i = 0; i < count; i++)
            {
                list.RemoveFirst();
            }
            boolValue = true;
        }
        return boolValue;
    }

    public static void PrintReverse<T>(this LinkedList<T> list)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(list.ElementAt(i));
        }
    }
}
