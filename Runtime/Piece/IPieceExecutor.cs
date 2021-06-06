using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ChainPattern
{
    public interface IPieceExecutor
    {
        IPieceResult Execute(IChainResult data);
    }
}