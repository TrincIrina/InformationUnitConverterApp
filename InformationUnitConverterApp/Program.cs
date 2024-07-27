using InformationUnitConverterApp;
using InformationUnitConverterApp.Converter;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    MessageJson messageJson = new MessageJson()
    {
        Message = "server in running",
        dateNow = DateTime.Now,
    };
    return messageJson;
});

app.MapGet("/ping", () => new MessageJson()
{
    Message = "pong",
    dateNow = DateTime.Now,
});

app.MapPost("/solve", (IncomingMessage message) =>
{
    double convertedInf = InformationUnitConverter.Convert(message.Initial, message.Convert, message.Amount);
    MessageJson messageJson = new MessageJson()
    {
        Message = $"{message.Amount} {message.Initial} = {convertedInf} {message.Convert}",
        dateNow = DateTime.Now,
    };
    return messageJson;
});

app.Run();

