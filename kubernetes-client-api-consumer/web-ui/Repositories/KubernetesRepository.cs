using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using k8s;
using web_ui.Models;
using System.Collections;
using k8s.Models;
using System.IO;
using System;

namespace web_ui.Repositories
{
  public class KubernetesRepository : IKubernetesRepository
  {
    private readonly Kubernetes _client;
    private readonly KubernetesClientConfiguration _config;

    public KubernetesRepository()
    {
      _config = KubernetesClientConfiguration.BuildDefaultConfig();

      _client = new Kubernetes(_config);
    }

    public ClusterModel GetClusterInfo()
    {
        return new ClusterModel
      {
        BaseUri = _client.BaseUri.AbsoluteUri.ToString(),
        Host = _config.Host,
        CurrentContext = _config.CurrentContext,
      };
    }

  public List<NodeModel> GetNodes()
    {
      List<NodeModel> nodes = new List<NodeModel>();

      k8s.Models.V1NodeList nodeList;

      nodeList = _client.ListNode();

      foreach (var item in nodeList.Items)
      {
        NodeModel n = new NodeModel 
        {
          Uid = item.Uid(),
          HostName = item.Name(),
          PodIP = item.Spec.PodCIDR,
          Labels = item.Labels()
        };
        nodes.Add(n);
      }

      return nodes;
    }

    public async Task<IEnumerable> GetServicesByNamespace(string resourceNamespace)
    {
      List<ServiceModel> resourceList = new List<ServiceModel>();

      var apiGenericClient = new GenericClient(_config, "", "v1", "services");

      var returnedList = await apiGenericClient.ListNamespacedAsync<V1ServiceList>(resourceNamespace).ConfigureAwait(false);

      foreach (var item in returnedList.Items)
      {
        ServiceModel s = new ServiceModel
        {
          Name = item.Name()
        };
        resourceList.Add(s);
      }

      return resourceList;
    }

    public async Task<IEnumerable> GetDeploymentsByNamespace(string resourceNamespace)
    {
      List<DeploymentModel> resourceList = new List<DeploymentModel>();

      var apiGenericClient = new GenericClient(_config, "apps", "v1", "deployments");

      var returnedList = await apiGenericClient.ListNamespacedAsync<V1DeploymentList>(resourceNamespace).ConfigureAwait(false);

      foreach (var item in returnedList.Items)
      {
        DeploymentModel d = new DeploymentModel
        {
          Name = item.Name()
        };
        resourceList.Add(d);
      }

      return resourceList;
    }

    public async Task<IEnumerable> GetReplicaSetByNamespace(string resourceNamespace)
    {
      List<ReplicaSetModel> resourceList = new List<ReplicaSetModel>();

      var apiGenericClient = new GenericClient(_config, "apps", "v1", "replicasets");

      var returnedList = await apiGenericClient.ListNamespacedAsync<V1ReplicaSetList>(resourceNamespace).ConfigureAwait(false);

      foreach (var item in returnedList.Items)
      {
        ReplicaSetModel r = new ReplicaSetModel
        {
          Name = item.Name()
        };
        resourceList.Add(r);
      }

      return resourceList;
    }

    public async Task<IEnumerable> GetPodsAsync(string ns = "default")
    {
      var pods = await _client.ListNamespacedPodAsync(ns);
      return pods
        .Items
        .Select(p => new PodModel
          {
            Name = p.Metadata.Name,
            Id = p.Metadata.Uid,
            NodeName = p.Spec.NodeName
        });
    }

    public async Task<IEnumerable<NamespaceModel>> GetNamespacesAsync()
    {
      var ns = await _client.ListNamespaceAsync();
      return ns
        .Items
        .Select(n => new NamespaceModel
          {
            Name = n.Metadata.Name
        });
    }

    public PodLogModel GetLogsByPodId(string podNamespace, string podId)
    {
      
      // if (podId == string.Empty)
      // {
      //     return "No pod selected!";
      // }

      var result = GetResult(podNamespace, podId);

      //var logContent = _repository.GetLogsByPodId ("pod1").Result;

      var rows = new System.Collections.Generic.List<string>();
      //var logText = string.Empty;
      //System.Text.StringBuilder sb = new System.Text.StringBuilder();

      using (System.IO.StreamReader sr = new System.IO.StreamReader(result.Result))
      {
          //logText = sr.ReadToEnd();

          string line;

          while ((line = sr.ReadLine()) != null)
          {
              rows.Add(line);

              //sb.Append(line);
              //sb.Append(Environment.NewLine);
              //sb.Append("<BR>");
          }

          //logText = sb.ToString();
      }

      //string[] result = list.ToArray();

      var logModel = new PodLogModel();

      logModel.PodName = podId;
      logModel.PodNamespace = podNamespace;
      //logModel.LogContent= logText;
      logModel.LogRows = rows;

      return logModel;

    }

    private async Task<System.IO.Stream> GetResult(string podNamespace, string podName) 
    {
      const int LOG_LIMIT_BYTES = 50000;

      var response = await _client.ReadNamespacedPodLogWithHttpMessagesAsync(
          podName,
          podNamespace, follow: true, limitBytes: LOG_LIMIT_BYTES).ConfigureAwait(false);

      var stream = response.Body;

      return stream;


    }

  }
}
