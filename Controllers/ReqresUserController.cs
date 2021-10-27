using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using userApi.Models;

namespace userApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReqresUserController : ControllerBase
    {
        [HttpGet]
        [Route("GetUsers")]
        public async Task<ActionResult<GeneralUser>> GetUsers(int page,int perpage)
        {
            //Hosted web API REST Service base url
            string Baseurl = "https://reqres.in/api/";

            GeneralUser generalUser = new GeneralUser();
            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();

                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource using HttpClient
                //HttpResponseMessage Res = await client.GetAsync("users?page=1&per_page=4");
                HttpResponseMessage Res = await client.GetAsync($"users?page={page}&per_page={perpage}");

                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var UserResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into User
                    generalUser = JsonConvert.DeserializeObject<GeneralUser>(UserResponse);
                }

                //returning the User
                return generalUser;
            }
        }

    }
}
