
using AfsarZMiniChallenge2to4.Services.first;

namespace AfsarZMiniChallenge2to4.Services;

public class FirstService : IFirstService
{
    public List<string> add = new();
    public List<string> NumReturn(int numOne, int numTwo)
    {
       int total = numOne + numTwo;
        add.Add($"{numOne} + {numTwo} = {total}");
        return add;
    }
}
