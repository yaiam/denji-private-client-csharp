#!/bin/bash
set -e

# cleanup
rm -rf ./.tmp
rm -rf ./.openapi-generator
rm -rf ./src
rm -rf ./Org.OpenAPITools.sln

# clone auth
mkdir ./.tmp
cd .tmp
git clone git@github.com:aurokk/auth.git
cd ..

# install tools
dotnet tool restore

# publish
dotnet publish ./.tmp/auth/src/Api/Api.csproj -o ./.tmp/auth/publish/ -c Release

# generate swagger.json
dotnet swagger tofile --output swagger.json ./.tmp/auth/publish/Api.dll private

# cleanup
rm -rf ./.tmp

# generate client
npm i
npm run build