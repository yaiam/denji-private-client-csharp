# Auth Private Client csharp

## Build
```
./build.sh
```

## Publish nuget locally
```
dotnet pack -c Release -o ./dist
dotnet nuget push ./dist/*.nupkg -s ${HOME}/nuget
```