# AWS - Amazon Web Services

## Topics

### Meta

**Networking 🛜**
* VPC
* VPN
    * Virtual Private Gateway
    * Customer Gateway
* Route53
* Direct Connect
* CloudFront
* Elastic Load Balancer
    * Classic
    * Application 
    * Network
    * Gateway

**Integration ➡️**
* API Gateway
* Step Functions
* SNS
* SES?
* SQS
* EventBridge
* AppFlow
* Amazon MQ*

**Financial 🏦**
* Cost and Usage Reports
* Trusted Advisor
* Health Dashboard
* Billing and Cost Management Dashboard
    * Cost Explorer
    * Budgets
    * Cost and Usage Reports
* Pricing Calculator
* Billing Conductor*

**Orchestration 🎻**
* Elastic Beanstalk
* Amplify
* LightSail
* OpsWorks

**Enterprise 🏢**
* Organizations 
    * Control Tower*
    * Systems Manager*
* Migration 🚚
    * Snowball
        * Snow Mobile
        * Snowball Edge
        * Snowball
        * Snowcone
    * DMS
    * SMS
    * DataSync
    * Professional Services
* Application Discovery Service*
* Outposts
* Direct Connect
* Support
    * Support Plans
    * AWS Partner Network
    * AWS Marketplace

**Security 🔒**
* IAM
    * Users
    * Groups
    * Roles
    * Policies
* Access Keys
* KMS
* GuardDuty*
* Shield / Shield Advanced
* WAF
* Firewall Manager
* Macie
* Inspector
* CloudHSM*

### Core

**Compute 🧠**
* EC2
    * EBS
* Lambda
* Containers
    * ECS/EKS
    * Fargate
    * Elastic Container Registry
* Batch*

**Storage 💽**
* S3
* EFS
* Storage Gateway
* Backup

**Databases 🗄️**
* DynamoDB
* RDS
* Aurora
* Athena
* Neptune
* DocumentDB
* MemoryDB*
* Amazon QLDB*

**Records 📜**
* CloudWatch
* CloudTrail
* Backup
* X-Ray
* Artifact*
* AWS Config
* License Manager

### Tools

**Developer Tools 🧑‍💻**
* AWS CLI
* AWS Mangement Console
* Cloud9
* CloudShell
* CodeStar*
* CodeCommit
* CodePipeline
* CodeBuild
* CodeDeploy
* CloudFormation
* Secrets Manager
* CloudDrive*
* WorkMail
* WorkSpaces
* WorkDocs
* Cognito
* Parameter Store
* License Manger*
* Certificate Manger*

**AI Tools 🤖**
* Bedrock
* Polly
* Textract
* Rekognition
* SageMaker
* Transcribe
* Translate
* Lex
* Comprehend

**Data Analytics Tools 📊**
* Elasticache
    * Redis
    * Memcached
* Redshift
    * Spectrum
* Kinesis
    * Streams*
    * Firehose
* EMR
* QuickSight
* Glue
* Lake Formation*
* Data Pipeline*
* CloudSearch*
* Amazon MSK*
* Amazon OpenSearch Service*
* Data Firehose*


## Vocab

### Geography

**Geographic Region** - Geographic area like US-EAST that doesn’t correspond to anything important in AWS architecture
- Can have 1 or more Regions

**Region** - a collection of AZs. The main location subdivision of AWS. 
- e.g. Northern Virginia, Ohio, etc
- e.g. US-EAST-1
- An AZ must be selected when interacting with the AWS console

**Availability Zone** - (AZ) a collection of data centers in local area. 
- e.g. US-EAST-1a

### Compute

#### EC2 - Elastic Compute Cloud
- Virtual machines
- 750 compute hours free / month
- Launch by Region
- **Amazon Machine Image (AMI)**
    - Preconfigured EC2 templates
- **On-Demand Instances**
    - Billed by the second
    - Best for unpredictable, uninterruptible tasks
    - Cannot run longer than 1 year
- **Spot Instances**
    - Cheapest option
    - Only uses unused capacity
    - Best if you aren’t concerned about start/stop times and your work can be interrupted
- **Reserved Instances (RIs)**
    - 1 or 3 year lease of specific instances
    - Can be cheaper than on-demand
    - Best for steady, predictable tasks
    - Upfront, partial upfront, or no upfront have different prices
- **Dedicated Host**
    - Server is not shared with other customers
    - Dedicated host is the server; dedicated instance runs on the server
    - Best for government requirements or server-specific license requirements
