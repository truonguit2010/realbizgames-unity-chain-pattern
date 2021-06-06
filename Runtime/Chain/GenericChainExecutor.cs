using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChainPattern
{
    public class GenericChainExecutor : IChainExecutor
    {
        public readonly List<IPieceExecutor> pieces = new List<IPieceExecutor>();

        public void AddPiece(IPieceExecutor piece)
        {
            this.pieces.Add(piece);
        }

        public IChainResult Execute(IChainResult data = null)
        {
            if (data == null)
            {
                data = new GenericChainResult();
            }
            foreach (IPieceExecutor e in this.pieces)
            {
                IPieceResult r = e.Execute(data);
                data.Set(r.GetKey(), r);
            }
            return data;
        }
    }
}