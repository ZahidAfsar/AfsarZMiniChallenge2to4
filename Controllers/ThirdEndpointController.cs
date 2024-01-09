using AfsarZMiniChallenge2to4.Services.third;
using Microsoft.AspNetCore.Mvc;

namespace AfsarZMiniChallenge2to4.Controllers;

    public class ThirdEndpointController : ControllerBase
    {
    private readonly IThirdService _thirdService;

    public ThirdEndpointController(IThirdService thirdService)
       {
        _thirdService = thirdService;
    }

        [HttpPost]
        [Route("NumCompare/{numOne}/{numTwo}")]

        public List<string> NumCompare(int numOne, int numTwo)
        {
            return _thirdService.NumCompare(numOne, numTwo);
        }

    }
