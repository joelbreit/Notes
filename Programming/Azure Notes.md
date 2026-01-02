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

26.  **Cluster**: a set of nodes that run containerized applications managed by Kubernetes
27.  **Nodes**: the VMs that run your containerized applications in a Kubernetes cluster
28.  **Pod**: the smallest deployable unit in Kubernetes that can contain one or more containers
29.  **Sidecar**: a container that runs alongside the main application container (same storage volumes/localhost) in a pod to provide additional functionality like logging, monitoring, or networking

## Networking

30. **Virtual Network (VNet)**: a logical isolation of the Azure cloud dedicated to your organization
31. All Azure {{c1::VMs}} must be in a(n) {{c2::Virtual Network (VNet)}}
32. **Address Space**: the overall IP address range available for a specific VNet
33. **Subnets**: a logical partition of a VNet limited to a subset of the VNet's address space used for organization, isolation, and security
34. Azure {{c1::VMs}} must have a {{c2::private IP address}}
35. **VM Static IP Address**: a persistent IP address assigned to a VM for an extra cost
36. **Azure DNS**: service that provides domain name resolution for Azure resources

### CIDR Notation

37. **Classless Inter-Domain Routing (CIDR) Notation**: compact representation of IP subnets written as NetworkAddress/PrefixLength (e.g. 192.168.1.0/24)
38. **Subnet Mask**: 32-bit value that marks which bits of an IPv4 address are the network portion (1s) and which are the host portion (0s) (e.g. 192.168.1.0/24 = 255.255.255.0)
39. **Prefix Length**: the number of bits in the network portion of the address (e.g. 192.168.1.0/24 = 24)
40. **Network Prefix**: the network portion of a CIDR notation (e.g. 192.168.1.0/24 = 192.168.1)
41. **Fixed Bits**: the bits in the network portion of the address that do not change across a subnet (e.g. 192.168.1.0/24 = 192.168.1)
42. **Free Bits**: the bits in the host portion of the address that can be used for addressing individual hosts (e.g. 151 in 192.168.1.151)
43. **Network Address**: the first address in the subnet reserved for referring to the subnet itself (e.g. 192.168.1.0/24 = 192.168.1.0)
44. **Broadcast Address**: the last address in the subnet used for broadcasting to all hosts in the subnet (e.g. 192.168.1.255/24)
45. **Host Address Range**: the range of addresses available for use by hosts in the subnet (e.g. 192.168.1.1 to 192.168.1.254 for 192.168.1.0/24) N = 2^FreeBits - 2
46. **192.168.1.0/24**: subnet used by most home routers
47. **10.0.0.0/8**: subnet usually used in large corporate networks
48. **172.16.0.0/12**: subnet often used for mid-sized internal LANs
49. **127.0.0.1**: loopback IP address for localhost

### Network Security

50. **Network Security Groups (NSGs)**: free Azure VNet feature that controls inbound and outbound traffic for a subnet
51. **Azure Firewall**: paid network filter as a service for controlling traffic across VNets
52. **Azure Bastion**: managed service for secure RDP/SSH access to VMs without their public IP

### Hybrid Networking

53. **Virtual Network Peering**: VNet feature that allows you to connect VNets together over the Azure backbone network; more easily managed, cheaper, and faster than VPN
54. **Azure VPN**: Azure method of connecting VNets together over the public internet (with encryption) using Virtual Network Gateway; more setup and worse performance, but available for compliance
55. **Virtual Network Gateway**: VNet service that provides a connection to the internet
56. **VPN Gateway**: term for hybrid networking in Azure using Virtual Network Gateway and VPN rather than ExpressRoute
57. All Azure VPN configurations require a {{c1::local gateway}}, a {{c1::VPN Gateway}}, and a dedicated subnet called {{c2::GatewaySubnet}} that is used to host the gateway resources
58. **Policy-Based VPN**: a routing method that uses static routing for connection to a single site that is more backwards compatible but does not support Point-to-Site VPNs
59. **Route-Based VPN**: a routing method that uses dynamic routing for connection to 1 or more sites that supports Point-to-Site VPNs but is less backwards compatible
60. **Site-to-Site (S2S) VPN**: VPN option for connecting an on-premises network to an Azure VNet
61. **Point-to-Site (P2S) VPN**: VPN option for connecting a single device to an Azure VNet
62. **ExpressRoute**: a paid direct connection from your on-premises network to Azure over a private connection; faster than VPN