- **Savings Plans**
    - Reservation of number of compute hours over a 1 or 3 year period 
    - Can be shared across EC2, Lambda, and Fargate
    - 
**Lambda**
- 1 million requests/month free
- 15 minute time-out
**Fargate**
- Serverless compute engine for containers
**Lightsail**
- Quickly launch

### Storage

#### S3

Simple Storage Service
- Objects = files
- Objects can be public or private
- Objects can be versioned
- S3 is Region specific
- Storage Classes
    - Standard
    - Intelligent Tiering
    - Standard-Infrequent Access (IA)
    - One Zone-Infrequent Access (IA)
        - Data that can be reproduced
    - Glacier
        - Takes minutes to hours to access
    - Glacier Deep Archive
        - Takes hours to access
    - Outposts

#### EC2 Storage

**Elastic Block Store (EBS)**
- 1 EBS per EC2 instance
- Like a flash drive
- Persistent
- Scale up or down
- Replicated within AZ

**EC2 Instance Store**
- Associated with an EC2 instance at startup
- Deleted when EC2 instance shuts down
- Like RAM

**Elastic File System (EFS)**
- Can be shared across EC2 instances
- Like a shared drive
- Only supports Linux file systems

**Storage Gateway**
- Hybrid data

**AWS Backup**
- Backup with rules
- Works across services

### Content Delivery

Content delivery network (CDN) - method of distributing content

**CloudFront**
- Makes content available globally
- Uses edge locations to store cache
- Can host static website
- Can prevent DDoS attacks

**Global Accelorator**
- Speeds up delivery

**S3 Transfer Acceleration**
- Accelerates S3 communication

### Network Services
**Virtual Private Cloud (VPC)**
- Region specific
- Spans AZs
- Can host EC2 instances
- Can have private and public subnets

**Route 53**
- Domain Name System (DNS)
- Links your domain name(s) to your AWS content

**Direct Connect**
- Communication between AWS services without using your internet

**AWS VPN**
- Uses public internet to communicate

**API Gateway**
- Lets you manage APIs

### Databases
- Relational databases
    - **RDS**
        - Amazon Relational Database Service
        - Supports a bunch of database flavors
        - Multi-AZ
            - Creates failover replica in another AZ
            - For reliability only (not performance)
        - Read replica
            - For performance boost
    - **Aurora**
        - Compatible with MySQL and PostgreSQL
        - Cheaper Amazon provided native version
- NoSQL databases
    - **DynamoDB**
        - Serverless
- Graph databases
    - **Neptune**
        - Serverless
        - Highly connected data like social media
- In-Memory databases
    - **ElastiCache**
        - Data can be lost because it is stored in memory
- Document databases
    - **DocumentDB**
        - Serverless
        - Compatible with MongoDB

### Migration or Transfer Services

**Database Migration Service (DMS)**
- Migrate to or within AWS

**Server Migration Service (SMS)**

**Snow Products**
- Transfer large amounts of data

- **Snowcone**
    - 8TB of usable storage

- **Snowball**

- **Snowball Edge**
    - Edge computing device
    - EC2 and Lambda

- **Snowmobile**
    - Semitruck 

### Analytics

**Services**
**IaaS** - Infrastructure as a service i.e. hardware for rent
**PaaS** - Platform as a Service; a level of abstraction above hardware for rent
**AWS Region** - area of the world with multiple availability zones
**Availability Zone** - one or more discrete data center
**Software Developer Kits (SDKs)** - APIs for programming languages to interface with AWS
**Athena** - Serverless standard SQL for S3
- Pay per query

**CloudSearch** - Search function APIs such as highlighting, autocomplete, and geospatial search 
- Works with S3 and CloudDrive
- Primarily for AWS users to utilize but can be integrated into products for end users to utilize

**EMR** - (Elastic map reduce) AWS’s big data platform
- Works with common big data platforms

**FinSpace** - Data management and analytics for finances
**Kinesis** - service for collecting and analyzing real-time data
**Kinesis Data Firehose** - service for directing real-time data to a storage location for later analysis
**Kinesis Data Analytics** - SQL for real-time data
**Kinesis Data Streams** - Services for capturing real-time data
**Kinesis Video Streams** - Service for live video infrastructure
**OpenSearch Service** - API for searching real-time data
- Log analytics
- Full-text search
- App monitoring

**Redshift** - Data warehousing service for terabytes to petabytes of data
- SQL and other analytics
- Exabyte scale data
- Good for relational databases when don’t need to make real-time updates 

