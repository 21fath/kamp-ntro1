﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T İtem)
        {
            T[] tempArry = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArry.Length; i++)
            {
                items[i] = tempArry[i];
            }

            items[items.Length - 1] = İtem;
        }
    }
}
