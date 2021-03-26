# DataSln
Data Management WebApp Project(s)



## Architecture

An _n_-tiered ASP web app can be hosted for standard development / proof of concept usage loads on the Microsoft Azure free tier web app service. The sqlite
file-based database can be deployed along with the web app to aleviate the cost of a PaaS Azure Sql instance. In order to share a single, common (sqlite)
database across multiple applications, deploy the file-based database with an API and access the database through the API.

[_] Create an API to host and control database access
[_] Create a separate, data-entry web service as a consumer of the API-hosted data source
[_] Create a separate, data-visualization service as a second consumer of the API-hosted data source
[_] Each app should have it's own set of unit tests

## SqliteDataAPIService

## 