**Redshift Serverless** - Redshift without hardware design
**QuickSight** - BI service for publishing interactive dashboards 
- Accessible from browsers or mobile devices
- Scales to tens of thousands of users
- Visualize your data

**Data Exchange** - Way to subscribe to third-party data in the cloud
Data Pipeline - Service for moving data between AWS storage and compute services
- Move based on conditions or time intervals
- Sends notifications about success/failure

**Glue** - ETL service for easily? loading prepared data
**Lake Formation** - Management service for data lakes
**Managed Streaming for Apache Kafka (MSK)** - Service for managing how apache Kafka pipelines work in AWS

#### Terms
**ETL** - extract, transform, and load
**Data Lake** - Database with raw, unstructured data without imposing structure or relationships on it
**Apache Kafka** - Open-source platform for building real-time data streaming pipelines
**Durability** - objects don’t get corrupted
**Availability** - objects can always be accessed

**Simple**
**Data Center** - Where AWS keeps the their cloud hardware
**SaaS** - Software as a Service; e.g. email
**AWS Management Console** - The website that you use to manage your AWS system
**AWS CLI** - Command Line Interface - API that you install and use within another terminal
**Data warehouse** - system for storing large amounts of historical data
- Not good for transactional systems

**Business Intelligence (BI) tools** - software applications that help you gain insight into data and make informed decisions
**High availability** - always online, not failing often


### Financial Management
Applications Cost Profiler - 

### Machine Learning

**Rekognition** - automate image and video analysis
- Identify custom labels
- Face and text detection

**Comprehend** - Natural language Processing
- Incites and relationships in text

**Polly** - Text to speech
- Can create a custom voice

**SageMaker** - Machine learning models
**Translate** - language translation
- Real-time and batch language translation

**Lex** - helps build conversational interfaces like chatbots
- Used for Alexa

### Developer Tools

**Cloud9** - Web browser IDE
- Write/debug code

**CodeCommit** - Legacy AWS version of git
**CodeBuild** - Build and test your code (CI/CD)
- Compiles code and runs tests
- Produce ready-to-deploy build artifacts

**CodeDeploy** - Deploy code to EC2, Fargate, Lambda, and on-prem
- Rolling deployments

**CodePipeline** - Automated software release process
**X-Ray** - debug 
**CodeStar** - issue tracking collaboration dashboard

### Deployment and Infrastructure Management Services

**CloudFormation** - Infrastructure as Code
- Create AWS services with code instead of the web browser UI

**Elastic Beanstalk** - automatic deployment
- Handles capacity provisioning, load balancing, and auto scaling for you
- Not on premises

**OpsWorks** - use Chef or Puppet to automate server configuration
- Can be used for on-prem

### Messaging and Integration Services

**SQS** - (Simple Queue Service) Messaging queue
- Asynchronis
- FIFO

**SNS** - Text and email messages
- Unformatted

**SES** - (Simple Email Service) marketing email campaigns
- Formatted HTML emails

### Auditing, Monitoring, and Logging Services

**CloudWatch** - Log visualization / real-time monitoring / notifications when events occur
- Alarms - 
- Logs - 
- Metrics - 
- Events - 
**CloudTrail** - Tracks activity by IAM users
- Username, event time and name, IP, access key, Region, error code

### Additional Services

**Workspaces** - virtual workspaces
**Connect** - cloud help desk
- 1-800-numbers

Security and Compliance
WAF - 
Shield - 
Macie - 
Config - 
GuardDuty - 
Inspector - 
Artifact - 
Cognito - 
Key Management Service (KMS) - 
CloudHSM - 
Secrets Manager - 

Pricing, Billing, and Governance
Organizations - Grouping of AWS accounts
Control Tower - Service that ensures accounts in an Organization follow certain rules
Systems Manager - 
Trusted Advisor - 
License Manager - 
Certificate Manager - 

Support Plans
Basic - 
Developer - 
Business - 
Enterprise - 

## Notes

Main services
Lambda, DynamoDB, Step Functions, X-Ray, API Gateway, ECS, CloudFront, SQS, SNS, and Kinesis


## One-Way Flashcards

Number of free EC2 hours - 750/month

Number of free Lambda requests - 1 million / month 

How durable are S3 objects - 11 9’s (99.9999999%)

How available are S3 objects - 99.99%

What database engines does RDS support? - Aurora, PostgreSQL, MySQL, MariaDB, Oracle, Microsoft SQL Server

