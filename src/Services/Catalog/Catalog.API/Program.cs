var builder = WebApplication.CreateBuilder(args);

//Addd Services to the Container
builder.Services.AddCarter();
builder.Services.AddMediatR(config => {
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
var app = builder.Build();

//Configure the HTTP Request pipeline
app.MapCarter();

app.Run();

//Anylysis(Domain + Technical-Patterns and Principals)
//Dev + Test
//Deploy (Containers + Orchestrate)

//Domain Anylysis 
//1. Domain Models
//2. Applications Use Cases
//3. Rest API Endpoints  
//4. Underlpying Data Structures( Q-NoSQL, W(PostGre) ) + marten(DocumentDB)

//table catalog - json doc

//Technical Anylysis 
//1. Application Architecture Style
//2. Patterns + Principles
//3. Nuget Packages
//4. Project Folder Structure

//Marten - DocumentDB
//Carter - API Endpoints
//Mapstar - Object Mapping
//MediatR - CQRS pattern
//FluentValidation - Input Validation


//CQRS pattern
//Mediator pattern
//DI
//Minimal APIs with Routing