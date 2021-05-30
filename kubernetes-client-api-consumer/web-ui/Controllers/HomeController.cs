using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using web_ui.Models;
using web_ui.Repositories;
using Microsoft.AspNetCore.Http;

namespace web_ui.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IKubernetesRepository _repository;

        private string _namespace;

        public HomeController(ILogger<HomeController> logger, IKubernetesRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        [Route("setnamespace")]
        public async Task<IActionResult> SetNamespace(string ns)
        {
            try
            {
                // if (string.IsNullOrEmpty(ns))
                // {
                HttpContext.Session.SetString("Namespace", ns);
                // }

                var namespaces = await _repository.GetNamespacesAsync();
                
                return View("Namespaces", SetDefaultNamespace(namespaces, ns));
            }
            catch(Exception)
            {
                return StatusCode (500);
            }
        }

        private IEnumerable<web_ui.Models.NamespaceModel> SetDefaultNamespace(IEnumerable<web_ui.Models.NamespaceModel> namespaceList, string ns)
        {
            var returnList = new List<NamespaceModel>();


            foreach (var item in namespaceList)
            {
                if (item.Name == ns)
                    item.DefaultNamespace = true;
                else
                    item.DefaultNamespace = false;

                returnList.Add(item);
            }

            return returnList;
        }

        private string GetDefaultNamespace() 
        {
            if (HttpContext.Session.GetString("Namespace")!=null)
                _namespace = HttpContext.Session.GetString("Namespace");
            else 
            {
                _namespace = "default";
                HttpContext.Session.SetString("Namespace", _namespace);
            }

            return _namespace;
        }

        [HttpGet]
        [Route("cluster-info")]
        public async Task<IActionResult> GetClusterInfo()
        {
            //return View();
            if (!ModelState.IsValid)
            {
                return BadRequest ();
            }

            try
            {

                var cluster = _repository.GetClusterInfo();
                //return Ok (pods);
                return View("ClusterInfo", cluster);
            }
            catch(Exception)
            {
                return StatusCode (500);
            }
        }

        [HttpGet]
        [Route("nodes")]
        public async Task<IActionResult> GetNodes()
        {
            //return View();
            if (!ModelState.IsValid)
            {
                return BadRequest ();
            }

            try
            {

                var nodes = _repository.GetNodes();
                //return Ok (pods);
                return View("Nodes", nodes);
            }
            catch(Exception)
            {
                return StatusCode (500);
            }
        }

        [HttpGet]
        [Route("services")]
        public async Task<IActionResult> GetServicesByNamespace()
        {
            //return View();
            if (!ModelState.IsValid)
            {
                return BadRequest ();
            }

            try
            {
                var services = await _repository.GetServicesByNamespace(GetDefaultNamespace());
                //return Ok (pods);
                return View("Services", services);
            }
            catch(Exception)
            {
                return StatusCode (500);
            }
        }

        [HttpGet]
        [Route("deployments")]
        public async Task<IActionResult> GetDeploymentsByNamespace()
        {
            //return View();
            if (!ModelState.IsValid)
            {
                return BadRequest ();
            }

            try
            {

                var deployments = await _repository.GetDeploymentsByNamespace(GetDefaultNamespace());
                
                return View("Deployments", deployments);
            }
            catch(Exception)
            {
                return StatusCode (500);
            }
        }

        [HttpGet]
        [Route("replicasets")]
        public async Task<IActionResult> GetReplicaSetByNamespace()
        {
            //return View();
            if (!ModelState.IsValid)
            {
                return BadRequest ();
            }

            try
            {

                var replicasets = await _repository.GetReplicaSetByNamespace(GetDefaultNamespace());
                
                return View("Replicasets", replicasets);
            }
            catch(Exception)
            {
                return StatusCode (500);
            }
        }


        [HttpGet]
        [Route("pods")]
        public async Task<IActionResult> GetPodsByNamespaces()
        {
            //return View();
            if (!ModelState.IsValid)
            {
                return BadRequest ();
            }

            try
            {
                var pods = await _repository.GetPodsAsync (GetDefaultNamespace());
                //return Ok (pods);
                return View("Pods", pods);
            }
            catch(Exception)
            {
                return StatusCode (500);
            }
        }

        [HttpGet]
        [Route("namespaces")]
        public async Task<IActionResult> GetNamespaces()
        {
            //return View();
            if (!ModelState.IsValid)
            {
                return BadRequest ();
            }

            try
            {
                if (HttpContext.Session.GetString("Namespace")!=null)
                    _namespace = HttpContext.Session.GetString("Namespace");
                else 
                {
                    _namespace = "default";
                    HttpContext.Session.SetString("Namespace", _namespace);
                }

                var namespaces = await _repository.GetNamespacesAsync();

                return View("Namespaces", SetDefaultNamespace(namespaces, _namespace));
            }
            catch(Exception)
            {
                return StatusCode (500);
            }
        }

        [HttpGet]
        [Route("pod/logs/{podId}")]
        public async Task<IActionResult> GetLogsByPod([FromQuery (Name = "podId")] string podId)
        {
            //return View();
            if (!ModelState.IsValid)
            {
                return BadRequest ();
            }

            try
            {
                var text = await _repository.GetLogsByPodId ("pod1");

                //return Ok (pods);
                return View("PodLogs", text);
            }
            catch(Exception)
            {
                return StatusCode (500);
            }
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
