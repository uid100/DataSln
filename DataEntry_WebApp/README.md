### todo

1. Move the data access layer out of the web app architecture and make the request to an API instead.


### build script
    dotnet new globaljson --sdk-version 5.0.201 --output DataSln/DataEntry_WebApp
    dotnet new web --output DataSln/DataEntry_WebApp --framework net5.0
    dotnet new sln -o DataSln
    dotnet sln DataSln add DataSln/DataEntry_WebApp
