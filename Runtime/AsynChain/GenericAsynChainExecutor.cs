using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChainPattern
{
    public class GenericAsynChainExecutor : IAsynChainExecutor
    {
        private bool _isDone = false;
        public readonly List<IAsynPieceExecutor> pieces = new List<IAsynPieceExecutor>();

        public void AddPiece(IAsynPieceExecutor piece)
        {
            this.pieces.Add(piece);
        }

        private int _currentIndex = -1;

        public IEnumerator Execute(IAsynChainResult data)
        {
            _isDone = false;
            foreach (IAsynPieceExecutor e in this.pieces)
            { 
                ++_currentIndex;
                e.Execute(data);
                yield return new WaitUntil(() => e.IsDone);
                data.Set(e.Result.GetKey(), e.Result);
            }
            _isDone = true;
            yield return 0;
        }

        public bool IsDone {
            get {
                return _isDone;
            }
        }

        public int CurrentIndex {
            get {
                return _currentIndex;
            }
        }

        public int PieceCount {
            get {
                return this.pieces.Count;
            }
        }
    }
}