
# Create a NuGet package

## Step 1 Create a class

```bash
mkdir AppLogger
cd AppLogger
dotnet new classlib
```

## Step 2 Create nuget.org api key

1. Sign into your nuget.org account or create an account if you don't have one already.
2. Select your user name at upper right, and then select API Keys.
3. Select Create, and provide a name for your key.
4. Under Select Scopes, select Push.
5. Under Select Packages > Glob Pattern, enter *.
6. Select Create.
7. Select Copy to copy the new key.

## Step 3

```bash
dotnet pack
dotnet nuget push bin/Debug/Contoso-baby.08.28.22.001.Test.1.0.0.nupkg --api-key xxxxx --source https://api.nuget.org/v3/index.json
```
