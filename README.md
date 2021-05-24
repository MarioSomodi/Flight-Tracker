# Flight Tracker
Windows app that let's you track current flights and their locations (Windows Forms .NET Framework 4.7.2).
Firstly you gotta choose what countries flights you want to gather then when you have selected the countries the flights will
be gathered and the app will show them on the map.
## Things I learned
* Working with Windows forms.
  * Docking and anchoring controls (Making a responsive app).
  * Designing decently looking apps.
  * Displaying a form inside of the main form.
  * Made my own control buttons (close, minimize, maxmize).
  * Share information between forms.
* REST API.
  * Connecting to the api and researching it.
  * Geting data from the API in this case in a form of JSON.
  * Parsing that data so it can be used in the project.
  * Storing needed data from the API in a SQL DB.
* SQL database CRUD.
  * All data logic is in the Class Library not in the main Windows forms app.
  * CRUD operations on the specific tables in the DB.
  * Repositories for each table so the code is organizied.
```
REST API used in this project: https://opensky-network.org/api/states/all
REST API's docs : https://opensky-network.org/apidoc/rest.html
```
