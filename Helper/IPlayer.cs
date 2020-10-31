using System;
using System.Collections.Generic;
using Test.Models;

namespace Test.Helper
{
    public interface IPlayer
    {
        List<Card> Deal(List<Card> cards);
    }
}
