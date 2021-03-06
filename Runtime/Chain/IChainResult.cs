using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChainPattern
{
    public interface IChainResult
    {
        object Get(string key);

        T GetWithType<T>(string key);

        void Set(string key, object data);
    }
}