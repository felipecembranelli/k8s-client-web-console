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
      // _client = new Kubernetes(
      //   KubernetesClientConfiguration.InClusterConfig()
      // );

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

    public async Task<string> GetLogsByPodId(string podId)
    {
      
      if (podId == string.Empty)
      {
          return "No pod selected!";
      }

      var list = _client.ListNamespacedPod("default");

      if (list.Items.Count == 0)
      {
          return "No pod selected!";
      }

      var pod = list.Items[0];


      var response = await _client.ReadNamespacedPodLogWithHttpMessagesAsync(
          pod.Metadata.Name,
          pod.Metadata.NamespaceProperty, follow: true).ConfigureAwait(false);
      var stream = response.Body;

      var consoleOut = new StringWriter();
      Console.SetOut(consoleOut);
      //Console.WriteLine("This is intercepted."); // This is not written to console
      stream.CopyTo(Console.OpenStandardOutput());

      return consoleOut.ToString();
      //File.WriteAllText("ConsoleOutput.txt", );


      // System.IO.MemoryStream destination = new MemoryStream();

      // StreamWriter standardOutput = new StreamWriter(destination); 

      // stream.CopyTo(standardOutput.BaseStream);
      // standardOutput.AutoFlush = true; 
      // Console.SetOut(standardOutput);

      //       // Create the streams.
      //       System.IO.MemoryStream destination = new MemoryStream();


      //     //Console.WriteLine("Source length: {0}", source.Length.ToString());

      //     // Copy source to destination.
      //     stream.CopyTo(destination);

      // return "text";



      //Console.WriteLine("Destination length: {0}", destination.Length.ToString());

            //stream.CopyTo())

            // while (!stream.EndOfStream)
            // {
            //     Console.WriteLine(rdr.ReadLine());
            // }

            // System.IO.StreamReader sr = new System.IO.StreamReader(stream, System.Text.Encoding.ASCII);  
            // // Use the stream. Remember when you are through with the stream to close it.  
            
            // var text = sr.ReadToEnd();

            // sr.Close();  
      

            // return text;


            // var responseValue = string.Empty;

            // //     // Task task = response.Content.ReadAsStreamAsync().ContinueWith(t =>
            // //     // {
            // //     //     var stream = t.Result;
            //         using (var reader = new System.IO.StreamReader(stream))
            //         {
            //             responseValue = reader.ReadToEnd();
            //         }

            // //     // });

            // //     //task.Wait();

            return "";

      

      //return stream.ReadToEnd();

    }

  }
}
