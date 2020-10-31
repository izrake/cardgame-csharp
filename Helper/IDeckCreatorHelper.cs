using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Helper
{
    public interface IDeckCreatorHelper
    {
        List<Card>  GenerateCard();
        List<Card> Shuffle(List<Card> cards);
    }
}
