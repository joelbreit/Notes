# Cloud Computing Terms

Random Read - accessing data from a non-sequential, random location in storage. It contrasts with sequential reads and is typically slower due to the additional seek time required.
Random Write - writing data to a non-sequential, random location in storage. Like random reads, this process can be slower than sequential writes due to the need for seeking
Tablet,a partition of data stored across a distributed database system. It allows for scalable and efficient data access and management
Gossip protocol - a communication protocol for distributed systems used for spreading information in a network efficiently and reliably, mimicking the spreading of gossip in social networks.
Secure Multiplexing - the process of safely sharing a single communication channel among multiple independent data streams or sessions, ensuring data integrity and security
Cassandra - a highly scalable, distributed database designed to handle large amounts of data across many commodity servers, providing high availability with no single point of failure
Hypervisor - software, firmware, or hardware that creates and runs virtual machines. It allows multiple operating systems to share a single hardware host; Virtual Machine Monitor (VMM)
Paravirtualization - a virtualization technique where the guest operating system is modified to work in harmony with the hypervisor, improving performance and efficiency
Xen - An open-source virtualization software that works as a bare-metal hypervisor that optimizes the OS to work as a VM rather than hiding the fact that it is a VM from the OS (Paravirtualization) used for EC2 open-source type-1 or bare-metal hypervisor, allowing multiple guest operating systems to run simultaneously on a single physical host, with a focus on performance and security
DMA,a feature of computer systems that allows certain hardware subsystems to access main system memory (RAM) independently of the central processing unit (CPU)
Domain 0,the initial and privileged domain started by the Xen hypervisor on boot. It has direct access to the hardware and is responsible for launching other unprivileged domains (DomU)
Kernel - the core component of an operating system, managing system resources and the communication between hardware and software components
Hadoop - an open-source software framework for storage and large-scale processing of data sets on clusters of commodity hardware, utilizing the MapReduce programming model
Black-box VM migration - the process of moving a virtual machine from one physical host to another without detailed knowledge of the VM's internal state, focusing on the external observable characteristics
Gray-box VM migration - moving a virtual machine between hosts with some knowledge of the VM's internal state, allowing for more optimized and efficient migration
Sandpiper,system that automates the process of detecting and mitigating hotspots in data center environments through virtual machine migration and dynamic resource allocation
Pig Latin,a high-level platform for creating MapReduce programs used with Hadoop. It is designed to simplify the processing and analysis of large data sets
MapReduce - a programming model and an associated implementation for processing and generating large data sets with a parallel, distributed algorithm on a cluster
COGROUP - a command used to group the data from one or more relations based on one or more keys, allowing for complex aggregations and joins
Hive - a data warehousing infrastructure based on Hadoop. It provides a simple query language called HQL (Hive Query Language), which allows for data summarization, querying, and analysis
Spark - a unified analytics engine for large-scale data processing, with built-in modules for streaming, SQL, machine learning, and graph processing
resilient distributed datasets (RDDs) - a fundamental data structure of Spark. They are immutable, distributed collections of objects, which can be processed in parallel across a distributed cluster
Google Distributed File System,a scalable distributed file system for large distributed data-intensive applications. It provides fault tolerance while running on inexpensive commodity hardware
Type-1/Bare-Metal Hypervisor - hypervisor that runs directly on the physical hardware of the host, without an underlying operating system, offering high performance for virtualized environments
Type-2/Hosted Hypervisor,hypervisor that runs on a conventional operating system just like other computer programs. It offers more flexibility but might not provide the same performance level as Type-1 hypervisors