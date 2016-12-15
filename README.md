# What is it?
StudentAccomodationSystem is a prototype of an application which provides a platform to hybrid students to find shared accomodation near their universities while they are visiting the university for a day or two. This prototype is built in C#.Net using MVC architecture. Entity Framework (code first approach) is used for connecting with database.

As this application is just a prototype, static content is used to get functionalities working.

# How do I set up?
## Software Requirement
 - Git Bash: https://git-scm.com/
 - Visual Studio
 
## Environment Setup
 - Clone the repository using  `git clone https://github.com/meelivyas11/StudentAccomodationSystem.git` command in Git Bash
 - Open`StudentAccomodationSystem.sln` solution file from respitory in Visual Studio.

## Database Configuration
 - Update the value of "Data Source" related to the connectionString from `Web.config` and `App.config` files present in "StudentAccomodationSystem" and "SAS_Library" projects of the repository. 
```xml
<connectionStrings>
	<add name="SASContext"  providerName="System.Data.SqlClient" connectionString="Data Source=.\sqlexpress; Initial Catalog=SAS.DB; Integrated Security=True; MultipleActiveResultSets=True"/>
</connectionStrings>
```
 - Rebuild and start the application
 
# How do I use it?
 - Open <http://localhost:53332/> on your web browser to see the appliction.
 - Use 'admin' as username and password to login as a administrator.
 - To login as a user, you can use any random username and password (as this application is just a prototype).
