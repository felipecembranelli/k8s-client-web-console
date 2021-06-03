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

## Run using source code

```sh
cd k8s-client-web-console/web-ui
dotnet run
```

## Sample Screens

![alt tag](https://github.com/felipecembranelli/k8s-client-web-console/blob/master/kubernetes-client-api-consumer/doc/cluster.png)

![alt tag](https://github.com/felipecembranelli/k8s-client-web-console/blob/master/kubernetes-client-api-consumer/doc/namespaces.png)

![alt tag](https://github.com/felipecembranelli/k8s-client-web-console/blob/master/kubernetes-client-api-consumer/doc/nodes.png)

![alt tag](https://github.com/felipecembranelli/k8s-client-web-console/blob/master/kubernetes-client-api-consumer/doc/pods.png)

![alt tag](https://github.com/felipecembranelli/k8s-client-web-console/blob/master/kubernetes-client-api-consumer/doc/pod-detail.png)

![alt tag](https://github.com/felipecembranelli/k8s-client-web-console/blob/master/kubernetes-client-api-consumer/doc/logs.png)
