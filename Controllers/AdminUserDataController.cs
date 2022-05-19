﻿using microservice2.Database.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace microservice2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUserDataController : ControllerBase
    {
        public List<AdminModel> adminUserList = new List<AdminModel>()
        {
            new AdminModel
            {
              UserFirstName="Gopal",
            UserMiddleName="Kumar",
        UserLastName ="Singh",
         Address ="Noida",
         EmailId="gopal@gmail.com",
         UniQueHousNo="2304",
         PhoneNo="987654321",
         


         UserName="gopal",
         Password="gopal",
         Role="Admin"
       



    }
};
        // GET: api/<New2Controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(adminUserList);
        }

        // GET api/<New2Controller>/5
        

        // POST api/<New2Controller>
       
    }
}