What can only the root user do? - Close your account; change email address, modify the support plan

What is needed for any user to access the AWS CLI? - A public/private access key pair

What are the free Trusted Advisor checks? - Unrestricted access to ports on EC2, public access on S3 buckets, MFA for the root user, public snapshots of RDS

What are the enterprise/business tier Trusted Advisor checks? - IAM password policies, service usage above 80% of limit, exposed access keys, CloudFront optimization

What support case types can be opened by all customers? - Account and billing support cases, service limit increase support cases

What support case type can only be opened by customers with paid AWS support plans? - Technical support cases

What kind of support cases does AWS not allow? - Code development, debugging software, system admin tasks

How can RDS instances be encrypted? - Encrypting them at creation or taking a snapshot, encrypting that snapshot, and then creating a new instance based off of the encrypted snapshot

What services can trigger Lambda? - DynamoDB, Kinesis, SQS, Application Load Balancer, API Gateway, Alexa, CloudFront, S3, SNS, SES, CloudFormation, CloudWatch, CodeCommit, CodePipeline

What is the default limit for concurrent Lambda executions? - 1,000 per second

What are the default API Gateway throttling limits? - 10,000 requests per second and 5,000 requests concurrently

How can you run X-Ray in ECS? - Run the X-Ray daemon on its own Docker image alongside your application

## Two-Way Flashcards

**Geographic Region** - Region of the globe that can contain 1 or more AWS Regions e.g. US-EAST

**AWS Region** - General location of AWS resources that contains 1 or more AZs e.g. US-EAST-1: N. Virginia

**Availability Zone (AZ)** - A collection of data centers in a local area e.g. US-EAST-1a

**Amazon Machine Image (AMI)** - A blueprint for an EC2 instance

**EC2 On-Demand** - EC2 option with a fixed cost per second of use that is always available; best for unpredictable work that can’t be delayed

**EC2 Spot** - Cheapest EC2 option that only runs when there is available capacity; best when your work can be paused and you need the lowest cost e.g. research

**EC2 Reserved Instances (Res)** - EC2 option with 1 or 3 year contract that reserves capacity in an AZ, but not a specific host; best for consistent work; cheaper with (partial) upfront payment

**EC2 Dedicated Hosts** - EC2 option with 1 or 3 year contract that reserves a specific host that cannot be shared with other users; sometimes necessary for corporate/government compliance

**Compute Savings Plan** - Compute option with 1 or 3 year contract for a given # of compute hours

**Horizontal Scaling** - Autoscaling by adding more hosts

**Vertical Scaling** - Autoscaling by upgrading existing host’s power (scaling up)

**S3 Buckets** - Root level folders for S3 that are Region specific but need globally unique names

**S3 Standard** - S3 general-purpose tier; best for frequently accessed objects

**S3 Intelligent Tiering** - S3 service for automatically moving objects to the most cost effective storage class; no retrieval fee

**S3 Standard-Infrequent Access (IA)** - S3 tier meant for rare, millisecond level retrieval 

**S3 One Zone-Infrequent Access (IA)** - S3 tier meant for rare, millisecond level retrieval not backed up in multiple AZs; best for re-creatable data

**S3 Glacier** - S3 tier with options for 1-5 minute, 3-5 hour, or 5-12 hour retrieval for long-term backups 

**S3 Glacier Deep Archive** - Cheapest S3 tier with options for 12 or 48 hour retrieval times for very long-term backups

**S3 Outposts** - S3 option for storing objects on-prem

**EC2 Instance Store** - EC2 storage physically attached to an instance with fast speed  which is lost when the instance is stopped; virtual RAM

**S3 Transfer Acceleration** - Service that improves content uploads and downloads to/from S3 buckets using edge locations

**Virtual Private Gateway** - Router in the AWS VPC used to establish a secure connection with an AWS VPN

**Customer Gateway** - Customer-side endpoint for establishing a secure connection with an AWS VPN

**Principles of the Operational Excellence Pillar** - Perform tasks as code, make frequent, small, reversible changes, refine procedures frequently, and anticipate/learn from failures

**Principles of the Security Pillar** - Implement a strong identity foundation, enable traceability, apply protections at all layers, automate best practices, protect data in transit and at rest, keep people away from data, and prepare for issues

**Principles of the Reliability Pillar** - Automatically recover from failure, test recovery procedures, scale horizontally to increase aggregate workload availability, stop guessing capacity, and manage change in automation

