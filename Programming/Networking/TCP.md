# TCP (Transmission Control Protocol)

- Protocol at the transport layer (layer 4) of the OSI model
- Used for reliable, ordered, and error-checked delivery of data between applications communicating over a network

## Basics

- TCP connections have a server and a client, but that only means
  - The server listens on a specified port
  - The client must know the IP or port to use connect to the server
- TCP servers can have multiple clients connect to their single port
- Once connection is established, the server and client communicate in the same way
- TCP handles message integrity and order
- A TCP connection allows for a single stream of data in either direction
  - Messages can be sent and received at the same time
  - TCP sends data in message packets
  - When you send messages, you are adding them to a queue to be sent
    - Messages will be sent in order with integrity maintained
    - Messages might be split up or combined into packets
- Message boundaries need to be established on the application layer
- For string messages, delimiters like `\0` or `\n` can be used to specify the end of a message
- Other options include setting a fixed message structure or adding an envelope to each message
  - An envelope is a small header that specifies the message metadata

## MessagePack

- MessagePack works across languages and serializes data types (e.g. string, int32, double, etc) into a byte stream with predictable lengths
  - It also tracks structure with arrays and objects
- If all messages in one direction have the same data structure, MessagePack can handle the message boundary determination
- If message structures change ("multiplexing"), your app will need to define message boundaries
- MessagePack fields can be named or position based
  - If position based, changes will need to be made at the end, or all implementations will need to know about the update