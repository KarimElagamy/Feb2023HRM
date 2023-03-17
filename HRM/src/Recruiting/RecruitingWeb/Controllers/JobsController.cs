using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobService _jobService;
        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }
        
        // http://exmple.com/jobs/index 
        // Hosted this webapp on the server, Azure-windows, azure linux
        // U1 ->  http://exmple.com/jobs/index 
        // U2, u3, u4....
        // 10:00 AM 300 users accesing your website, 200 are accessing index methods
        public IActionResult Index()
        {
            // we need to get list of Jobs
            // call the Job Service
           // var jobsController = new JobController(new JobService());
           // jobsController.Index();
           
           // ASP.NET will assign a thread from thread pool (collection of threads) to do this task
           // T  1-100 threads
           // T1 -> 
           // database
           // I/O bound -> go to this URL and fetch me some data/image network, file download
           // database calls
           
           // CPU bound => loan caluation, large PI number, resizing proceswing
           // I/O bound 2 sec, 10 ms, 10 sec, 300 ms
           // network, location , database disk SSD, hard drive, SQL slow or fast , might be not optimized
           // waiting 
           //  prevent Thread starvation
            var jobs = _jobService.GetAllJobs();
            return View(jobs);
        }

        public IActionResult Details(int id)
        {
            // get job by Id
          
            var job = _jobService.GetJobById(id);
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}