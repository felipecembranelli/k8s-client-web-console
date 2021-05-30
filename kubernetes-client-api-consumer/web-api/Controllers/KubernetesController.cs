using System;
using System.Threading.Tasks;
using KubeInspector.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KubeInspector.Controllers
{

  [ApiController]
  [Route("api/kubernetes")]
  public class KubernetesController : ControllerBase
  {

    private readonly IKubernetesRepository _repository;

    public KubernetesController(IKubernetesRepository repository)
    {
      _repository = repository;
    }

    [HttpGet]
    [Route("pods/{ns:alpha:required}")]
    public async Task<IActionResult> GetPodsAsync(string ns = "default")
    {
      if (!ModelState.IsValid)
      {
        return BadRequest ();
      }

      try
      {
        var pods = await _repository.GetPodsAsync (ns);
        return Ok (pods);
      }
      catch(Exception)
      {
        return StatusCode (500);
      }
    }

    [HttpGet]
    [Route("namespaces")]
    public async Task<IActionResult> GetNamespacesAsync()
    {
      if (!ModelState.IsValid)
      {
        return BadRequest ();
      }

      try
      {
        var namespaces = await _repository.GetNamespacesAsync();
        return Ok (namespaces);
      }
      catch(Exception)
      {
        return StatusCode (500);
      }
    }
  }
}
