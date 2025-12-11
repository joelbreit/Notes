# Azure

## Geography

1. **Azure Region**: a set of data centers deployed within a latency-defined perimeter and connected through a dedicated local low-latency network
2. **Region Pairs**: sets of Azure regions associated with each other for disaster recovery with low-latency
3. **Sovereign Regions**: regions that are isolated from the main Azure cloud and are subject to specific local regulation
4. **Availability Zones**: sets of data centers within a region that are isolated from each other and connected through a dedicated low-latency network

## Organization

5. **Management Groups**: containers for managing policies across multiple Azure subscriptions
6. **Subscriptions**: a logical grouping of Azure resources that are billed together
7. **Resource Groups**: a logical grouping of related Azure resources that share the same lifecycle
8. **Resources**: individual services that you create in Azure and belong to a specific Resource Group and Subscription

## Compute

1. **Virtual Machines (VMs)**: on-demand, scalable computing resources with configurable CPU, RAM, storage, and networking
2. **B-Series VMs**: burstable VMs that accumulate credits when underutilized and use them when demand spikes
3. **D-Series VMs**: general-purpose VMs good for most workloads
4. **E-Series VMs**: memory-optimized VMs good for DBs and caching
5. **F-Series VMs**: compute-optimized VMs good for high CPU workloads
6. **M-Series VMs**: high-performance VMs good for big data and large DBs
7. **N-Series VMs**: GPU-enabled VMs good for AI/rendering workloads
8. **Premium SSD VM Storage**: most common general purpose VM storage type
8. **Premium SSD v2 VM Storage**: faster general purpose VM storage type that cannot be used as OS disks
9. **Standard SSD VM Storage**: lower-cost, but slower VM storage type good for web servers, light use, or dev/test
10. **Standard HDD VM Storage**: lowest-cost, but slowest VM storage type good for backup, non-critical, or archival workloads
11. **Ultra Disk VM Storage**: expensive high-IOPS VM storage type for specialized workloads
12. **Reserved Instance VMs**: discounted VMs that you commit to using for 1-3 years
13. **Spot VMs**: deeply discounted VMs that can be interrupted by Azure when capacity is needed
14. **Azure Hybrid Benefit**: VM option for reusing on-premises Windows Server and SQL Server licenses in Azure
15. **Scale Sets**: a group of identical VMs managed as a single resource that can automatically scale up/down based on demand
16. **Availability Sets**: a way to run multiple differing VMs so that no single hardware or rack failure can take them all down
17. **Fault Domains**: physical groupings of hardware (racks/power) inside a datacenter so VMs don’t all fail together
18. **Update Domains**: logical groupings of VMs that can be updated together for coordinating maintenance downtime
19. **Azure Virtual Desktop (AVD)**: cloud-hosted Windows desktops for organizations
20. **Azure App Service**: fully managed PaaS for web apps and APIs
21. **Azure Functions**: managed serverless compute service for running code on demand
22. **Azure Container Instances (ACI)**: service for running containers without managing servers or orchestration; fastest way to get a container running
23. **Azure Kubernetes Service (AKS)**: Azure's fully-managed service for running Kubernetes clusters
24. **Azure Container Apps**: serverless container platform that abstracts away Kubernetes but still supports scaling, revisions, Dapr, and microservices patterns
25. **Dapr (Distributed Application Runtime)**: dev tool that standardizes microservice plumbing by exposing consistent local HTTP endpoints for service calls; in K8, runs as sidecar containers alongside app containers

### Kubernetes Concepts

1.  **Cluster**: a set of nodes that run containerized applications managed by Kubernetes
2.  **Nodes**: the VMs that run your containerized applications in a Kubernetes cluster
3.  **Pod**: the smallest deployable unit in Kubernetes that can contain one or more containers
4.  **Sidecar**: a container that runs alongside the main application container (same storage volumes/localhost) in a pod to provide additional functionality like logging, monitoring, or networking

## Networking

21. **Virtual Network (VNet)**: a logical isolation of the Azure cloud dedicated to your organization
22. All Azure {{c1::VMs}} must be in a(n) {{c2::Virtual Network (VNet)}}
23. **Address Space**: the overall IP address range available for a specific VNet
24. **Subnets**: a logical partition of a VNet limited to a subset of the VNet's address space used for organization, isolation, and security
25. Azure {{c1::VMs}} must have a {{c2::private IP address}}
26. **VM Static IP Address**: a persistent IP address assigned to a VM for an extra cost
27. **Azure DNS**: service that provides domain name resolution for Azure resources

### CIDR Notation

