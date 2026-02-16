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

9. **Virtual Machines (VMs)**: on-demand, scalable computing resources with configurable CPU, RAM, storage, and networking
10. **B-Series VMs**: burstable VMs that accumulate credits when underutilized and use them when demand spikes
11. **D-Series VMs**: general-purpose VMs good for most workloads
12. **E-Series VMs**: memory-optimized VMs good for DBs and caching
13. **F-Series VMs**: compute-optimized VMs good for high CPU workloads
14. **M-Series VMs**: high-performance VMs good for big data and large DBs
15. **N-Series VMs**: GPU-enabled VMs good for AI/rendering workloads
16. **Premium SSD VM Storage**: most common general purpose VM storage type
17. **Premium SSD v2 VM Storage**: faster general purpose VM storage type that cannot be used as OS disks
18. **Standard SSD VM Storage**: lower-cost, but slower VM storage type good for web servers, light use, or dev/test
19. **Standard HDD VM Storage**: lowest-cost, but slowest VM storage type good for backup, non-critical, or archival workloads
20. **Ultra Disk VM Storage**: expensive high-IOPS VM storage type for specialized workloads
21. **Reserved Instance VMs**: discounted VMs that you commit to using for 1-3 years
22. **Spot VMs**: deeply discounted VMs that can be interrupted by Azure when capacity is needed
23. **Azure Hybrid Benefit**: VM option for reusing on-prem Windows Server and SQL Server licenses in Azure
24. **Scale Sets**: a group of identical VMs managed as a single resource that can automatically scale up/down based on demand
25. **Availability Sets**: a way to run multiple differing VMs so that no single hardware or rack failure can take them all down
26. **Fault Domains**: physical groupings of hardware (racks/power) inside a datacenter so VMs don’t all fail together
27. **Update Domains**: logical groupings of VMs that can be updated together for coordinating maintenance downtime
28. **Azure Virtual Desktop (AVD)**: cloud-hosted Windows desktops for organizations
29. **Azure App Service**: fully managed PaaS for web apps and APIs
30. **Azure Functions**: managed serverless compute service for running code on demand
31. **Azure Container Instances (ACI)**: service for running containers without managing servers or orchestration; fastest way to get a container running
32. **Azure Kubernetes Service (AKS)**: Azure's fully-managed service for running Kubernetes clusters
33. **Azure Container Apps**: serverless container platform that abstracts away Kubernetes but still supports scaling, revisions, Dapr, and microservices patterns
34. **Dapr (Distributed Application Runtime)**: dev tool that standardizes microservice plumbing by exposing consistent local HTTP endpoints for service calls; in K8, runs as sidecar containers alongside app containers

### Kubernetes Concepts

35.  **Cluster**: a set of nodes that run containerized applications managed by Kubernetes
36.  **Nodes**: the VMs that run your containerized applications in a Kubernetes cluster
37.  **Pod**: the smallest deployable unit in Kubernetes that can contain one or more containers
38.  **Sidecar**: a container that runs alongside the main application container (same storage volumes/localhost) in a pod to provide additional functionality like logging, monitoring, or networking

## Networking

39. **Virtual Network (VNet)**: a logical isolation of the Azure cloud dedicated to your organization
40. All Azure {{c1::VMs}} must be in a(n) {{c2::Virtual Network (VNet)}}
41. **Address Space**: the overall IP address range available for a specific VNet
42. **Subnets**: a logical partition of a VNet limited to a subset of the VNet's address space used for organization, isolation, and security
43. Azure {{c1::VMs}} must have a {{c2::private IP address}}
44. **VM Static IP Address**: a persistent IP address assigned to a VM for an extra cost
45. **Azure DNS**: service that provides domain name resolution for Azure resources
46. **Azure Front Door**: global, layer-7 (HTTP/HTTPS) load balancer and content acceleration service that routes users to the closest healthy backend

### CIDR Notation

