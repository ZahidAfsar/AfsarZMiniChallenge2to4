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

        [HttpGet]
        [Route("NumCompare/{numOneString}/{numTwoString}")]

        public string NumCompare(string numOneString, string numTwoString)
        {
            return _thirdService.CompareNums(numOneString, numTwoString);
        }

    }