28. **Classless Inter-Domain Routing (CIDR) Notation**: compact representation of IP subnets written as NetworkAddress/PrefixLength (e.g. 192.168.1.0/24)
29. **Subnet Mask**: 32-bit value that marks which bits of an IPv4 address are the network portion (1s) and which are the host portion (0s) (e.g. 192.168.1.0/24 = 255.255.255.0)
30. **Prefix Length**: the number of bits in the network portion of the address (e.g. 192.168.1.0/24 = 24)
31. **Network Prefix**: the network portion of a CIDR notation (e.g. 192.168.1.0/24 = 192.168.1)
32. **Fixed Bits**: the bits in the network portion of the address that do not change across a subnet (e.g. 192.168.1.0/24 = 192.168.1)
33. **Free Bits**: the bits in the host portion of the address that can be used for addressing individual hosts (e.g. 151 in 192.168.1.151)
34. **Network Address**: the first address in the subnet reserved for referring to the subnet itself (e.g. 192.168.1.0/24 = 192.168.1.0)
35. **Broadcast Address**: the last address in the subnet used for broadcasting to all hosts in the subnet (e.g. 192.168.1.255/24)
36. **Host Address Range**: the range of addresses available for use by hosts in the subnet (e.g. 192.168.1.1 to 192.168.1.254 for 192.168.1.0/24) N = 2^FreeBits - 2
37. **192.168.1.0/24**: subnet used by most home routers
38. **10.0.0.0/8**: subnet usually used in large corporate networks
39. **172.16.0.0/12**: subnet often used for mid-sized internal LANs
40. **127.0.0.1**: loopback IP address for localhost

### Network Security

41. **Network Security Groups (NSGs)**: free Azure VNet feature that controls inbound and outbound traffic for a subnet
42. **Azure Firewall**: paid network filter as a service for controlling traffic across VNets
43. **Azure Bastion**: managed service for secure RDP/SSH access to VMs without their public IP

### Hybrid Networking

44. **Virtual Network Peering**: VNet feature that allows you to connect VNets together over the Azure backbone network; more easily managed, cheaper, and faster than VPN
45. **Azure VPN**: Azure method of connecting VNets together over the public internet (with encryption) using Virtual Network Gateway; more setup and worse performance, but available for compliance
46. **Virtual Network Gateway**: VNet service that provides a connection to the internet
47. **VPN Gateway**: term for hybrid networking in Azure using Virtual Network Gateway and VPN rather than ExpressRoute
48. All Azure VPN configurations require a {{c1::local gateway}}, a {{c1::VPN Gateway}}, and a dedicated subnet called {{c2::GatewaySubnet}} that is used to host the gateway resources
49. **Policy-Based VPN**: a routing method that uses static routing for connection to a single site that is more backwards compatible but does not support Point-to-Site VPNs
50. **Route-Based VPN**: a routing method that uses dynamic routing for connection to 1 or more sites that supports Point-to-Site VPNs but is less backwards compatible
51. **Site-to-Site (S2S) VPN**: VPN option for connecting an on-premises network to an Azure VNet
52. **Point-to-Site (P2S) VPN**: VPN option for connecting a single device to an Azure VNet
53. **ExpressRoute**: a paid direct connection from your on-premises network to Azure over a private connection; faster than VPN

## Storage

Blob, File, Queue, Table, Disk, Data Lake

- Like S3, storage accounts must have globally unique names
- Like S3 buckets, Azure Blob Storage containers are top-level folders within a storage account
- Like DynamoDB, Azure Tables is a managed NoSQL key-value store provided by Azure


1.  **Storage Account**: top-level container that holds all your Azure storage services
2.  **Azure Blob Storage**: Azure's mangaged object storage service for storing any file type
3.  **Azure Files**: fully managed file share service accessible via SMB and NFS protocols; basically a NAS/shared-drive/Dropbox service in Azure
4.  **Azure Queues**: storage service for storing messages between application components
5.  **Azure Tables**: Azure's own NoSQL key-value storage service
6.  **Azure Disks**: block storage service for Azure VMs; not managed via Storage Accounts
7.  {{c1::Storage Accounts}} must have a globally unique name with containing only {{c2::lowercase letters and numbers}}
8.  **Blob Storage File Address Format**: https://<storage_account_name>.blob.core.windows.net/<container_name>/<folder>(optional)/<blob_name>
9.  **Block Blobs**: blob type for text or binary data up to about 4TB
10. **Append Blobs**: blob type optimized for when data is frequently added to e.g. log files
11. **Page Blobs**: blob type for random read/write operations up to 8TB often used for Azure VM disks
12. **Online Blob Storage Tiers**: blob storage tiers that can be accessed immediately (hot, cool, and cold)
13. **Offline Blob Storage Tiers**: blob storage tiers that require hours to access (archive)
14. **Hot Blob Storage Tier**: blob storage tier for frequently accessed data with highest storage cost/lowest access cost
15. **Cool Blob Storage Tier**: blob storage tier for data accessed less frequently than every 30 days
16. **Cold Blob Storage Tier**: blob storage tier for data accessed less frequently than every 90 days
17. **Archive Blob Storage Tier**: blob storage tier for data rarely accessed that may not be accessed right away with lowest storage cost/highest access cost
18. **AzCopy**: command-line tool for copying data to/from Azure Blob and File storage
19. **Azure Storage Explorer**: a desktop app for managing Azure Storage resources including blobs, files, queues, and tables
20. **Azure File Sync**: service that allows you to centralize your file shares in Azure Files while keeping it consistent across on-premises servers
21. **Azure Data Box**: physical device for transferring large amounts of data to Azure when network transfer is not feasible
22. **Azure Migrate**: service for assessing and migrating on-premises servers, infrastructure, applications, and data to Azure

- [ ] Load Banlancers
- [ ] Front Door
- [ ] Cosmos DB
- [ ] Entra ID
- [ ] RBAC
- [ ] Azure Monitor
- [ ] Log Analytics Workspace
- [ ] Azure Blueprints
- [ ] Pricing Calculator
- [ ] TCO Calculator
- [ ] Service Level Agreements (SLAs)