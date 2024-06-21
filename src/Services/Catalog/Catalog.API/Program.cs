var builder = WebApplication.CreateBuilder(args);

//Add Services to Container

var app = builder.Build();

//Configure the HTTP request Pipeline

app.Run();
