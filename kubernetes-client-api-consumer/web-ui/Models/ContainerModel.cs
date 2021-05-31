using System.Collections.Generic;

namespace web_ui.Models
{
  public class ContainerModel
  {
    public string Name { get; set; }
    public string Image { get; set; }
    public string WorkingDir { get; set; }
    public bool? Ready { get; set; }
    public int? RestartCount { get; set; }
    public IEnumerable<EnviromentVariable> Env { get; set; }
    public IEnumerable<ContainerPort> Port { get; set; }
    public ContainerLivenessProbe LivenessProbe { get; set; }
    public ContainerReadynessProbe ReadynessProbe { get; set; }
    public IEnumerable<ContainerVolume> Volume { get; set; }

  }

  public class EnviromentVariable 
  {
    public string Name { get; set; }
    public string Value { get; set; }
  }

  public class ContainerPort 
  {
    public int Port { get; set; }
    public int? HostPort { get; set; }
    public string HostIP { get; set; }
    public string Name { get; set; }
    public string Protocol { get; set; }
  }

  public class ContainerLivenessProbe 
  {
    public string HttpGetScheme { get; set; }
    public string HttpGetPath { get; set; }
    public int? PeriodSeconds { get; set; }
    public int? TimeoutSeconds { get; set; }
    public int? InitialDelaySeconds { get; set; }

  }

  public class ContainerReadynessProbe 
  {
    public string HttpGetScheme { get; set; }
    public string HttpGetPath { get; set; }
    public int? PeriodSeconds { get; set; }
    public int? TimeoutSeconds { get; set; }
    public int? InitialDelaySeconds { get; set; }
  }

  public class ContainerVolume 
  {
    public string Name { get; set; }
    public string MountPath { get; set; }


  }
}
