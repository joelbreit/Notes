# HTTP Notes

## HTTP Methods

1. **GET**:  Method that requests a representation of the specified resource and should only retrieve data
2. **HEAD**:  Method that asks for a response identical to that of a GET request, but without the response body
3. **POST**:  Method that is used to submit an entity to the specified resource, often causing a change in state or side effects on the server
4. **PUT**:  Method that replaces all current representations of the target resource with the request payload
5. **DELETE**:  Method that removes the specified resource
6. **CONNECT**:  Method that establishes a tunnel to the server identified by the target resource
7. **OPTIONS**:  Method that is used to describe the communication options for the target resource
8. **TRACE**:  Method that performs a message loop-back test along the path to the target resource
9. **PATCH**:  Method that is used to apply partial modifications to a resource

## HTTP Headers

10.  **Range**:  Request header indicating the portion that the server should return; used to request part of a larger document, or to resume a download that was interrupted
11.  **Upgrade**:  Request header indicating a client's preferred protocol; server may respond with 101 Switching Protocols and echo the header
12. **Accept**:  Request header specifying the media types a client can handle e.g. JSON or XML
13. **Expect**:  Request header indicating anticipated behavior e.g. returning a 100 Continue response
14. **Location**:  Response (primarily) header indicating new or updated URLs e.g. in a 201 Created or 3xx Redirection response
15. **Content-Range**: Response header indicating the range of bytes being sent

## HTTP Status Codes

### Groups

15. **100s**:  Information responses group
16. **200s**:  Successful responses group
17. **300s**:  Redirection messages group
18. **400s**:  Client error responses group
19. **500s**:  Server error responses group

### Informational 1xx

20. **100**: Continue - The initial part of the request has been received by the server and the client should proceed with the request
21. **101**: Switching Protocols - The server has received the client's upgrade request. Indicates the protocol the server is switching to
22. **102**: Processing - (Deprecated) The server has received and is working on the request, but no response is available yet
23. **103**: Early Hints - The server is likely to send some response headers before the final response

### Successful 2xx

24. **200**: OK - The resource has been fetched and transmitted in the message body
25. **201**: Created - The request has been fulfilled and resulted in a new resource being created
26. **202**: Accepted - The request has been accepted for processing, but the processing has not been completed
27. **203**: Non-Authoritative Information - The server is a transforming proxy that received a 200 OK from its origin, but is returning a modified version of the origin's response
28. **204**: No Content - The server successfully processed the request and is not returning any content
29. **205**: Reset Content - Tells the user agent to reset the document which sent this request
30. **206**: Partial Content - The server is delivering only part of the resource due to a range header sent by the client
31. **207**: Multi-Status - Conveys information about multiple resources, in situation when multiple status codes are appropriate like when there where multiple sub-requests
32. **208**: Already Reported - Information has already been enumerated in a preceding part of the (multistatus) response, and are not being included again
33. **226**: IM Used - The server has fulfilled a GET request for the resource, and the response is a representation of the result

### Redirection 3xx

34. **300**: Multiple Choices - The request has more than one possible response. The user agent or user should choose one of them
35. **301**: Moved Permanently - The URL of the requested resource has been changed permanently
36. **302**: Found - The URL of the requested resource has been changed temporarily
37. **303**: See Other - The server sent this response to direct the client to get the requested resource, e.g. after a PUT request, at another URI with a GET request
38. **304**: Not Modified - The resource has not been modified since the last request, so the client can use the cached version
39. **305**: Use Proxy - (Deprecated) The requested resource is only available through
40. **306**: Switch Proxy - (No longer used) Originally meant "Subsequent requests should use the specified proxy"
41. **307**: Temporary Redirect - The URL of the requested resource has been changed temporarily, and the same method should be used to access it
42. **308**: Permanent Redirect - The URL of the requested resource has been changed permanently, and the same method should be used to access it

### Client Error 4xx

43. **400**: Bad Request - The server cannot process the request due to an apparent client error, e.g. invalid syntax
44. **401**: Unauthorized - You need to prove who you are
45. **402**: Payment Required - (Reserved for future use)
46. **403**: Forbidden - I know who you are, but you don't have permission to do this
47. **404**: Not Found - The server cannot find the requested resource
48. **405**: Method Not Allowed - The request method is known by the server but is not supported by the target resource
49. **406**: Not Acceptable - The server cannot generate a response that is acceptable by the client as indicated by the accept headers
50. **407**: Proxy Authentication Required - You need to authenticate with the proxy before you can use this resource
51. **408**: Request Timeout - The server timed out waiting for the request
52. **409**: Conflict - The request conflicts with the current state of the resource such as an edit conflict between multiple simultaneous updates
53. **410**: Gone - The resource is no longer available and clients should remove it from their cache
54. **411**: Length Required - The request did not specify the length of its content, which is required by the requested resource
55. **412**: Precondition Failed - The client has indicated preconditions in its headers which the server does not meet
56. **413**: Payload Too Large - The request is larger than the server is willing or able to process. The server might close the connection or return an Retry-After header field
57. **414**: URI Too Long - The URI requested by the client is longer than the server is willing to interpret
58. **415**: Unsupported Media Type - The request has a media type which the server or resource does not support
59. **416**: Range Not Satisfiable - The client has asked for a portion of the file, but the server cannot supply that portion
60. **417**: Expectation Failed - The server cannot meet the requirements of the Expect request-header field e.g. the client asked for 100-continue
61. **418**: I'm a teapot - (an old April Fools' joke) Returned by teapots requested to brew coffee
62. **421**: Misdirected Request - The request was directed at a server that is not able
63. **422**: Unprocessable Entity - The request was well-formed but was unable to be followed due to logic errors in the data
64. **423**: Locked - The resource that is being accessed is locked
65. **424**: Failed Dependency - The request failed due to failure of a previous request
66. **425**: Too Early - Indicates that the server is unwilling to respond because, for example, it might be a duplicate of another request that hasn't finished processing
67. **426**: Upgrade Required - The client should switch to a different protocol. Includes an upgrade header in the response
68. **428**: Precondition Required - The origin server requires the request to be conditional to avoid conflicts
69. **429**: Too Many Requests - The user has sent too many requests in a given amount of time
70. **431**: Request Header Fields Too Large - The server is unwilling to process the request because its header fields are too large
71. **451**: Unavailable For Legal Reasons - The server is denying access to the resource as a consequence of a legal demand

### Server Error 5xx

72. **500**: Internal Server Error - The server has encountered a situation it doesn't know how to handle
73. **501**: Not Implemented - The request method is not supported by the server and cannot be handled
74. **502**: Bad Gateway - The server was acting as a gateway or proxy and received an invalid response from an upstream server
75. **503**: Service Unavailable - The server cannot handle the request (because it is overloaded or down for maintenance). Generally, this is temporary
76. **504**: Gateway Timeout - The server was acting as a gateway or proxy and did not receive a timely response from an upstream server
77. **505**: HTTP Version Not Supported - The server does not support the HTTP protocol version used in the request
78. **506**: Variant Also Negotiates - Transparent content negotiation for the request results in a circular reference
79. **507**: Insufficient Storage - The server is unable to store the representation needed to complete the request
80. **508**: Loop Detected - The server detected an infinite loop while processing the request
81. **510**: Not Extended - The server needs more information to fulfill the request
82. **511**: Network Authentication Required - Used by intercepting proxies (like public Wi-Fi) to control access to the network

### Other

83. **URI (Uniform Resource Identifier)**:  String of characters that identifies a resource either by location, name, or both