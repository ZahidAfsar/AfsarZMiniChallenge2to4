
namespace AfsarZMiniChallenge2to4.Services.second;

public class SecondService : ISecondService
{
    public List<string> greeting = new();
    
     public List<string> NameReturn(string name, string time)
        {
            greeting.Add($"Hello, {name} you woke up at {time} today");
            return greeting;
        }
}
