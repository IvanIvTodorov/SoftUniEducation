using Component.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Component.Contracts
{
    public interface IGiftOperations
    {
        void Add(GiftBase gift);
        void Remove(GiftBase gift);

    }
}
