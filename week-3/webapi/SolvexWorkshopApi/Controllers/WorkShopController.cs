using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolvexWorkshopApi.Model.Entities;
using SolvexWorkshopApi.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolvexWorkshopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkShopController : ControllerBase
    {
        private readonly IWorkShopService _workshopService;

        public WorkShopController(IWorkShopService workshopService)
        {
            _workshopService = workshopService;
        }

        [HttpGet(nameof(GetAllWorkShops))]
        public IActionResult GetAllWorkShops()
        {
            var res = _workshopService.GetAllWorkShops();
            if(res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }        
        
        [HttpGet(nameof(GetWorkShop))]
        public IActionResult GetWorkShop(int id)
        {
            var res = _workshopService.GetWorkShop(id);
            if(res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }

        [HttpPost(nameof(InsertWorkShop))]
        public IActionResult InsertWorkShop(WorkShop workshop)
        {
            _workshopService.InsertWorkShop(workshop);
            return Ok("Data saved");
        }

        [HttpPut(nameof(UpdateWorkShop))]
        public IActionResult UpdateWorkShop(WorkShop workshop)
        {
            _workshopService.UpdateWorkShop(workshop);
            return Ok("Data updated");
        }

        [HttpDelete(nameof(DeleteWorkShop))]
        public IActionResult DeleteWorkShop(int id)
        {
            _workshopService.DeleteWorkShop(id);
            return Ok("Data deleted");
        }
    }
}
