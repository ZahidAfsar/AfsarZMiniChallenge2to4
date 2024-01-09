using System.Xml.Schema;
using AfsarZMiniChallenge2to4.Services.first;
using Microsoft.AspNetCore.Mvc;

namespace AfsarZMiniChallenge2to4.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class FirstEndpointController : ControllerBase
    {
    private readonly IFirstService _firstService;
    
        public FirstEndpointController(IFirstService firstService)
        {   
         _firstService = firstService;
        }

        [HttpGet]
        [Route("NumReturn/{numOne}/{numTwo}")]

        public string NumReturn(string numOne, string numTwo)
        {
            return _firstService.NumReturn(numOne, numTwo);
        }

    }
