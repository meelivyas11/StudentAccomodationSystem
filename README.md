# What is it?
StudentAccomodationSystem is developed in  C#.Net using MVC architecture. Entity Framework (code first approach) is used for connecting with database.

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
 
# How do I use it?
 
