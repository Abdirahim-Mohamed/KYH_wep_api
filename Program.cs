var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/add", (int num1, int num2) => Addnumbers(num1, num2));

app.MapGet("/subtract", (int num1, int num2) => Subtractnumbers(num1, num2));
app.Run();


string Addnumbers (int num1 , int num2)
{
    return $"Summan av {num1} och {num2} är: {num1 + num2}";
}

string Subtractnumbers(int num1, int num2)
{
    return $"Differensen av {num1} och {num2} är: {num1 - num2}";
}
