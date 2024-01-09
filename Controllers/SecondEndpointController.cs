using AfsarZMiniChallenge2to4.Services.second;
using Microsoft.AspNetCore.Mvc;

namespace AfsarZMiniChallenge2to4.Controllers;

    public class SecondEndpointController : ControllerBase
    {
    private readonly ISecondService _secondService;

    public SecondEndpointController(ISecondService SecondService)
    {
        _secondService = SecondService;
    }

        [HttpGet]
        [Route("NameReturn/{name}/{time}")]

        public List<string> NameReturn(string name, string time)
        {
            return _secondService.NameReturn(name, time);
        }
    }
