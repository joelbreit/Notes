# MongoDB Notes

## Background

MongoDB is a NoSQL database that stores data in a JSON-like format. It is a popular choice for web applications because it is easy to use and can store large amounts of data.

Created in 2007 by 10gen, MongoDB is now maintained by MongoDB Inc. It is open-source and free to use.

## Terms

- **Document**: *A record in a MongoDB collection*
- **Collection**: *A group of documents in MongoDB*
- **Database**: *A group of collections in MongoDB*
- **Field**: *A key-value pair in a MongoDB document*
- **Index**: *A data structure that improves the speed of data retrieval operations on a MongoDB collection*
- **Replica Set**: *A group of MongoDB servers that maintain the same data set for high availability and fault tolerance*
- **Sharding**: *A method of distributing data across multiple servers to improve performance and scalability*
- **Aggregation Pipeline**: *A framework for data aggregation operations in MongoDB*
- **GridFS**: *A specification for storing and retrieving large files in MongoDB*
- **Capped Collection**: *A fixed-size collection in MongoDB that automatically removes the oldest documents when it reaches its size limit*
- **Change Streams**: *A feature in MongoDB that allows applications to listen for changes in a collection in real-time*
- **Transactions**: *A feature in MongoDB that allows multiple operations to be grouped*
- **ACID**: *A set of properties that guarantee the reliability of database transactions: Atomicity, Consistency, Isolation, Durability*
- **MQL**: *MongoDB Query Language*
- **BSON**: *Binary JSON, a binary representation of JSON documents used by MongoDB*
- **MongoDB Compass**: *A graphical user interface for MongoDB*
- **MongoDB Atlas**: *A cloud-based database service for MongoDB*
- **MongoDB Stitch**: *A serverless platform for MongoDB that allows developers to build applications without managing servers*
- **MongoDB Realm**: *A mobile database platform for MongoDB that allows developers to build offline-first applications*
- **MongoDB Charts**: *A data visualization tool for MongoDB*
- **Cursor**: *A pointer to the result set of a query in MongoDB*
- **Explain Plan**: *A description of the query execution plan in MongoDB*
- **Read Concern**: *A setting that determines the level of consistency for read operations in MongoDB*
- **Write Concern**: *A setting that determines the level of acknowledgment for write operations in MongoDB*
- **Storage Engine**: *The component of MongoDB that manages the storage of data on disk*
- **WiredTiger**: *The default storage engine for MongoDB*
- **MMapv1**: *An older storage engine for MongoDB*
- **Document Validation**: *A feature in MongoDB that allows developers to enforce a schema on a collection*
- **Schema**: *A description of the structure of data in a database*
- **Document Model**: *A way of representing data in a database as a collection of documents*
- **Document-Oriented Database**: *A type of NoSQL database that stores data in a JSON-like format*
- **NoSQL**: *A category of databases that do not use the traditional tabular structure of relational databases*
- **CAP Theorem**: *A principle in distributed systems that states that it is impossible to guarantee Consistency, Availability, and Partition Tolerance at the same time*
- **BASE**: *A set of principles for designing distributed systems that prioritize Availability and Partition Tolerance over Consistency*
- **CRUD**: *Create, Read, Update, Delete*
- 

## Installation (MacOS)

(I have not tested this)

1. (Install Homebrew)
2. Install MongoDB Community Edition
```zsh
$ brew install mongodb-atlas
$ atlas setup
```

## Basic Commands

- **Start MongoDB Server**
```zsh
$ mongod
```
- **Connect to MongoDB Server**
```zsh
$ mongo
```
- **Show Databases**
```zsh
> show dbs
```
- **Create Database**
```zsh
> use mydatabase
```
- **Show Collections**
```zsh
> show collections
```
- **Create Collection**
```zsh
> db.createCollection("mycollection")
```
- **Insert Document**
```zsh
> db.mycollection.insertOne({name: "Alice", age: 30})
```
- **Find Documents**
```zsh
> db.mycollection.find()
```
- **Update Document**
```zsh
> db.mycollection.updateOne({name: "Alice"}, {$set: {age: 31}})
```
- **Delete Document**
```zsh
> db.mycollection.deleteOne({name: "Alice"})
```
- **Drop Collection**
```zsh
> db.mycollection.drop()
```
- **Drop Database**
```zsh
> db.dropDatabase()
```



## Questions

- [ ] "Stitch"