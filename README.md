![icon](https://raw.githubusercontent.com/uid100/DataSln/master/Images/codesettings.png)
# DataSln
Data Management WebApp Project(s)


## Architecture

An _n_-tiered ASP.NET web app can be hosted for standard development / proof of concept usage loads on the Microsoft Azure 
free tier web app service. Using MVC framework, combined with entity framwork is a common strategy for integrating with a SQL 
database server. 
_fig._

Multiple applications may share a common database and even a common set of tables. mitigating cost.
_fig._

The sqlite
file-based database can be deployed along with the web app to aleviate the cost of a PaaS Azure Sql instance. In order to share a single, common (sqlite)
database across multiple applications, deploy the file-based database with an API and access the database through the API.

[] Create an API to host and control database access
[] Create a separate, data-entry web service as a consumer of the API-hosted data source
[] Create a separate, data-visualization service as a second consumer of the API-hosted data source
[] Each app should have it's own set of unit tests

## SqliteDataAPIService

## 
