using System.CommandLine;

Argument<string> nameArgument = new(
    name: "name",
    description: "Your name",
    getDefaultValue: () => "World"
);

RootCommand rootCommand = new();
rootCommand.AddArgument(nameArgument);

rootCommand.SetHandler((nameArgumentValue) =>
{
    Console.WriteLine($"Hello, {nameArgumentValue}!");
}, nameArgument);

await rootCommand.InvokeAsync(args);