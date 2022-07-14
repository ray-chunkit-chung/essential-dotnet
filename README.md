# Dotnet getting started

Modify from
https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0



```
dotnet run

dotnet publish --configuration Release

dotnet new sln

dotnet new classlib -o DemoLibrary
dotnet sln add DemoLibrary/DemoLibrary.csproj

dotnet new console -o DemoConsoleApp
dotnet sln add DemoConsoleApp/DemoConsoleApp.csproj


dotnet add DemoConsoleApp/DemoConsoleApp.csproj reference DemoLibrary/DemoLibrary.csproj

```

