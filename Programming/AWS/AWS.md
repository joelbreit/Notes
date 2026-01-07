# AWS Notes and Flash Cards

## Notes

Flashcards should work both ways
- Term -> Definition as well as Definition -> Term
- The definition should never use the entire term and should try to avoid using part of the term
- The definition should be concise and specific

## Compute

### Deployment Strategies

**All-at-Once Deployment** - Deployment strategy that immediately updates all existing instances with likely downtime and no fallback

**Rolling Deployment** - Deployment strategy that updates iteratively without adding capacity

**Rolling with Additional Batch Deployment** - Deployment strategy that updates your existing resources iteratively and adds enough resources to maintain capacity

**Immutable Deployment** - Deployment strategy that creates a new environment with your update allowing for testing before you switch and avoiding a mixed environment

**Blue/Green Deployment** - Deployment strategy that creates a new environment with your update then updates the DNS record to point to that new environment

**Canary Deployment** - Deployment strategy that updates some of your application allowing for testing with real traffic before updating everywhere

## Serverless Architecture

### Containers

1. **Elastic Container Service (ECS)**: Managed container orchestration service that is simpler but AWS specific
2. **Elastic Kubernetes Service (EKS)**: Managed compute container service for the open source container orchestration platform Kubernetes
3. **Fargate**: Serverless compute option for containers that works within ECS or EKS
4. **Docker**: Open source platform for developing, shipping, and running applications inside containers
5. **Kubernetes**: Open source container orchestration platform for automating the deployment, scaling, and management of containerized applications
6. **EventBridge**: Serverless event bus service for triggering actions when events happen in various AWS services
7. **Amazon Elastic Container Registry (ECR)**: Managed container organizing service for storing, managing, and deploying Docker container images

## Security

1. **CloudTrail**: Service that logs all API calls made in an AWS account
2. **AWS Shield**: Free managed Distributed Denial of Service (DDoS) protection service for layers 3 and 4 (network and transport layers)
3. **AWS Shield Advanced**: Managed Distributed Denial of Service (DDoS) protection service with real-time visibility and additional protections for $3,000 per month
4. **AWS Web Application Firewall (WAF)**: Managed traffic filtering service that operates at layer 7 (application layer) to protect against exploits like SQL injection and cross-site scripting and can block IP addresses or regions
5. **AWS GuardDuty**:  Threat detection service that uses AI to that continuously monitors various logs for malicious or adnormal behavior like 1. Port scanning 2. Cryptocurrency mining 3. Unauthorized access using a database of malicious domains
6. **Firewall Manager**: Managed security service that makes it easier to centrally configure and manage AWS WAF rules across multiple AWS accounts
7. **Macie**: PII detection service that uses AI to scan for and alert you about sensitive data
8. **Inspector**: Automated security assessment service that runs host assessments on EC2 instances and network assessments on VPCs
9. **Key Management Service (KMS)**: Service for creating and controlling encryption keys
10. **Cloud Hardware Security Module (HSM)**: Service for generating and using encryption keys on your own hardware
11. **Secrets Manager**: Service for storing and rotating things like API keys, passwords, and database credentials
12. **Parameter Store**: Free service for storing configuration data and secrets without rotation
13. **S3 Pre-Signed URLs**: URLs that grant time-limited access to private objects in S3 buckets
14. **Amazon Resource Names (ARNs)**: Unique identifiers for AWS resources that are used in IAM policies to grant access to resources
15. **ARN Structure**: arn:partition:service:region:account-id:resource
16. **Certificate Manager**: Free to use service for managing SSL/TLS certificates that automatically renews and deploys them to AWS resources
17. **Audit Manager**: Service for continuously monitoring and auditing AWS resources for compliance with industry standards and regulations such as HIPAA, PCI, and GDPR
18. **Payment Card Industry Data Security Standard (PCI DSS)**: Security standards for ensuring that all companies that handle credit card information do so securely
19. **AWS Artifact**: Service for accessing AWS compliance documents for external auditors
20. **Amazon Detective**: Service for analyzing, investigating, and identifying the root cause of security issues or suspicious activities
21. **Network Firewall**: AWS managed physical hardware traffic filtering service for VPCs prior to their internet gateway
22. **Security Hub**: Dashboard service for viewing security alerts across multiple AWS accounts
23. **AWS Access Keys**: Set of security keys (access key ID and secret access key) needed in order to use AWS resources via the API

## Automation

