using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChainPattern
{
    public interface IAsynChainExecutor
    {
        IEnumerator Execute(IAsynChainResult data);

        bool IsDone {
            get;
        }

        int CurrentIndex {
            get;
        }

        int PieceCount {
            get;
        }
    }
}
