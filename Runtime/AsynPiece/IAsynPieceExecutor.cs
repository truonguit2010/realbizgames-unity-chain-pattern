using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChainPattern
{
    public interface IAsynPieceExecutor
    {
        void Execute(IAsynChainResult data);

        bool IsDone {
            get;
        }

        IAsynPieceResult Result {
            get;
        }
    }
}
