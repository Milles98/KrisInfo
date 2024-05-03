# KrisInfo Solution
## This solution consists of two projects: KrisInfo and Library.
## KrisInfo
KrisInfo is a web application built with ASP.NET Core 8.0. It uses Razor Pages and is structured around the Model-View-Controller (MVC) design pattern. The project references the Library project for shared functionality.
### Key Files
•	Program.cs: The entry point for the application.
•	Pages/Index.cshtml.cs: The page model for the Index page. It uses IKrisInfoService to fetch and display a list of KrisInfo responses.
•	Pages/Details.cshtml.cs: The page model for the Details page. It uses IKrisInfoService to fetch and display a single KrisInfo response.
## Library
The Library project is a .NET Standard 8.0 class library. It contains shared services and models used by the KrisInfo project. It also includes a reference to the Newtonsoft.Json package for JSON processing.
### Key Files
•	Area.cs: A model class with a Description property.
•	Services/IKrisInfoService.cs: An interface defining the contract for a service that provides KrisInfo data.
## Setup
To run this solution, you need .NET 8.0 SDK installed on your machine. Open the solution in Visual Studio, restore the NuGet packages, and build the solution. You can then run the KrisInfo project.
## Dependencies
•	Newtonsoft.Json: A popular high-performance JSON framework for .NET
