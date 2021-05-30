using System.Collections.Generic;

namespace web_ui.Models
{
    public class NodeModel
    {
        public string HostName { get; set; }
        public string Uid { get; set; }
        public string PodIP { get; set; }
        public IDictionary<string, string> Labels { get; set; }
    }
}