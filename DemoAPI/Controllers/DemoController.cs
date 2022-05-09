using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/demo")]
    public class DemoController : ControllerBase
    {
        private static List<TemperatureDto> temperatureList = new List<TemperatureDto>
        { new TemperatureDto
        {
            Timestamp = DateTime.Now,
            Value = 5.6
        },new TemperatureDto
        {
            Timestamp = DateTime.Now.AddDays(1),
            Value = 15.7
        } };



        [HttpGet("get1")]
        public List<TemperatureDto> GetTemperatures()
        {
            return temperatureList;
        }

        [HttpGet("get2/{id:int}")]
        public List<TemperatureDto> GetTemperatures2(int id)
        {
            return temperatureList;
        }
    }
    public class TemperatureDto
    {
        public DateTime Timestamp { get; set; }
        public double Value { get; set; }
    }
}
