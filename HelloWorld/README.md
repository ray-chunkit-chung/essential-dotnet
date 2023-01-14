# Hello world

<https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0>

## Program

```bash
cd HelloWorld
dotnet new sln

dotnet new "console" -lang "C#" -n "ShowCase" -o "ShowCase"
dotnet sln add ShowCase/ShowCase.csproj

dotnet new "classlib" -lang "C#" -n "StringLibrary" -o "StringLibrary"
dotnet sln add StringLibrary/StringLibrary.csproj
dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj

dotnet new "mstest" -lang "C#" -n "StringLibraryTest" -o "StringLibraryTest"
dotnet sln add StringLibraryTest/StringLibraryTest.csproj
dotnet add StringLibraryTest/StringLibraryTest.csproj reference StringLibrary/StringLibrary.csproj
```

## Compile & test

Compile and test the Release version. The Release version incorporates compiler optimizations that can affect the behavior of an application

```bash
dotnet run --configuration Release --project ShowCase
```

## Publish

Publish a console app so that other users can run it

```bash
dotnet publish --configuration Release

dotnet test StringLibraryTest/StringLibraryTest.csproj
```
