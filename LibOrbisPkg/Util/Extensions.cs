﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibOrbisPkg.Util
{
  public static class DictionaryExtensions
  {
    public static V GetOrDefault<K,V>(this Dictionary<K,V> d, K key, V def = default(V))
    {
      if (d.ContainsKey(key)) return d[key];
      return def;
    }
  }

  public static class ArrayExtensions
  {
    public static T[] Fill<T>(this T[] arr, T val)
    {
      for (var i = 0; i < arr.Length; i++)
      {
        arr[i] = val;
      }
      return arr;
    }
  }
#if !CORE
  public static class TupleExtension
  {
    public static void Deconstruct<T1,T2>(this Tuple<T1, T2> twople, out T1 item1, out T2 item2)
    {
      item1 = twople.Item1;
      item2 = twople.Item2;
    }
  }
#endif
}
