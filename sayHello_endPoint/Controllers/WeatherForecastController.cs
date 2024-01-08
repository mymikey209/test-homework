

using Microsoft.AspNetCore.Mvc;

namespace say_hello_endpoint.controller;


[ApiController]
[Route("[controller]")]
    public class Controller: ControllerBase
    {
        public List <string> greeting = new();
        [HttpPost]
        [Route("Hello/{name}")]
        public List <string> Hello(string name)
        {
            greeting.Add($"Hello, {name}");
            return greeting;
        }

    }
