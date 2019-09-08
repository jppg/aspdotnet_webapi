using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aquila.Models;

[Route("api/[controller]")]
[ApiController]
public class ListScreenController : ControllerBase 
{ 
    [HttpGet] 
    public ActionResult<IEnumerable<ListScreen>> GetAll()
    {
        return new []
        {
            new ListScreen { Name = "Configurations" },
            new ListScreen { Name = "Admin" },
            new ListScreen { Name = "Accounts" }
        };
    }
}

