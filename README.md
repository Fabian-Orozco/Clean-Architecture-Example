# Clean Architecture - API Description

## Entities (domain)

- **Common:** This folder stores the BaseEntity class and other aggregates. BaseEntity is an abstract class with properties like Id, DateCreated, DateUpdated, and DateDeleted.
- **Entities:** Here all domain entities are stored. For example, the User class inherits from BaseEntity and defines properties like Name and PlayersPerTeam.

## Application

- **Repositories:** Contains repository interfaces that define methods for accessing data, such as reading, creating, updating, and deleting. It also includes the unit of work interface that saves changes.
- **Features:** It has functional features (like create), each feature has its own subfolder and contains handler, request, response, DTOs, mappers, validators. Libraries like MediatR for communication management, AutoMapper for object conversion, and FluentValidation for validation are used.
- **Common:** Stores common content like helpers, exceptions, and shared behaviors.
- **ServiceExtensions:** Contains an extension method to configure dependency injection in the application layer.

## Infrastructure

- Contains a class library called Persistence that contains the implementation of repository interfaces. It references the application layer.
- **Context:** Hosts the Entity Framework (or another ORM) context class.
- **Repositories:** Contains the implementation of repository and unit of work interfaces.
- **ServiceExtensions:** For configuring dependency injection in the infrastructure layer.

## Presentation (WebAPI project)

- **Controllers:** Handles incoming HTTP requests and returns the appropriate HTTP response. It acts as an intermediary between the client and the server logic.
- **Extensions:** The "Extensions" folder contains classes and configuration of extension methods for the Web API project, such as the global error handler, CORS policy, behaviors, etc.

For more information, refer to the research document: [Clean_Architecture_Research.pdf](Clean_Architecture_Research.pdf)

Clean Architecture implementation example in ASP .NET Core Web API

Example source: <https://juldhais.net/clean-architecture-in-asp-net-core-web-api-4e5ef0b96f99>