1. **CloudFormation Template Language**: Declarative language for defining AWS resources and their relationships in JSON or YAML
2. **CloudFormation Template Sections**: 1. AWSTemplateFormatVersion 2. Parameters 3. Mappings 4. Resources 5. Outputs 6. Transform
3. **CloudFormation Stack**: Collection of AWS resources that are created and managed as a single unit
4. **Apache Tomcat**: Open source software application that acts as a web server for running Java applications
5. **Elastic Beanstalk**: Managed service for deploying and scaling web applications and services developed in nearly any language
6. **Systems Manager**: Service for managing and automating operational tasks across AWS resources
7. **Systems Manager Agent (SSM)**: Software that is installed on EC2 instances to enable Systems Manager to manage them
8. **Patch Manager**: Systems Manager feature for automating the process of updating EC2 instances

## Caching

1. **DynamoDB Accelerator (DAX)**: In-memory caching service for DynamoDB that can improve read performance with configuration settings for location, VPC, TTL, node size/count, etc
2. **Memcached**: Open source, in-memory key-value store used for caching data
3. **Redis**: Open source, in-memory NoSQL database that supports backups and multi-AZ failover
4. **Global Accelerator (GA)**: Service for sending user TCP and UDP traffic through the AWS network via edge locations that can use AnyCast IP addresses

## Governance

### Flash Cards

1. **Management Account**: AWS account that is used to create and manage AWS Organizations
2. **Member Account**: AWS account that is part of an AWS Organization
3. **Service Control Policies (SCPs)**: Rules that dictate which services and features can be used by member accounts of an AWS Organization
4. **Organizational Units (OUs)**: Feature in AWS Organizations that allows for logical grouping of member accounts
5. **Resource Access Manager (RAM)**: Service for sharing AWS resources like VPC subnets, Licenses, Route 53 rules, dedicated hosts, and transit gateways across multiple AWS accounts
6. **Cross Account Role Access**: Feature for granting revokeable permissions to resources in one AWS account from another AWS account with rotating temporary credentials
7. **AWS Config**: Inventory management service that works across accounts, runs rules on a schedule, can send SNS alerts, can remediate issues via Lambda, and is billed per evaluation
8. **Active Directory**: Microsoft service for managing users, groups, and computers in a network
9. **Directory Service**: Managed AWS service for Active Directory
10. **Managed Microsoft AD**: Directory Service type used for running fully featured Active Directory in AWS
11. **AD Connector**: Directory Service type used for connecting on-prem Active Directory to AWS
12. **Simple AD**: Directory Service type used for running Samba-based Active Directory in AWS
13. **Control Tower**: Management orchestration service for easy use of Organization services
14. **Landing Zone**: Control Tower feature for initial setup of Shared Accounts
15. **Guardrails**: Control Tower feature for enforcing preventative, detective, and proactive policies
16. **Shared Accounts**: AWS accounts (Management, Log Archive, Security) used by Control Tower for Organization management
17. **Account Factory**: Control Tower tool for creating new accounts
18. **Compute Optimizer**: Service for usage of and recommending configurations for EC2, EBS, Lambda, and Fargate
19. **Service Catalog**: Service for creating and managing catalogs of cloud solutions with CloudFormation templates for use within your Organization
20. **Proton**: Legacy service for managing and deploying microservices with CI/CD integration
21. **Well-Architected Tool**: Service for reviewing and improving the architecture of cloud solutions in AWS

### Notes

#### AWS Config

- Works with AWS Organizations
- Not free - billed per rule per resource and per evaluation
- Rules evaluated on a schedule or by a trigger
- Configured per Region
- Can be aggregated across Regions or accounts
- Allows for alerts via SNS
- Allows for automatic remediation via Lambda

#### AWS Budgets

- Cost Budgets - spend limit for a service
- Usage Budgets - usage limit for one or many services
- RI Utilization - see if reserved instances are underutilized
- RI Coverage - see how much instance usage is covered by RIs
- Savings Plans Utilization - see if savings plans are underutilized
- Savings Plans Coverage - see how much instance usage is covered by savings plans

#### Trusted Advisor

- Service Limit checks
- Security checks
- Categories: Cost Optimization, Performance, Security, Fault Tolerance, Service Limits
- Basic and Developer support plans get all Service Limit checks and 6 Security checks
- Business and higher get all checks and integration with EventBridge for resolving alerts

#### Control Tower

~~CloudFormation StackSets - Control Tower tool for deploying resources like IAM roles and ~~

- Service for setting up and governing a multi-account AWS environment
- Orchestration of AWS Organizations, AWS Single Sign-On, AWS Config, AWS Service Catalog, AWS CloudTrail, AWS GuardDuty, and AWS Config
- Landing Zone - initial setup of Control Tower
- Guardrails - rules for enforcing policies
  - Preventive - blocks actions
    - Status of enforced or not enabled
    - Uses service control policies
  - Detective - detects and alerts
  	- Uses AWS Config rules
  	- Status of clear, in violation, or not enabled
  - Proactive - prevents non-compliant resources from being created
    - Uses CloudFormation Hooks
