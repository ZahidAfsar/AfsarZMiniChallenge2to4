using Microsoft.AspNetCore.Mvc;

namespace AfsarZMiniChallenge2to4.Controllers;

    public class SecondEndpointController : ControllerBase
    {
        public List<string> greeting = new();

        [HttpPost]
        [Route("NameReturn/{name}/{time}")]

        public List<string> NameReturn(string name, string time)
        {
            greeting.Add($"Hello, {name} you woke up at {time} today");
            return greeting;
        }
    }
