# Auth Private Client csharp

## Generate client
```
dotnet tool restore
npm i
./build.sh
```

## Publish nuget locally
```
dotnet pack -c Release -o ./dist
dotnet nuget push ./dist/*.nupkg -s ${HOME}/nuget
```