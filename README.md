# Kubernetes C# Client Web Console
This web application is a demo using kubernetes-csharp client library.

# Config

The client library uses your /.kube/config file to connect to your kubernetes cluster. For more information go to the original [client repo library](https://github.com/kubernetes-client/csharp)


# Usage

## Run as docker container

Pass your Kubernetes config file as parameter (Ex: /home/felipe/.kube/config)

```sh
docker run -p 8080:80 -v /home/felipe/.kube/config:/root/.kube/config --name k8s-explorer felipecembranelli/k8s-tools:k8s-explorer
```

### Connecting the dashboard to local Minikube

I had issues accessing my local Kubernetes instance (Minikube) related to cluster name resolution. The work around was to start the docker container using the parameter --network="host"
```sh
docker run --network="host" -p 8080:80 -v /home/felipe/.kube/config:/root/.kube/config --name k8s-explorer felipecembranelli/k8s-tools:k8s-explorer
```

## Run using source code

```sh
cd k8s-client-web-console/web-ui
dotnet run
```

# Sample Screens

![alt tag](https://github.com/felipecembranelli/k8s-client-web-console/blob/master/kubernetes-client-api-consumer/doc/cluster.png)

![alt tag](https://github.com/felipecembranelli/k8s-client-web-console/blob/master/kubernetes-client-api-consumer/doc/namespaces.png)

![alt tag](https://github.com/felipecembranelli/k8s-client-web-console/blob/master/kubernetes-client-api-consumer/doc/nodes.png)

![alt tag](https://github.com/felipecembranelli/k8s-client-web-console/blob/master/kubernetes-client-api-consumer/doc/pods.png)

![alt tag](https://github.com/felipecembranelli/k8s-client-web-console/blob/master/kubernetes-client-api-consumer/doc/pod-detail.png)

![alt tag](https://github.com/felipecembranelli/k8s-client-web-console/blob/master/kubernetes-client-api-consumer/doc/logs.png)

# Known Issues

## Get pods logs method is hanging
Currently there is a constraint with the size of the log returned by the Kubernetes. There is a cut-off hard coded (method Repostory->GetResult):

```dotnet
const int LOG_LIMIT_BYTES = 50000;
```
