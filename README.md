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


Implementation:

**Backend:**
1)Data Preparation/ DB preparation
2)Web API(Clean Architecture)
 2.1)Folder Structure
 2.2)Data Access
 2.3)Exception Handling(exception Middleware)
 2.4)Async
 2.5)Dependency Injection
 2.6)CORS Enable
 2.7)Filtering, Paging, Searching
 2.8)Caching
 2.9)DTO's
 3.0)Repositry Patteren
 3.1)Proper Status Codes

3)React UI
3.1)Folder Structure
medicine-management-ui/
│
├── src/
│   ├── components/        → Reusable UI components
│   │   ├── MedicineList.js
│   │   ├── AddMedicine.js
│   │   └── SearchBar.js
│   │
│   ├── pages/             → Page-level components
│   │   └── Home.js
│   │
│   ├── services/          → API calls
│   │   └── api.js
│   │
│   ├── routes/            → Routing config
│   │   └── AppRoutes.js
│   │
│   ├── utils/             → Helper functions
│   │   └── helpers.js
│   │
│   ├── App.js             → Root component
│   └── index.js           → Entry point
│
├── public/
├── package.json

3.2)Routing Setup
3.3)Axios API Setup (Centralized)
3.4)Async / Await Usage
3.5)Page Layer (Home Page)
3.6)State Management(Context/Redux) If Required


 
**Steps to launch:**
Step 1: create a new project using dotnet command.It will generate a blank console
app.
dotnet new console --MyConsoleApp
Step 2: Build and run the project using below command
dotnet run --project MyConsoleApp
Step 3: To run the WebApi or web application click on Open Preview and enter the
application URL.
