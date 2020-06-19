# API Layer
The client facing layer.  The API layer relies on the Application layer to handle logic
in an implementation agnostic way, while the API layer is implementation specific.  This
API implementation is based on ASP.Net Core.  Moving to another framework should
allow the other layers to remain unchanged.

The API layer handles HTTP Requests and Responses, feeding them to the Application
layer for processing.