**Performance Efficiency Pillar** - Democratize advanced technologies, go global in minutes, use serverless architectures, experiment often, and understand technology

**Principles of the Cost Optimization Pillar** - Implement cloud financial management, adopt a consumption model, measure efficiency, stop spending money on undifferentiated heavy lifting, and analyze expenditure

**Principles of the Sustainability Pillar** - Understand your impact, establish sustainability goals, maximize utilization, adopt new, more efficient hardware and software offerings, use managed services, and reduce the downstream impact of your cloud workloads

**Elastic Compute Cloud (EC2)** - Service that allows you to rent and manage virtual servers in the cloud

**Lambda** - Serverless compute service that lets you run code without managing servers; 15 minute timeout

**Fargate** - Serverless compute engine for containers like Docker

**Lightsail** - AWS service for simple single-server applications

**AWS Outposts** - Service that allows you to run cloud services in your internal data center for compliance; AWS delivers and installs servers; works for hybrid solutions

**AWS Batch** - Service that allows you to process large workloads in smaller chunks with dynamic provisioning

**Simple Storage Service (S3)** - Object storage service for the cloud that is highly available

**Elastic Block Store (EBS)** - Storage device (volume) that can be attached to/removed from one instance at a time; AZ specific; virtual flash drive

**Elastic File System (EFS)** - More expensive serverless network file system for sharing files across a Region; only supports Linux; virtual shared drive

**Storage Gateway** - Hybrid (cloud/on-prem) storage service

**AWS Backup** - Service that helps you manage data backups across multiple data services with rules for frequency and retention

**CloudFront** - Content delivery network (CDN) that delivers data and applications globally with low latency using edge locations; can restrict based on location and help prevent DDoS

**Global Accelerator** - Service that sends your users through the AWS network when accessing your content to speed up delivery

**Route 53** - Domain name system (DNS) that routes users to applications; performs health checks; supports hybrid

**Virtual Private Cloud (VPC)** - A Region specific private network within the AWS Cloud where you launch your resources

**Direct Connect** - A dedicated physical network connection from your on-prem data center to AWS which bypasses the public internet for better connection

**AWS Virtual Private Network (VPN)** - Site-to-site network for a secure, encrypted connection between internal traffic and AWS VPCs; like Direct Connect but over the public internet; supports hybrid

**API Gateway** - Service that allows you to build and manage RESTful and WebSocket application programming interfaces

**Relational Database Service (RDS)** - Service that makes it easy to launch and manage relational databases; has options for multi-AZ deployment and read replicas across Regions

**Aurora** - AWS branded relational database service compatible with MySQL and PostgreSQL

**DynamoDB** - AWS branded, serverless NoSQL database

**DocumentDB** - AWS branded, serverless document database that supports MongoDB 

**ElastiCache** - AWS branded in-memory datastore compatible with Redis and Memcached; good for high performance and low latency, but data can be lost

**Neptune** - AWS branded, serverless graph database for highly connected datasets like social media

**Database Migration Service (DMS)** - Service that helps you migrate databases to or within AWS; has continuous data replication and virtually no downtime

**Server Migration Service (SMS)** - Legacy service that allows you to move on-prem instances to AWS as Amazon Machine Image (AMI) EC2 instances; largely replaced by AWS Application Migration Service (MGN)

**AWS Snowcone** - Smallest (5lb/8TB) physical data transfer device that can be mailed or use DataSync

**AWS Snowball** - 50lb, petabyte-scale physical data transfer device

**AWS Snowball Edge** - 50lb, petabyte-scale physical data transfer device that supports EC2 and Lambda

**AWS Snowmobile** - Literal semi-truck for transporting data to AWS

**DataSync** - Service that allows for online data transfer from on-prem to AWS, between storage services, or across Regions or accounts

**Redshift** - AWS branded data warehouse solution

**Athena** - Serverless pay-per-query SQL service for S3

**AWS Glue** - AWS branded extract, transform, load (ETL) service 

**Kinesis** - Service for analyzing data in motion like media, logs, and IoT

**Elastic MapReduce (EMR)** - Service for analyzing big data using open-source tools such as Apache Hadoop, Spark, and Hive

**AWS Data Pipeline** - Service that helps move data between compute and storage services in AWS or on-prem

**QuickSight** - Business Intelligence (BI) service for publishing interactive, online dashboards for visualizing data

**Rekognition** - AI service for image/video analysis like face/text detection and custom labels

