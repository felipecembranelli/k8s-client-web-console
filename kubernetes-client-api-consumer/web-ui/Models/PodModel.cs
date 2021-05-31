using System.Collections.Generic;

namespace web_ui.Models
{
  public class PodModel
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public string NodeName { get; set; }
    public string PodNamespace { get; set; }
    public string Ready { get; set; }
    public string Restart { get; set; }
    public string Status { get; set; }
    public string IP { get; set; }
    public string CreationTimestamp { get; set; }
    public int TotalContainers { get; set; }
    public List<ContainerModel> Containers { get; set; }

  }
 
}