- Account Factory - tool for creating new accounts
- CloudFormation StackSets - tool for deploying resources across multiple accounts and Regions
- Shared Accounts
  - Management - for managing Control Tower
  - Log Archive - for storing logs
  - Security - for security tools

## Migration

### Flash Cards

1. **Database Migration Service (DMS)**: Service for moving or copying existing relational, NoSQL, or data warehouse databases to or within AWS
2. **Schema Conversion Tool (SCT)**: DMS feature for converting DBs between different engine types
3. **SMS**: Legacy service for converting existing VMs to Amazon Machine Images
4. **Migration Hub**: Single front-end for MGN and DMS
5. **Application Migration Service (MGN)**: Service for migrating on-prem applications to AWS
6. **DataSync**: Service that uses an agent to move lots of data encrypted in transit using the internet, Direct Connect, or VPN best for one-time migrations
7. **Storage Gateway**: Hybrid storage service for connecting on-prem storage to AWS
8. **Direct Connect**: A dedicated physical network connection from your on-prem data center to AWS which bypasses the public internet for better connection
9. **Application Discovery Service**: Service for discovering on-prem applications and their dependencies
10. **Open Virtualization Format (OVF)**: File format for exporting VMs
11. **Application Migration Service (MGN)**: Service for migrating on-prem applications to AWS

### Notes

Snowball
- Snow Cone
    - 8TB storage
    - 4GB memory 
    - 2vCPUs
- Snowball
    - 
- Snowball Edge
    - 48-81TB
- 
- Snow Mobile
    - 100PD storage

Direct Connect

1. **DataSync**: move lots of data over the internet, via Direct Connect, or via VPN
- Need to set up an agent
- Encrypted on the internet
- Better for one-time migration

1. **Storage Gateway**: hybrid storage system
- File Gateway - NFS or SMB “mount”
- Volume Gateway - migrate local volumes to EBS volumes
- Tape Gateway - replaces physical tapes
- Better for ongoing hybrid solutions

Transfer Family

1. **Migration Hub**: Single front-end for SMS and DMS

Application Discovery Service - 

OVA file

## Machine Learning

### Flash Cards

1. **AWS Textract**: AWS OCR AI service that automatically extracts text, handwriting, and data from scanned documents and tries to recognize the relationships among data fields
2. **Kendra**: AI service for enterprise search that uses natural language processing to search across multiple data sources
3. **Amazon Forecast**: Discontinued AI service for time-series forecasting for predicting future trends
4. **Transcribe**: AI service for converting speech to text
5. **Lex**: AI service for building conversational interfaces (chatbots)
6. **Polly**: AI service for converting text to speech
7. **Rekognition**: AI service for detecting faces, objects, celebrities, and text in images and videos
8. **SageMaker**: AI service for building, training, and deploying machine learning models
9. **Translate**: AI service for translating text between languages
10. **Fraud Detector**: AI service for detecting online fraud allowing for custom training or using pre-built models

## Other

1. **Simple WorkFlow (SWF)**: Fully-managed state tracker and task coordinator that supports scenarios where human intervention is required
2. **FSx**: Fully managed Windows and Lustre file systems
3. **Lustre**: High-performance file system for large-scale computing
4. **Recovery Time Objective (RTO)**: maximum acceptable time to restore operation after a failure
5. **Recovery Point Objective (RPO)**: maximum acceptable duration since the last valid data backup in the event of a failure
6. **Cron job**: Scheduled task that runs at a specific time or interval based on a Unix expression of time
7. **PrivateLink**: Service for securely connecting VPCs to AWS services without exposing data to the public internet
8. **Device Farm**: Service for testing web and mobile applications on real devices
9. **Pinpoint**: Service for sending targeted messages to users via email, SMS, push notifications, and in-app messages
10. **Timestream**: AWS serverless time-series database
11. **Elastic Transcoder**: Service for converting media files from one format to another like for optimizing video for different devices
12. **Kinesis Video Streams**: Service for streaming video from connected devices to AWS for analytics, machine learning, and other processing


## VPCs


* The default network ACL allows all in and out traffic
* The final rule for the default ACL disallows all traffic
* The final rule cannot be modified or removed
* You can assign up to five security groups to the instance
* Security groups act at the instance level, not the subnet level
* Subnets have a 1-to-1 relationship with AZs
* Every VPC has a default security group
* Instances in a VPC are automatically assigned to the default security group
* The default VPC security group cannot be deleted
* Subnets have IP address ranges, not a specific IP address
* A public subnet is just a subnet that has been routed to an internet gateway
* A private subnet is just a subnet that has not been routed to an internet gateway
* 