47. **Classless Inter-Domain Routing (CIDR) Notation**: compact representation of IP subnets written as NetworkAddress/PrefixLength (e.g. 192.168.1.0/24)
48. **Subnet Mask**: 32-bit value that marks which bits of an IPv4 address are the network portion (1s) and which are the host portion (0s) (e.g. 192.168.1.0/24 = 255.255.255.0)
49. **Prefix Length**: the number of bits in the network portion of the address (e.g. 192.168.1.0/24 = 24)
50. **Network Prefix**: the network portion of a CIDR notation (e.g. 192.168.1.0/24 = 192.168.1)
51. **Fixed Bits**: the bits in the network portion of the address that do not change across a subnet (e.g. 192.168.1.0/24 = 192.168.1)
52. **Free Bits**: the bits in the host portion of the address that can be used for addressing individual hosts (e.g. 151 in 192.168.1.151)
53. **Network Address**: the first address in the subnet reserved for referring to the subnet itself (e.g. 192.168.1.0/24 = 192.168.1.0)
54. **Broadcast Address**: the last address in the subnet used for broadcasting to all hosts in the subnet (e.g. 192.168.1.255/24)
55. **Host Address Range**: the range of addresses available for use by hosts in the subnet (e.g. 192.168.1.1 to 192.168.1.254 for 192.168.1.0/24) N = 2^FreeBits - 2
56. **192.168.1.0/24**: subnet used by most home routers
57. **10.0.0.0/8**: subnet usually used in large corporate networks
58. **172.16.0.0/12**: subnet often used for mid-sized internal LANs
59. **127.0.0.1**: loopback IP address for localhost

### Network Security

60. **Network Security Groups (NSGs)**: free Azure VNet feature that controls inbound and outbound traffic for a subnet
61. **Azure Firewall**: paid network filter as a service for controlling traffic across VNets
62. **Azure Bastion**: managed service for secure RDP/SSH access to VMs without their public IP

### Hybrid Networking

63. **Virtual Network Peering**: VNet feature that allows you to connect VNets together over the Azure backbone network; more easily managed, cheaper, and faster than VPN
64. **Azure VPN**: Azure method of connecting VNets together over the public internet (with encryption) using Virtual Network Gateway; more setup and worse performance, but available for compliance
65. **Virtual Network Gateway**: VNet service that provides a connection to the internet
66. **VPN Gateway**: term for hybrid networking in Azure using Virtual Network Gateway and VPN rather than ExpressRoute
67. All Azure VPN configurations require a {{c1::local gateway}}, a {{c1::VPN Gateway}}, and a dedicated subnet called {{c2::GatewaySubnet}} that is used to host the gateway resources
68. **Policy-Based VPN**: a routing method that uses static routing for connection to a single site that is more backwards compatible but does not support Point-to-Site VPNs
69. **Route-Based VPN**: a routing method that uses dynamic routing for connection to 1 or more sites that supports Point-to-Site VPNs but is less backwards compatible
70. **Site-to-Site (S2S) VPN**: VPN option for connecting an on-prem network to an Azure VNet
71. **Point-to-Site (P2S) VPN**: VPN option for connecting a single device to an Azure VNet
72. **ExpressRoute**: a paid direct connection from your on-prem network to Azure over a private connection; faster than VPN

## Storage

Blob, File, Queue, Table, Disk, Data Lake

- Like S3, storage accounts must have globally unique names
- Like S3 buckets, Azure Blob Storage containers are top-level folders within a storage account
- Like DynamoDB, Azure Tables is a managed NoSQL key-value store provided by Azure


