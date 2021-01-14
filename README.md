# My-Contact-App

This is a sample project for demonstrating the Full Stack App with ASP .NET Core and Angular connecting to SQL server

## Technology Used

### Backend

* ASP .Net core 3.0 Wep API
* Dapper
* Open API configuration with swagger

### Frontend

* Angular
* Angular Material

### Database

* MS SQL

## Features

* Onion Architechture with repository pattern
* API Authentication with hard-corded API Key using custom middleware and attribute
* Dapper basic and advance 
* Stored Procedure 
* Authentication Definition in swagger

## How to Use

* Clone this Repo
* In SQL Server create a new database 
* Use this database and execute all the script in the create table script and user defined table types
* Execute all Stored procedures
* In API open the project in Visual Studio or vs code change the connection string in app.settings the database and server
* Run the project visual studio `F5` or vs code `dot net run`
* In App Folder open the folder in vs code
* In terminal run `npm install`
* once the all package is installed `ng serve --open --port 4200`