## Storage

Blob, File, Queue, Table, Disk, Data Lake

- Like S3, storage accounts must have globally unique names
- Like S3 buckets, Azure Blob Storage containers are top-level folders within a storage account
- Like DynamoDB, Azure Tables is a managed NoSQL key-value store provided by Azure


63.  **Storage Account**: top-level container that holds all your Azure storage services
64. **Azure Blob Storage**: Azure's mangaged object storage service for storing any file type
65. **Azure Files**: fully managed file share service accessible via SMB and NFS protocols; basically a NAS/shared-drive/Dropbox service in Azure
66. **Azure Queues**: storage service for storing messages between application components
67. **Azure Tables**: Azure's own NoSQL key-value storage service
68. **Azure Disks**: block storage service for Azure VMs; not managed via Storage Accounts
69. {{c1::Storage Accounts}} must have a globally unique name with containing only {{c2::lowercase letters and numbers}}
70. **Blob Storage File Address Format**: https://<storage_account_name>.blob.core.windows.net/<container_name>/<folder>(optional)/<blob_name>
71. **Block Blobs**: blob type for text or binary data up to about 4TB
72. **Append Blobs**: blob type optimized for when data is frequently added to e.g. log files
73. **Page Blobs**: blob type for random read/write operations up to 8TB often used for Azure VM disks
74. **Online Blob Storage Tiers**: blob storage tiers that can be accessed immediately (hot, cool, and cold)
75. **Offline Blob Storage Tiers**: blob storage tiers that require hours to access (archive)
76. **Hot Blob Storage Tier**: blob storage tier for frequently accessed data with highest storage cost/lowest access cost
77. **Cool Blob Storage Tier**: blob storage tier for data accessed less frequently than every 30 days
78. **Cold Blob Storage Tier**: blob storage tier for data accessed less frequently than every 90 days
79. **Archive Blob Storage Tier**: blob storage tier for data rarely accessed that may not be accessed right away with lowest storage cost/highest access cost
80. **AzCopy**: command-line tool for copying data to/from Azure Blob and File storage
81. **Azure Storage Explorer**: a desktop app for managing Azure Storage resources including blobs, files, queues, and tables
82. **Azure File Sync**: service that allows you to centralize your file shares in Azure Files while keeping it consistent across on-premises servers
83. **Azure Data Box**: physical device for transferring large amounts of data to Azure when network transfer is not feasible
84. **Azure Migrate**: service for assessing and migrating on-premises servers, infrastructure, applications, and data to Azure

## Cost Management

85.  **Total Cost of Ownership (TCO) Calculator**: tool for estimating the long-term financial difference between running on-premises vs in Azure
86.  **Azure Pricing Calculator**: tool that lets you estimate the monthly cost of Azure services before deploying anything
87.  **Azure Cost Management and Billing**: dashboard for monitoring your spending in Azure
88.  **Budgets**: Cost Management and Billing feature for setting spending limits and alerting when you approach them
89.  **Cost Analysis**: Cost Management and Billing feature for visualizing and analyzing your Azure spending over time
90.  **Cost Alerts**: notifications triggered when your spending exceeds predefined thresholds
91.  **Azure Advisor**: a feature that makes recommendations for optimizing your Azure costs e.g. by identifying idle resources
92.  **Azure Tags**: name/value labels for categorizing Azure resources; can be used as a filter in billing reports
93.  **Azure Reservations**: pricing model that offers a discount for committing to 1 or 3 years of usage of Azure services
94.  **Cost Allocation Reports**: Azure cost breakdowns that allow for manipulation and export with Power BI

## Governance and Compliance