73.  **Storage Account**: top-level container that holds all your Azure storage services
74. **Azure Blob Storage**: Azure's mangaged object storage service for storing any file type
75. **Azure Files**: fully managed file share service accessible via SMB and NFS protocols; basically a NAS/shared-drive/Dropbox service in Azure
76. **Azure Queues**: storage service for storing messages between application components
77. **Azure Tables**: Azure's own NoSQL key-value storage service
78. **Azure Disks**: block storage service for Azure VMs; not managed via Storage Accounts
79. {{c1::Storage Accounts}} must have a globally unique name with containing only {{c2::lowercase letters and numbers}}
80. **Blob Storage File Address Format**: `https://<storage_account_name>.blob.core.windows.net/<container_name>/<folder>(optional)/<blob_name>`
81. **Block Blobs**: blob type for text or binary data up to about 4TB
82. **Append Blobs**: blob type optimized for when data is frequently added to e.g. log files
83. **Page Blobs**: blob type for random read/write operations up to 8TB often used for Azure VM disks
84. **Online Blob Storage Tiers**: blob storage tiers that can be accessed immediately (hot, cool, and cold)
85. **Offline Blob Storage Tiers**: blob storage tiers that require hours to access (archive)
86. **Hot Blob Storage Tier**: blob storage tier for frequently accessed data with highest storage cost/lowest access cost
87. **Cool Blob Storage Tier**: blob storage tier for data accessed less frequently than every 30 days
88. **Cold Blob Storage Tier**: blob storage tier for data accessed less frequently than every 90 days
89. **Archive Blob Storage Tier**: blob storage tier for data rarely accessed that may not be accessed right away with lowest storage cost/highest access cost
90. **AzCopy**: command-line tool for copying data to/from Azure Blob and File storage
91. **Azure Storage Explorer**: a desktop app for managing Azure Storage resources including blobs, files, queues, and tables
92. **Azure File Sync**: service that allows you to centralize your file shares in Azure Files while keeping it consistent across on-prem servers
93. **Azure Data Box**: physical device for transferring large amounts of data to Azure when network transfer is not feasible
94. **Azure Migrate**: service for assessing and migrating on-prem servers, infrastructure, applications, and data to Azure
95. **Locally Redundant Storage (LRS)**: redundancy option that keeps 3 copies of your data in 1 datacenter; cheapest/default option
96. **Zone Redundant Storage (ZRS)**: redundancy option that keeps 3 copies of your data in 3 AZs in a region
97. **Geo-Redundant Storage (GRS)**: redundancy option that keeps 3 copies of your data in 1 region and 3 copies in the paired region; both regions are (AZ agnostic); 2nd region is read-only until failover
98. **Geo-Zone-Redundant Storage (GZRS)**: redundancy option that keeps 3 copies of your data in 3 AZs in 1 region and 3 copies in the paired region; 2nd region is (AZ agnostic); 2nd region is read-only until failover

## Cost Management

99.  **Total Cost of Ownership (TCO) Calculator**: tool for estimating the long-term financial difference between running on-prem vs in Azure
100. **Azure Pricing Calculator**: tool that lets you estimate the monthly cost of Azure services before deploying anything
101. **Azure Cost Management and Billing**: dashboard for monitoring your spending in Azure
102. **Budgets**: Cost Management and Billing feature for setting spending limits and alerting when you approach them
103. **Cost Analysis**: Cost Management and Billing feature for visualizing and analyzing your Azure spending over time
104. **Cost Alerts**: notifications triggered when your spending exceeds predefined thresholds
105. **Azure Advisor**: a feature that makes recommendations for optimizing your Azure costs e.g. by identifying idle resources
106. **Azure Tags**: name/value labels for categorizing Azure resources; can be used as a filter in billing reports
107. **Azure Reservations**: pricing model that offers a discount for committing to 1 or 3 years of usage of Azure services
108. **Cost Allocation Reports**: Azure cost breakdowns that allow for manipulation and export with Power BI

## Governance and Compliance

109.   **Tenant Root Group**: the top-level scope above management groups and subscriptions for organizaation-wide management in Azure
110. **Azure Policy**: rules in Azure expressed as JSON that enforce conditions and effects on your resources
111. **resource locks**: guardrails that prevent accidental changes to Azure resources; override all role-based permissions; two types: ReadOnly and CanNotDelete
112. {{c1::Resource Locks}} can be set to {{c2::CanNotDelete}} or {{c2::ReadOnly}}, can be applied to {{c3::Subscriptions}}, {{c3::Resource Groups}}, or {{c3::Resources}}
113. **tenant**: an isolated identity and security boundary for an organization
114. **Active Directory**: Microsoft's on-prem identity and access management service
115. **Entra ID**: Azure's cloud-based identity and access management service (formerly Azure Active Directory)
116. **Role-Based Access Control (RBAC)**: access controls that grant permissions, are scoped to Azure resources, and use least-privilege; consist of an actor (or sEcUrItY PrInCiPaL), a role, and a scope
117. **Security Principle**: an identity that can be assigned roles in RBAC; can be a user, group, service principal, or managed identity
118. **Owner Role**: RBAC role with full access to a resource including the ability to delegate access to others
119. **Contributor Role**: RBAC role with access to manage a resource but not delegate access to others
120. **Reader Role**: RBAC role for viewing, but not managing, a resource
121. **Purview**: Azure service to help discover, classify, and govern data

