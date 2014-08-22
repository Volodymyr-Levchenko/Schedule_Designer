using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using Schedule_designer.Models;
using Schedule_designer.DAL;

namespace Schedule_designer.Controllers
{
    public class IndexController : ApiController
    {

        private Repository<Schedule> scheduleRepository;
        private Repository<activity_type> activityTypesRepository;
        private Repository<activity_class> activityClassRepository;

        public void InitRepos()
        {
            var dbContext = new ScheduleEntities();
            scheduleRepository = new Repository<Schedule>(dbContext);
            activityTypesRepository = new Repository<activity_type>(dbContext);
            activityClassRepository = new Repository<activity_class>(dbContext);
        }
        [Route("getAll")]
        public IHttpActionResult Get()
        {
            var result = activityClassRepository.GetAll();
            return Ok(result);
            
        }

        public activity_class Get(int id)
        {
            return activityClassRepository.GetById(id);
        }
    }
}
