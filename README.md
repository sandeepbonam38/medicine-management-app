**Client ABC pharmacy** wants to build a Single Page Application using  Web API and
JavsScript/ASP.NET MVC framework to keep track of medicines (see attributes
mentioned below). This application should provide features like view list and add
medicine details. There should be a mechanism to maintain the sale records of
medicine via this application.

**Medicine Attributes:**
 Full Name of the medicine - text
 Notes - text
 Expiry Date – Date
 Quantity - number
 Price –number with 2places decimal
 Brand - text

**Functional Requirements:**
Display the list of medicines available in System
 The results showing the medicine attributes (except Notes) should be displayed
in a grid.
 There should be color indications which follow the guidelines mentioned below:
 Red background for medicines with expiry date less than 30 days
 Yellow background for medicines with quantity in stock less than 10
 Page should have search capability which can query on name of medicine
attribute.

**Technical Requirements:**
 Use .net core for api
 Use JavaScript framework of your choice
 Data to be stored in Json on server side.

**Steps to launch:**
Step 1: create a new project using dotnet command.It will generate a blank console
app.
dotnet new console --MyConsoleApp
Step 2: Build and run the project using below command
dotnet run --project MyConsoleApp
Step 3: To run the WebApi or web application click on Open Preview and enter the
application URL.