## Monitoring

122. **Azure Monitor**: an umbrella service for managing logs/metrics which can create alerts and visualizations
123. **Log Analytics**: service within Azure Monitor that manages logs and allows querying with Kusto Query Language (KQL)
124. **Log Analytics workspace**: region specific container for log data from multiple Azure resources

## Development Tools

125. **Azure DevOps**: *a suite of development tools for planning, developing, testing, and deploying applications in Azure*
126. **DevOps Dashboards**: *customizable dashboards for tracking project progress and metrics in Azure DevOps*
127. **Azure Boards**: *a set of agile tools for planning and tracking work in Azure DevOps*
128. **Azure Repos**: *a set of version control tools for managing code repositories in Azure DevOps*
129. **Azure Pipelines**: *a continuous integration and continuous delivery (CI/CD) service for building, testing, and deploying applications in Azure DevOps*
130. **Azure Test Plans**: *a set of tools for managing and executing test plans in Azure DevOps*
131. **Azure Artifacts**: *a package management service for creating, hosting, and sharing packages in Azure DevOps*

## General

132. **Public Cloud model**: cloud model where a customer uses a hyper-scaler's hardware and accesses it over the internet
133. **Private Cloud model**: cloud model where a customer uses dedicated hardware either on-prem or hosted by a third party
134. **Infrastructure as a Service (Iaas)**: service where the provider manages the hardware, while the customer manages the OS and environment; if you touch the OS, it’s IaaS
135. **Platform as a Service (PaaS)**: service where the provider manages the hardware and environment, while the customer manages the code; if you deploy code but don’t manage servers, it’s PaaS
136. **Azure Resource Manager (ARM)**: the management layer of Azure that enables deploying, updating, and managing resources
137. **ARM Templates**: IaC JSON files that define Azure resources and deploy them automatically
138. **Azure Blueprints**: service for defining repeatable sets of Azure resources, Policies, or RBAC role assignments
139. **Service Level Agreements (SLAs)**: formal per-service agreements that define guaranteed availability/uptime percentages from Azure and what credits are provided if they are not met
140. **Azure Portal**: the web-based interface for managing Azure resources
141. **Azure CLI**: text-based, platform-agnostic interface with UNIX-like commands for managing Azure resources
142. **Azure Cloud Shell**: browser-accessible terminal for managing Azure resources using either Bash or PowerShell
143. **Bicep**: Azure specific structured text syntax for ARM Templates that can be transpiled into ARM JSON templates

## New

