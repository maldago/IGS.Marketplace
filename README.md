## Description

A simple market place web api net core app built on net core 3.1 using Docker containers. 

Containers used: 
- mcr.microsoft.com/dotnet/sdk:3.1
- mcr.microsoft.com/mssql/server

## Build

The project can be built by downloading the package from Github or by cloning the solution using:

```git clone https://github.com/maldago/IGS.Marketplace```

Building the solution will require docker and [Entity Framework Core tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)

From the root of the solution the image can be created issuing the following command:

```docker-compose build``` 

## Running


Once the build has been generated the image, run the container 

```docker-compose up -d```

The web app endpoint is hosted [http://localhost:5000](http://localhost:5000)

Swagger end point: [http://localhost:5000/swagger/index.html](http://localhost:5000/swagger/index.html)

When the app is up, the Sql server instance can be accessed using your SQL Server Management tool of choice. I used [Azure Data Studio](https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15).

Server: 127.0.0.1
Database: marketplace
Username: sa
Password: <Check solution>

![img](https://github.com/maldago/IGS.Marketplace/blob/master/Results/Marketplace-DB.PNG) 


## Results 

Postman Results
![img](https://github.com/maldago/IGS.Marketplace/blob/master/Results/PostmanResults.PNG)

Swagger up and running
![img](https://github.com/maldago/IGS.Marketplace/blob/master/Results/Swagger.PNG)
