using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChainPattern
{
    public class GenericAsynChainResult : IAsynChainResult
    {
        public readonly Dictionary<string, object> DataMap = new Dictionary<string, object>();

        public object Get(string key)
        {
            if (DataMap.ContainsKey(key))
            {
                return DataMap[key];
            }
            else
            {
                return null;
            }
        }

        public T GetWithType<T>(string key)
        {
            object readData = Get(key);
            if (readData == null) {
                return default(T);
            } else if (readData is T)
            {
                return (T)readData;
            }
            try
            {
                return (T)Convert.ChangeType(readData, typeof(T));
            }
            catch (InvalidCastException)
            {
                return default(T);
            }
        }

        public void Set(string key, object data)
        {
            DataMap[key] = data;
        }
    }
}
