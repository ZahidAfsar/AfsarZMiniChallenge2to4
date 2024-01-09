
using AfsarZMiniChallenge2to4.Services.first;

namespace AfsarZMiniChallenge2to4.Services;

public class FirstService : IFirstService
{
    public string NumReturn(string numOne, string numTwo)
    {
        int OneInt;
        bool isNumTrue = int.TryParse(numOne, out OneInt);

        int TwoInt;
        bool isNumTwoTrue = int.TryParse(numTwo, out TwoInt);

        if(isNumTrue && isNumTwoTrue)
        {
            return $"{OneInt} + {TwoInt} is {OneInt + TwoInt}";
        }else{
            return "Please enter an Integer Value";
        }
    }
}
