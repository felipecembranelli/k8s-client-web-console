namespace web_ui.Models
{
  public class PodLogModel
  {
    public string PodName { get; set; }

    public string PodNamespace { get; set; }

    public string LogContent { get; set; }
    public System.Collections.Generic.List<string> LogRows { get; set; }
  }
}
