using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Test_Backend.Entidades;

namespace Test_Backend.Controllers
{
   
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        static HttpClient client = new HttpClient();
        [HttpGet]
        [Route("User")]
        public async Task<IActionResult> User()
        {
            List<User> lstUser = new List<User>();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
            if (response.IsSuccessStatusCode)
            {                
                var json = await response.Content.ReadAsStringAsync();              
                lstUser = JsonConvert.DeserializeObject<List<User>>(json);
               
            }
            return StatusCode(StatusCodes.Status200OK, lstUser);
        }
    }
}
