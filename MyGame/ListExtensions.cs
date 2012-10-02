using System;
using System.Collections.Generic;

namespace MyGame
{
    public static class ListExtensions
    {
        public static void Shuffle<T>(this List<T> list)
        {
            Random random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T item = list[k];
                list[k] = list[n];
                list[n] = item;
            }
        }
    }
}