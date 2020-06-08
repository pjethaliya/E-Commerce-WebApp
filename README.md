# E-Commerce-WebApp
Small online Boutique Shop developed using ASP.NET Core 3.1 MVC

The Gilded Rose Online Store Web App Documentation
Intro: Small e-commerce handicraft online store
Restriction:
• User must be authenticated to buy items in the store
• User can buy only one item at a time
Implementation:
Technology:
• ASP.Net Core MVC WebApp (built on mac)
• Docker for SQL server
• Entity Framework
• MSSQL Server
Architecture :
I am using Model-View-Controller architecture for this web application. When user hits any
page, first it goes to the controller method which calls the repositories (Interface). Repositories
are linked with Models (Database Objects) which are connected with Database using Entity
Framework which gets all the data we need and pass it to the Controller which is being passed
to the appropriate views.
Authentication: I have used identity authentication for this application which provides an api
for login functionality and manages users, roles, etc. I have taken this approach as it is very
simple to implement and gets the scaffolded code. For application like this for proof of concept
I think this should be the easiest and quickest way of authenticating a user.
If the user is logged in, then we know that the user is authenticated
Database:
I am using two tables for this project
1. Item Table
2. Order Table which has ItemId as a FK
Buying an item restriction:
• Only authenticated user can buy the item
• Only one item can be bought at a time. This can be extended to several items by
implementing a shopping cart
• If the item is out of stock then user cannot buy the item
• After every item is bought we update the items quantity in the database
• If user is logged in and if item is in stock then only one can buy item by filling up a form
and details are saved in the database.

Technical Details:
• To run this app locally , one might have to do several changes in config
1. Connection String: In appsetting.json add:
"ConnectionStrings": {
"DefaultConnection": "server=localhost; database=GildedRoseBoutiqueDb; user id
= sa; password = MyComplexPassword!234"
},
2. I have used docker to setup my db and here the commands for docker
o Install Docker from website
o sudo docker pull microsoft/mssql-server-linux
o sudo docker run -e 'ACCEPT_EULA=Y' -e

'SA_PASSWORD=MyComplexPassword!234' -p 1433:1433 -d microsoft/mssql-
server-linux

3. Run dotnet command on cli
o dotnet ef datbase update
4. Might need to install all the dependency from .csproj file
Testing:
I have added some unit test to check all the items and the specific item detail for the
controllers. I have used XUnit testing using Moq Library.
