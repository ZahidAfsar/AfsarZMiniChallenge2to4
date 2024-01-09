using System.Xml.Schema;
using Microsoft.AspNetCore.Mvc;

namespace AfsarZMiniChallenge2to4.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class FirstEndpointController : ControllerBase
    {
        public List<string> add = new();

        [HttpPost]
        [Route("NumReturn/{numOne}/{numTwo}")]

        public List<string> NumReturn(int numOne, int numTwo)
        {
            int total = numOne + numTwo;
            add.Add($"{numOne} + {numTwo} = {total}");
            return add;
        }

    }