144. **Scalability**: the ability to increase or decrease resources to meet demand
145. **Elasticity**: the ability to scale resources based on real-time demand
146. **High Availability**: ensuring a service remains operational with minimal downtime
147. **Fault Tolerance**: ability of a system to continue operating when one or more components fail
148. **Disaster Recovery (DR)**: ability to recover services and data after a catastrophic failure
149. **Agility**: ability to rapidly deploy and experiment with new resources
150. **Shared Responsibility Model**: security framework defining what needs to be done by the cloud provider and by the customer
151. **Private Preview**: lifecycle stage with limited-access features for select customers and no SLA
152. **Public Preview**: lifecycle stage with features available to all customers for testing but no SLA
153. **General Availability (GA)**: lifecycle stage with full service support and SLA
154. **DDoS Protection**: Azure service that protects applications against large, common attacks for free (Basic) and sophisticated, targeted attacks as a paid service (Standard)
155. **Zero Trust Model**: security model that enforces verification for every access request
156. **Conditional Access**: Entra ID feature that enforces access rules based on criteria like user, device, or location
157. **Azure Load Balancer**: Azure service for distributing layer-4 (TCP/UDP) network traffic
158. **Azure Application Gateway**: region-specific, layer-7 (HTTP/HTTPS) load balancer with web application firewall (WAF)
159. **Azure Support Plans**: paid Azure subscription tiers that provide access to Microsoft engineers
160. **Azure Basic Support Plan**: assistance included with all Azure accounts; billing and documentation only
161. **Azure Developer Support Plan**: business-hours technical Azure assistance for non-production workloads
162. **Azure Standard Support Plan**: production workload Azure assistance with faster response times
163. **Azure Professional Direct Support Plan**: highest Azure assistance tier with proactive guidance and fastest response times
164. **Azure Marketplace**: online store for third-party and Microsoft-built applications and services
165. **Enterprise Agreement (EA)**: volume-based Azure purchasing for large organizations
166. **Azure Batch**: managed service for running large-scale parallel and high-performance computing (HPC) workloads
167. **Microsoft Defender for Cloud**: security management service that monitors security posture across Azure environments
168. **Secure Score**: metric in Defender for Cloud that measures your safety posture and provides recommendations for improvement
169. **External Identities**: Entra ID feature for managing access for users outside your organization (partners, customers, guests)
170. **Passwordless Authentication**: authentication methods that don't require memorization like Windows Hello, FIDO2 keys, or Microsoft Authenticator
171. **Application Insights**: Azure Monitor feature for monitoring live web apps, detecting performance issues, and tracking user behavior
172. **Azure Service Health**: service that provides personalized alerts and guidance when Azure resource issues affect your deployments
173. **Azure Alerts**: automated notifications triggered by metrics, logs, or activity log events in Azure Monitor
174. **Azure Machine Learning**: cloud-based platform for building, training, and deploying AI models
175. **Azure Cognitive Services**: pre-built AI APIs for vision, speech, language, and decision-making without ML expertise
176. **Azure Bot Service**: managed service for building and deploying conversational AIs
177. **Azure OpenAI Service**: managed service providing access to GPT models
178. **Azure SQL Database**: fully managed PaaS relational database service based on SQL Server
179. **Azure Cosmos DB**: globally distributed, multi-model NoSQL database with single-digit millisecond latency
180. **Azure Database for MySQL**: fully managed MySQL database service
181. **Azure Database for PostgreSQL**: fully managed database service for the fastest-growing open-source DB
182. **Azure Synapse Analytics**: Azure’s combined service for storing massive datasets and querying them with SQL or Spark for large-scale analytics
183. **Azure HDInsight**: managed Hadoop, Spark, and Kafka clusters for big data processing
184. **Azure Databricks**: managed Apache Spark-based analytics platform optimized for Azure
185. **Azure Logic Apps**: low-code workflow automation service for integrating systems, data, and services
186. **Azure Event Grid**: pub/sub service for routing “something happened” notifications to/from other services
187. **Azure IoT Hub**: managed service for bi-directional communication between smart devices and the cloud
188. **Azure IoT Central**: fully managed SaaS solution for building smart device applications without cloud expertise
189. **Azure DevOps**: suite of Azure services for CI/CD, version control, project management, and testing
190. **GitHub Actions**: automation platform integrated with Azure for CI/CD workflows
191. **Capital Expenditure (CapEx)**: upfront spending on physical infrastructure that you own (typical of on-prem)
192. **Operational Expenditure (OpEx)**: ongoing costs for services or products (typical of cloud computing)
193. **Azure Managed Disks**: block storage for Azure VMs with built-in redundancy and management
194. **Azure NetApp Files**: enterprise-grade file storage service for high-performance workloads
195. **Microsoft Privacy Statement**: document explaining what data Microsoft collects and how it's used
196. **Trust Center**: public website providing information about Microsoft's security, privacy, and compliance practices
197. **Service Trust Portal**: where Microsoft publishes the actual audit reports and legal documents that customers, auditors, and regulators ask for
198. **SOC (Service Organization Controls)**: audit reports for security, availability, and confidentiality of cloud resources

## TODO

For AZ-900 exam prep:

- [ ] Compliance Manager
- [ ] Public IP
- [ ] Private Endpoint
- [ ] SQL Managed Instance
- [ ] Cosmos DBCore (SQL) API
  - [ ] Core (SQL) API
  - [ ] MongoDB API
  - [ ] Table API
  - [ ] Cassandra API
- [ ] Azure Security Center
- [ ] Key Vault
- [ ] Azure Arc 

Other terms that need definitions:

- [ ] Managed Identity