**AWS Comprehend** - AI service for natural-language processing (NLP) like sentiment analysis

**Polly** - AI service for text-to-speech with the ability to create custom voices

**SageMaker** - AWS branded AI service for neural networks

**AWS Translate** - AI service for language translation including real-time translation

**Lex** - AI service for chatbots that powers Alexa

**Cloud9** - AWS branded web IDE

**CodeCommit** - Legacy AWS branded git repository service

**CodeBuild** - AWS branded CI/CD service for compiling source code, running automated tests, and producing build artifacts 

**CodeDeploy** - AWS branded CI/CD service for posting code to EC2, Fargate, Lambda, and/or on-prem

**CodePipeline** - CI/CD service that can orchestrate code compilation, testing, and deployment using other CI/CD services

**AWS X-Ray** - Service for tracing requests throughout an application including network traffic and function/database calls; used for debugging/analysis

**CodeStar** - AWS branded issue tracking dashboard service that can integrate with AWS CI/CD services

**CloudFormation** - Service for provisioning AWS resources using Infrastructure as Code (IaC); provides templates

**Elastic Beanstalk** - Orchestration service for web apps that supports autoscaling, provisions resources, automatically handles deployment, and provides an application health dashboard; not for on-prem

**OpsWorks** - Service for automating the configuration of servers and deployment of code on-prem or on AWS using Chef or Puppet

**Simple Queue Service (SQS)** - Service for lining up asynchronous FIFO messages between services for loose coupling of apps

**Simple Notification Service (SNS)** - Service for publishing plain-text SMS, SQS, HTML, or email messages to subscribers of topics

**Simple Email Service (SES)** - Service for sending formatted emails e.g. for marketing campaigns

**CloudWatch** - Collection of services for monitoring logs, metrics, and events which can detect anomalies, set alarms, and visualize logs; monitors EC2 instances

**CloudTrail** - Service that tracks user activity and API calls within your account; tracks username, event time and name, IP address, access key, Region, and error code

**Security and Compliance

**Identity and Access Management (IAM)** - Free, global service that allows you to control access to your AWS services and resources

**IAM Identities** - Controls over who can access your recourses. e.g. root user, individual users, groups, roles

**IAM Access** - Controls over what resources users can access. e.g. AWS managed policies, customer managed policies, permissions boundaries

**IAM Users** - IAM entities representing a person or application

**IAM Group** - Collection of IAM users used for applying policies and roles to all members

**IAM Roles** - Non-permanent permissions assigned to IAM Users

**IAM Policies** - Definition of permissions for IAM users, groups, and roles in a JSON document

**IAM Credential Report** - List of all IAM users and status of passwords, access keys, and MFA devices for auditing and compliance

**Web Application Firewall (WAF)** - Service that helps protect web applications against common attacks like SQL injection and cross-site scripting

**AWS Shield Standard** - Free distributed denial of service (DDoS) protection service

**AWS Shield Advanced** - Paid distributed denial of service (DDoS) protection service with 24/7 access to AWS experts for a fee; works with CloudFront, Rout53, Elastic Load Balancing, and AWS Global Accelerator

**AWS Macie** - Service that helps discover sensitive data / PII like passport numbers, social security numbers, and credit card numbers in S3

**AWS Config** - Service for tracking the configuration history of resources using a config history file in S3 or SNS for config changes

**AWS GuardDuty** - Service that uses AI to detect unauthorized behavior like unusual API calls on EC2, S3, and IAM or in CloudTrail, VPC Flow Logs, or DNS logs

**AWS Inspector** - Service installed on EC2 to report vulnerabilities like access from the internet, remote root login, or vulnerable software versions

**AWS Artifact** - Central repository for compliance reports from third-party auditors

**AWS Cognito** - Service for user sign-in/sign-up for mobile and web applications

**Key Management Service (KMS)** - Service for generating and storing encryption keys

**Cloud Hardware Security Model (CloudHSM )** - Service for generating your own encryption keys on dedicated hardware that AWS does not have access to

**Secrets Manager** - Service for managing and retrieving passwords and keys; has an API for retrieving credentials; built-in integration with RDS, Redshift, and DocumentDB

**Pricing, Billing, and Governance

**Total Cost of Ownership (TCO)** - A financial estimate of the direct and indirect costs of AWS

**AWS Pricing Calculator** - Tool for calculating the TCO of using AWS services

**Application Discovery Service** - Service that helps you plan a migration to the AWS Cloud and estimate TCO

