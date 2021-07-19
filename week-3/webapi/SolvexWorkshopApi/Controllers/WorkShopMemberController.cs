using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolvexWorkshopApi.Model.Entities;
using SolvexWorkshopApi.Services.Services;

namespace SolvexWorkshopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkShopMemberController : ControllerBase
    {
        private readonly IWorkShopMember _workShopMemberService;

        public WorkShopMemberController(IWorkShopMember workShopMemberService)
        {
            _workShopMemberService = workShopMemberService;
        }

        [HttpGet(nameof(GetAllWorkShopMembers))]
        public IActionResult GetAllWorkShopMembers()
        {
            var res = _workShopMemberService.GetAllWorkShopMembers();
            if(res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }

        [HttpGet(nameof(GetWorkShopMember))]
        public IActionResult GetWorkShopMember(int id)
        {
            var res = _workShopMemberService.GetWorkShopMember(id);
            if(res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(InsertWorkShopMember))]
        public IActionResult InsertWorkShopMember(WorkShopMember workshopmember)
        {
            _workShopMemberService.InsertWorkShopMember(workshopmember);
            return Ok("Data saved");
        }

        [HttpPost(nameof(UpdateWorkShopMember))]
        public IActionResult UpdateWorkShopMember(WorkShopMember workshopmember)
        {
            _workShopMemberService.UpdateWorkShopMember(workshopmember);
            return Ok("Data updated");
        }

        [HttpDelete(nameof(DeleteWorkShopMember))]
        public IActionResult DeleteWorkShopMember(int id)
        {
            _workShopMemberService.DeleteWorkShopMember(id);
            return Ok("Data deleted");
        }
    }
}
