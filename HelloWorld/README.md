# Hello world

Modify from
<https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0>

## Example 1

```
dotnet new console --framework net6.0

dotnet run

dotnet publish --configuration Release

```

## Example 2

```
dotnet new sln

dotnet new classlib -o StringLibrary
dotnet sln add StringLibrary/StringLibrary.csproj

dotnet new console -o ShowCase
dotnet sln add ShowCase/ShowCase.csproj
dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj

dotnet new mstest -o StringLibraryTest
dotnet sln add StringLibraryTest/StringLibraryTest.csproj
dotnet add StringLibraryTest/StringLibraryTest.csproj reference StringLibrary/StringLibrary.csproj

dotnet test StringLibraryTest/StringLibraryTest.csproj
```
