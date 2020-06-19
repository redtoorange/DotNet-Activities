[Live App](http://dotnetcoreapp.us-east-1.elasticbeanstalk.com/)

### Activity App
Practice application to learn .Net Core and ASP.Net Core.  To say that this is
over-engineered is an understatement.

## Structure
The Application is split into four projects across lines of responsibility and 
to abstract implementation details.

### API
The client facing layer.  The API layer relies on the Application layer to handle logic
in an implementation agnostic way, while the API layer is implementation specific.  This
API implementation is based on ASP.Net Core.  Moving to another framework should
allow the other layers to remain unchanged.

The API layer handles HTTP Requests and Responses, feeding them to the Application
layer for processing.

### Application
Business logic layer that will contain our services.  This layer is detached from the API
layer to allow the logic to remain implementation agnostic (.Net Core Vs .Net Framework).  
The Application layer relies on the Domain layer to define what data looks like and the
Persistence layer to store and fetch data.

### Domain
Data abstraction layer that is used to define what our data looks like from an entity
standpoint.  The Persistence layer will use the Domain layer to define what the tables
will look like and the Application layer will use the Domain layer to run business 
logic.

### Persistence
Swappable persistence layer that will handle all direct interactions with a data base.  This layer will 
generally utilize Entity Framework to manage data contexts.  This layer has a dependency
on the Domain layer to define what data looks like.

## Building and Running
The application is based on .Net Core 3, which _Should_ allow it to run under
any operating system.

### Docker (Recommended)
The easiest method of running is with Docker.  From the root directory build the 
docker image:

    docker build -t activity-app .
    
Run the container:

    docker run -it --rm -p 5000:80 --name myapp activity-app

### System Dependencies
You'll need to most recent version of [.Net Core Runtime](https://dotnet.microsoft.com/download)

Call restore from the root directory /Activity-app to fetch dependencies.

    dotnet restore
    
### Running Standalone
There are many ways to run the application:

- Run from terminal
    
    
    dotnet run --project API

- Publish Artifact dir


    dotnet publish -c Release -o out
    cd out
    dotnet API.dll

