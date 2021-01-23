using System;
using System.Collections.Generic;
using System.Text;

namespace LastProject
{
    class MyDictionary<T1>
    {
        T1[] keys;
        //T2[] values;

        public MyDictionary()
        {
            keys = new T1[0];
           // values = new T2[0];
        }

        public void Add(T1 key)
        {
            T1[] _tempKeys = keys;
            //T2[] _tempValues= values;

            keys = new T1[keys.Length + 1];
            //values = new T2[keys.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                keys[i] = _tempKeys[i];
               // values[i] = _tempValues[i];

            }

            keys[keys.Length - 1] = key;
            //values[values.Length - 1] = value;
        }

        public int Lenght()
        {
            return keys.Length;
        }

        public T1[] Keys()
        {
           s return keys;
        }
        //public T2[] Values()
        //{
        //    return values;
        //}
    }
}
