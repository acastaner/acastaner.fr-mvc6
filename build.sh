#!/usr/bin/env bash

#exit if any command fails
set -e

artifactsFolder="./artifacts"

if [ -d $artifactsFolder ]; then  
  rm -R $artifactsFolder
fi

dotnet restore
dotnet build -c Release -o ./artifacts
cp -f src/acastaner_mvc6/appsettings.json ./src/acastaner_mvc6/artifacts
cd src/acastaner_mvc6/artifacts/
tar -zcvf acastaner_mvc6-$TRAVIS_JOB_NUMBER.tar.gz ./ 
