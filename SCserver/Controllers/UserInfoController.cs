using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCserver.Model;
using SCserver.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly UserServers _userServers;

        public UserInfoController(
            UserServers sv
            )
        {
            _userServers = sv;
        }



        [HttpPost("SearchUser")]
        public Dto SearchUser([FromBody] Inputs data)
        {
            if (data == null)
            {
                var Nodata = new Dto() { IsExist = false };
                return Nodata;
            }
            var UserResult = _userServers.SearchUser(data.PolicyNumber);
            if (UserResult == null)
            {
                var Nodata = new Dto() { IsExist = false };
                return Nodata;
            }
            var returnData = new Dto() { firstName = UserResult.firstName, lastName = UserResult.lastName, dob = UserResult.dataOfBirth,IsExist = true };
            return returnData;
        }

    }
}
