# HTTP Notes

## HTTP Methods

-   **GET:** Method that requests a representation of the specified resource and should only retrieve data
-   **HEAD:** Method that asks for a response identical to that of a GET request, but without the response body
-   **POST:** Method that is used to submit an entity to the specified resource, often causing a change in state or side effects on the server
-   **PUT:** Method that replaces all current representations of the target resource with the request payload
-   **DELETE:** Method that removes the specified resource
-   **CONNECT:** Method that establishes a tunnel to the server identified by the target resource
-   **OPTIONS:** Method that is used to describe the communication options for the target resource
-   **TRACE:** Method that performs a message loop-back test along the path to the target resource
-   **PATCH:** Method that is used to apply partial modifications to a resource

## HTTP Headers

-   **Range:** Header indicating the part of a document that the server should return. This can be used to request only a portion of a large document, or to resume a download that was interrupted
-   **Upgrade:** Header used to specify the preferred protocol to use when communicating with the server
-   **Accept:** Header specifying the media types that are acceptable for the response such as JSON or XML
-   **Expect:** Header indicating the expected behavior of the server such as whether it should return a 100 Continue response
-   **Location:** Header typically used for specifying new or updated URLs in response messages

## HTTP Status Codes

### Groups

-   **100s:** Information responses group
-   **200s:** Successful responses group
-   **300s:** Redirection messages group
-   **400s:** Client error responses group
-   **500s:** Server error responses group

### Informational 1xx

-   **100 Continue:** The initial part of the request has been received by the server and the client should proceed with the request
-   **101 Switching Protocols:** The server has received the client's upgrade request. Indicates the protocol the server is switching to
-   **102 Processing:** (Deprecated) The server has received and is working on the request, but no response is available yet
-   **103 Early Hints:** The server is likely to send some response headers before the final response

### Successful 2xx

-   **200 OK:** The resource has been fetched and transmitted in the message body
-   **201 Created:** The request has been fulfilled and resulted in a new resource being created
-   **202 Accepted:** The request has been accepted for processing, but the processing has not been completed
-   **203 Non-Authoritative Information:** The server is a transforming proxy that received a 200 OK from its origin, but is returning a modified version of the origin's response
-   **204 No Content:** The server successfully processed the request and is not returning any content
-   **205 Reset Content:** Tells the user agent to reset the document which sent this request
-   **206 Partial Content:** The server is delivering only part of the resource due to a range header sent by the client
-   **207 Multi-Status:** Conveys information about multiple resources, in situation when multiple status codes are appropriate like when there where multiple sub-requests
-   **208 Already Reported:** Information has already been enumerated in a preceding part of the (multistatus) response, and are not being included again
-   **226 IM Used:** The server has fulfilled a GET request for the resource, and the response is a representation of the result

### Redirection 3xx

-   **300 Multiple Choices:** The request has more than one possible response. The user agent or user should choose one of them
-   **301 Moved Permanently:** The URL of the requested resource has been changed permanently
-   **302 Found:** The URL of the requested resource has been changed temporarily
-   **303 See Other:** The server sent this response to direct the client to get the requested resource, e.g. after a PUT request, at another URI with a GET request
-   **304 Not Modified:** The resource has not been modified since the last request, so the client can use the cached version
-   **305 Use Proxy:** (Deprecated) The requested resource is only available through
-   **306 Switch Proxy:** (No longer used) Originally meant "Subsequent requests should use the specified proxy"
-   **307 Temporary Redirect:** The URL of the requested resource has been changed temporarily, and the same method should be used to access it
-   **308 Permanent Redirect:** The URL of the requested resource has been changed permanently, and the same method should be used to access it

### Client Error 4xx

-   **400 Bad Request:** The server cannot process the request due to an apparent client error, e.g. invalid syntax
-   **401 Unauthorized:** You need to prove who you are
-   **402 Payment Required:** (Reserved for future use)
-   **403 Forbidden:** I know who you are, but you don't have permission to do this
-   **404 Not Found:** The server cannot find the requested resource
-   **405 Method Not Allowed:** The request method is known by the server but is not supported by the target resource
-   **406 Not Acceptable:** The server cannot generate a response that is acceptable by the client as indicated by the accept headers
-   **407 Proxy Authentication Required:** You need to authenticate with the proxy before you can use this resource
-   **408 Request Timeout:** The server timed out waiting for the request
-   **409 Conflict:** The request conflicts with the current state of the resource such as an edit conflict between multiple simultaneous updates
-   **410 Gone:** The resource is no longer available and clients should remove it from their cache
-   **411 Length Required:** The request did not specify the length of its content, which is required by the requested resource
-   **412 Precondition Failed:** The client has indicated preconditions in its headers which the server does not meet
-   **413 Payload Too Large:** The request is larger than the server is willing or able to process. The server might close the connection or return an Retry-After header field
-   **414 URI Too Long:** The URI requested by the client is longer than the server is willing to interpret
-   **415 Unsupported Media Type:** The request has a media type which the server or resource does not support
-   **416 Range Not Satisfiable:** The client has asked for a portion of the file, but the server cannot supply that portion
-   **417 Expectation Failed:** The server cannot meet the requirements of the Expect request-header field
-   **418 I'm a teapot:** (an old April Fools' joke) Returned by teapots requested to brew coffee
-   **421 Misdirected Request:** The request was directed at a server that is not able
-   **422 Unprocessable Entity:** The request was well-formed but was unable to be followed due to logic errors in the data
-   **423 Locked:** The resource that is being accessed is locked
-   **424 Failed Dependency:** The request failed due to failure of a previous request
-   **425 Too Early:** Indicates that the server is unwilling to respond because, for example, it might be a duplicate of another request that hasn't finished processing
-   **426 Upgrade Required:** The client should switch to a different protocol. Includes an upgrade header in the response
-   **428 Precondition Required:** The origin server requires the request to be conditional to avoid conflicts
-   **429 Too Many Requests:** The user has sent too many requests in a given amount of time
-   **431 Request Header Fields Too Large:** The server is unwilling to process the request because its header fields are too large
-   **451 Unavailable For Legal Reasons:** The server is denying access to the resource as a consequence of a legal demand

### Server Error 5xx

-   **500 Internal Server Error:** The server has encountered a situation it doesn't know how to handle
-   **501 Not Implemented:** The request method is not supported by the server and cannot be handled
-   **502 Bad Gateway:** The server was acting as a gateway or proxy and received an invalid response from an upstream server
-   **503 Service Unavailable:** The server cannot handle the request (because it is overloaded or down for maintenance). Generally, this is temporary
-   **504 Gateway Timeout:** The server was acting as a gateway or proxy and did not receive a timely response from an upstream server
-   **505 HTTP Version Not Supported:** The server does not support the HTTP protocol version used in the request
-   **506 Variant Also Negotiates:** Transparent content negotiation for the request results in a circular reference
-   **507 Insufficient Storage:** The server is unable to store the representation needed to complete the request
-   **508 Loop Detected:** The server detected an infinite loop while processing the request
-   **510 Not Extended:** The server needs more information to fulfill the request
-   **511 Network Authentication Required:** Used by intercepting proxies (like public Wi-Fi) to control access to the network

### Other

1. **URI (Uniform Resource Identifier):** String of characters that identifies a resource either by location, name, or both