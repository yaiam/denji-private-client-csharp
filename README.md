# Auth Private Client csharp

## Generate client
```
./build.sh
```

## Publish nuget locally
```
dotnet pack -c Release -o ./dist
dotnet nuget push ./dist/*.nupkg -s ${HOME}/nuget
```