## Description

A simple market place webapi net core app built on net core 3.1 using Docker containers

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

## Results 

Postman Results
![img](https://github.com/maldago/IGS.Marketplace/blob/master/Results/PostmanResults.PNG)

Swagger up and running
![img](https://github.com/maldago/IGS.Marketplace/blob/master/Results/Swagger.PNG)
