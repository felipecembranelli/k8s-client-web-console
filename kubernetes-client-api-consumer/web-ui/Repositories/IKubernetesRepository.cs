using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using k8s;
using web_ui.Models;
using System.Collections;

namespace web_ui.Repositories
{
  public interface IKubernetesRepository
  {
    Task<IEnumerable> GetPodsAsync(string ns = "default");
    Task<IEnumerable<NamespaceModel>> GetNamespacesAsync();
    PodLogModel GetLogsByPodId(string podNamespace, string podName);
    List<NodeModel> GetNodes();
    ClusterModel GetClusterInfo();
    Task<IEnumerable> GetServicesByNamespace(string resourceNamespace);
    Task<IEnumerable> GetDeploymentsByNamespace(string resourceNamespace);
    Task<IEnumerable> GetReplicaSetByNamespace(string resourceNamespace);
    Task<PodModel> GetPodSpecAsync(string podId, string ns);
  }
  
}
