# Application Layer
Business logic layer that will contain our services.  This layer is detached from the API
layer to allow the logic to remain implementation agnostic (.Net Core Vs .Net Framework).  
The Application layer relies on the Domain layer to define what data looks like and the
Persistence layer to store and fetch data.