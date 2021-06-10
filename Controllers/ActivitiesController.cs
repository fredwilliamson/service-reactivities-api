using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivitiesController: ControllerBase
    {
        private readonly IActivitiesServices _activitiesServices;

        public ActivitiesController(IActivitiesServices activitiesServices)
        {
            _activitiesServices = activitiesServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> getActivities()
        {
           return await _activitiesServices.FindAllActivities();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> getActivity(Guid id)
        {
            return await _activitiesServices.FindActivityById(id);
        }
    }
}