95.   **Tenant Root Group**: the top-level scope above management groups and subscriptions for organizaation-wide management in Azure
96.  **Azure Policy**: rules in Azure expressed as JSON that enforce conditions and effects on your resources
97.  **resource locks**: guardrails that prevent accidental changes to Azure resources; override all role-based permissions; two types: ReadOnly and CanNotDelete
98.  {{c1::Resource Locks}} can be set to {{c2::CanNotDelete}} or {{c2::ReadOnly}}, can be applied to {{c3::Subscriptions}}, {{c3::Resource Groups}}, or {{c3::Resources}}
99.  **tenant**: an isolated identity and security boundary for an organization
100. **Active Directory**: Microsoft's on-prem identity and access management service
101. **Entra ID**: Azure's cloud-based identity and access management service (formerly Azure Active Directory)

## Monitoring

102. **Azure Monitor**: an umbrella service for managing logs/metrics which can create alerts and visualizations
103. **Log Analytics**: a service within Azure Monitor where Azure logs live

## Development Tools

104. **Azure DevOps**: *a suite of development tools for planning, developing, testing, and deploying applications in Azure*
105. **DevOps Dashboards**: *customizable dashboards for tracking project progress and metrics in Azure DevOps*
106. **Azure Boards**: *a set of agile tools for planning and tracking work in Azure DevOps*
107. **Azure Repos**: *a set of version control tools for managing code repositories in Azure DevOps*
108. **Azure Pipelines**: *a continuous integration and continuous delivery (CI/CD) service for building, testing, and deploying applications in Azure DevOps*
109. **Azure Test Plans**: *a set of tools for managing and executing test plans in Azure DevOps*
110. **Azure Artifacts**: *a package management service for creating, hosting, and sharing packages in Azure DevOps*

## General

111. **Public Cloud model**: cloud model where a customer uses a hyper-scaler's hardware and accesses it over the internet
112. **Private Cloud model**: cloud model where a customer uses dedicated hardware either on-premises or hosted by a third party
113. **Infrastructure as a Service (Iaas)**: service where the provider manages the hardware, while the customer manages the OS and environment; if you touch the OS, it’s IaaS
114. **Platform as a Service (PaaS)**: service where the provider manages the hardware and environment, while the customer manages the code; if you deploy code but don’t manage servers, it’s PaaS


- [ ] Azure Front Door
- [ ] Cosmos DB
- [ ] RBAC
- [ ] Log Analytics Workspace
- [ ] Azure Blueprints
- [ ] Pricing Calculator
- [ ] TCO Calculator
- [ ] Service Level Agreements (SLAs)
- [ ] Purview
- [ ] Microsoft Defender for Cloud
- [ ] Compliance Manager
- [ ] Azure Resource Manager (ARM)
- [ ] Azure Batch
- [ ] Azure Load Balancer
- [ ] Azure Application Gateway
- [ ] Public IP
- [ ] Private Endpoint
- [ ] Redundancy options
  - [ ] LRS
  - [ ] ZRS
  - [ ] GRS
  - [ ] GZRS
- [ ] Azure SQL Database
- [ ] SQL Managed Instance
- [ ] Azure Database
- [ ] Cosmos DBCore (SQL) API
  - [ ] Core (SQL) API
  - [ ] MongoDB API
  - [ ] Table API
  - [ ] Cassandra API
- [ ] Single Sign-On (SSO)
- [ ] Conditional Access
- [ ] RBAC (Role-Based Access Control)
- [ ] Azure Defender
- [ ] Microsoft Defender for Cloud
- [ ] Azure Security Center
- [ ] DDoS Protection
- [ ] Key Vault
- [ ] Azure Blueprints
- [ ] Microsoft Trust Center
- [ ] Service Level Agreement (SLA)
- [ ] Preview vs GA
- [ ] Support plans
  - [ ] Basic
  - [ ] Developer
  - [ ] Standard
  - [ ] Professional Direct
- [ ] Azure Cloud Shell
- [ ] Log Analytics
- [ ] Service Health
- [ ] Azure Arc 