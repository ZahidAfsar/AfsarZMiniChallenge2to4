using Microsoft.AspNetCore.Mvc;

namespace AfsarZMiniChallenge2to4.Controllers;

    public class ThirdEndpointController : ControllerBase
    {
         public List<string> GreaterOrLess = new();

        [HttpPost]
        [Route("NumCompare/{numOne}/{numTwo}")]

        public List<string> NumCompare(int numOne, int numTwo)
        {
            if( numOne > numTwo){
                GreaterOrLess.Add($"{numOne} is greater than {numTwo}");
                 GreaterOrLess.Add($"{numTwo} is greater than {numOne}");
            }else if(numOne < numTwo){
                GreaterOrLess.Add($"{numOne} is less than {numTwo}");
                GreaterOrLess.Add($"{numTwo} is greater than {numOne}");
            }else{
                GreaterOrLess.Add("Your first number is equal to your second");
                GreaterOrLess.Add("Your second number is equal to your first");

            }
            return GreaterOrLess;
        }


    }
