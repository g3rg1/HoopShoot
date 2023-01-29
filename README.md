## Description

Web App that shows a basketball league results.

## HoopShoot Backend:

Technologies used to create the backend are: .NET 6, EntityFramework, MSSQL Server and Automapper.

UML of the DB relations:
![ALT](./images/hoopshoot-uml-tables.png)

Database is created and seeded on project start from EF migrations automatically.

SWAGGER REST API visualisation.

# HoopShoot UI

Technologies used to create the frontend are: Angular 14, Bootstrap 5 and AG grid.

searching and sorting of results can be done trough AG grid:
![ALT](./images/search-and-sort.gif)

## How to start on Development server

Set the DB connection string in the appsettings.json file.\
In Visual studio, set HoopShoot.API as default startup project and run it.\
On the UI dir, run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

## Install Dependancies

Run `npm i` to install the necessary dependancies for the project.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).