**AWS Price List API** - Service for querying the price of AWS services using JSON or HTML and sends price alerts when prices change

**AWS Budgets** - Billing service that alerts you when your costs or usage exceed a planned amount

**AWS Cost and Usage Reports** - The most comprehensive set of billing data with aggregate data on a daily, hourly, and monthly level

**AWS Cost Explorer** - Service for visualizing and forecasting your billing over the past 12 months and next 3 months

**Cost Allocation Tags** - Tool for labeling resources to create organized billing reports

**AWS Organizations** - Way for you to manage multiple AWS accounts under one umbrella; allows for consolidated billing, volume discounts, automated account creation, and cross-account policies

**AWS Control Tower** - Service for setting Organization-wide policies and provides a dashboard for managing accounts

**AWS Systems Manager** - Service for viewing and controlling AWS resources within your Organization; enables you to auto-patch and run commands on multiple instances

**AWS Trusted Advisor** - Service for providing guidance on how to use AWS best practices

**AWS License Manager** - Service for managing software licenses for Oracle, Microsoft, SAP, etc; works for hybrid

**AWS Certificate Manager** - Service for managing SSL/TLS certificates for free

**AWS Managed Services** - A dedicated team of AWS experts who take care of daily operational activities such as monitoring, patching, backups, and incident management

**AWS Professional Services** - Consulting service for moving enterprise customers to AWS

**AWS Partner Network (APN)** - Global community of approved AWS consulting partners

**AWS Marketplace** - Digital catalog of prebuilt AWS solutions that you can purchase,  license, or sell on

**AWS Personal Health Dashboard** - Service that alerts you to events that might impact your environment, provides troubleshooting guidance, and offers feedback based on your setup 

**Basic Support Plan** - Free AWS support plan

**Developer Support Plan** - $29/month support plan that allows for unlimited support cases and provides a dedicated support associate available via email within 24 hours during business hours

**Business Support Plan** - $100+/month support plan that allows for all Trusted Advisor checks, unlimited contacts, and 24/7 email, phone, or chat support

**Enterprise Support Plan** - $15,000+/month support plan with a Technical Account Manager (TAM) and the Concierge Support Team

**Developer IAM, EC2, and S3

**AWS Access Keys** - Key ID and secret key used to connect to APIs or the CLI generated with `aws configure`

**EBS Solid State Drive (SSD) Volumes** - EBS volume type with good IOPS good for frequent read/write operations with small I/O size

**Previous General Purpose SSD (gp2) Volume** - Previous generic SSD drive good for boot disks and general applications

**Latest General Purpose SSD (gp3) Volume** - Latest, cheaper, generic SSD drive good for boot disks and general applications

**Previous Provisioned IOPS SSD (io1) Volume** - Previous generation IOPS SSD optimized for OLTP and latency sensitive apps

**Latest Provisioned IOPS SSD (io2) Volume** - Latest generation IOPS SSD optimized for OLTP and latency sensitive apps

**Provisioned IOPS SSD (io2 Block Express) Volume** - IOPS SSD for largest, most critical, high-performance applications: SAP HANA, Oracle, Microsoft SQL Server, and IBM Db2

**EBS Hard Disk Drive (HDD) Volumes** - EBS volume type optimized for large streaming workloads and high throughput that cannot be boot volumes

**Throughput Optimized HDD (st1) Volume** - HDD volume suitable for big data, data warehouses, and ETL

**Cold HDD (sc1) Volume** - HDD volume for less frequently accessed data

**EBS Snapshot** - A point-in-time copy of an EBS volume that can be encrypted 

**Application Load Balancer** - Load balancer for HTTP/HTTPS that routes requests to a specific web server based on the request type

**Network Load Balancer** - High-performance load balancer for TCP traffic

**Classic Load Balancer** - Legacy load balancer that supports both HTTP/HTTPS and TCP

**Gateway Load Balancer** - Load balancer for third-party virtual appliances (pre-configured instances)

**X-Forwarded-For** - HTTP header used to identify the IPv4 address of a client

**504 Error** - Gateway timeout error that occurs when an app is not responding in the timeout period

**RDS Automated Backups** - Automated, enabled by default, point-in-time snapshot of an RDS instance with transaction logs and a user defined retention period up to 35 days

**DB Snapshot** - Ad hoc point-in-time database backup 

**RDS Multi-AZ** - Service for keeping an exact copy of an RDS instance in another AZ for disaster failover

**RDS Read Replica** - A read-only copy of a primary DB used to scale read performance

