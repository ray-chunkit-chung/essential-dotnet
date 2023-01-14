# Hello world

Modify from
<https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0>

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

dotnet test StringLibraryTest/StringLibraryTest.csproj

dotnet run
dotnet publish --configuration Release
```
