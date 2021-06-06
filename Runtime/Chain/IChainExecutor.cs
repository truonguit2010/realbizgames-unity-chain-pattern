using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChainPattern
{
    public interface IChainExecutor
    {
        IChainResult Execute(IChainResult data);
    }
}