**ElastiCache Memcached** - In-memory, key-value data store good for keeping things simple when persistence is not a necessity

**ElastiCache Redis** - In-memory, key-value data store good if you need data persistence, multiple AZs, data sorting/ranking, or advanced data types

**Parameter Store** - Information reference for passwords, env variables, license codes, etc that works with compute and CI/CD services and can be encrypted

**CloudFront Origin** - Main source of files that CloudFront will serve. Can be an S3 bucket, an EC2 instance, an Elastic Load Balancer, or Route 53

**CloudFront Distribution** - The origin and configuration settings for the content you put on CloudFront (CDN)

**Serverless Computing

**$LATEST** - Keyword for specifying the most up-to-date version of a Lambda function

**HTTP Code 429** - Too many request error code thrown when an app exceeds its quota

**AWS Step Functions** - Visual workflow service for coordinating distributed applications and microservices

**Standard Workflow Step Function ** - Step function workflow that can take up to 1 year, executes exactly-once, and is idempotent

**Synchronous Express Workflow Step Function** - Step function workflow that must complete before the next step begins

**Express Workflow Step Function** - Short lived (up to 5 minutes) at-least-once, idempotent step function workflow

**Asynchronous Express Workflow Step Function** - Step function workflow for when other tasks do not depend on the completion of the workflow

**Lambda Reserved Concurrency** - Lambda service that guarantees a set number of simultaneous executions for a function

**API Gateway Caching** - API Gateway service for temporarily storing the response to a request to avoid calling your backend every time; default TTL is 300 seconds

**/tmp Ephemeral Storage** - Temporary storage location for Lambda with dynamic read/write shared with instances within an execution environment; max storage of 10GB

**Lambda Layers** - Lambda storage for storing libraries/SDKs shared across an execution environment; max storage 50MB zipped or 250MB unzipped

**DynamoDB

**IAM Condition Parameters “dynamodb:LeadingKeys”** - IAM/DynamoDB feature that allows users to access only the items where the partition key value matches their User_ID.

**Local Secondary Index** - DynamoDB index with same partition key and different sort key to your table that must be created when the table is created

**Global Secondary Index** - DynamoDB index with different partition key and different sort key to your table that can be created any time

**Setting the ScanIndexForward Parameter to False** - Method of reversing the query results in DynamoDB

**DynamoDB Scan CLI Command** - CLI command that reads every item in a DynamoDB table and returns all items and attributes. Use a filter expression to return fewer items

**DynamoDB Query CLI Command** - CLI command that searches a DynamoDB table based on a partition key value that you provide

**Other Services

**Customer Master Key (CMK)** - Key for encrypting/decrypting up to 4KB of data or a data key and generating data keys

**Data Key** - Key used to encrypt/decrypt large amounts of data

**Envelope Encryption** - Method of using a CMK to encrypt a data key and using that data key to encrypt other data to avoid sending all the data to KMS over the network

**'aws kms re-encrypt’** - KMS API call used for key rotation that decrypts ciphertext and reencrypts it with a new CMK 

**SQS Standard** - Default SQS queue type with best-effort ordering, and at-least-once delivery, but occasional duplicates

**SQS FIFO** - SQS queue type with strictly preserved ordering and no duplication

**SQS Visibility Timeout** - The period of time that a message is hidden in a queue; default 30 seconds, max 12 hours

**SQS Short Polling** - More costly queue response method which responds immediately even if no messages are available

**SQS Long Polling** - Default queue response method which only returns a response when a message is available or the timeout is reached

**Kinesis Shards** - Fixed unit of capacity for a Kinesis stream

**Kinesis Client** - A consumer of a Kinesis stream; need at-most 1 per shard

**All-at-Once Deployment** - Deployment that interrupts service and must be repeated if a rollback is needed

**Rolling Deployment** - Deployment conducted in batches that reduces capacity and must be repeated if a rollback is needed

**Rolling with Additional Batch Deployment** - Deployment that maintains full capacity, but must be repeated if a rollback is needed

**Immutable Deployment** - Deployment that maintains full capacity and preserves the old instances incase a rollback is needed

**Traffic Splitting Deployment** - Deployment that adds capacity and then slowly redirects traffic to the new instances enabling canary testing

**Elastic Compute Service (ECS)** - Managed compute container orchestration service that is simpler but AWS specific

**Elastic Kubernetes Service (EKS)** - Managed compute container service for the open source container orchestration platform Kubernetes

