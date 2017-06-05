# Azure Management Proof of Concept
Demonstrates how to integrate the Fluent Azure API into an ASP.NET Web Application.

# Key Features
- Begin by installing your application into Azure Active Directory. This demo uses v2 endpoints. See https://apps.dev.microsoft.com
You can reproduce the starting point for this example by going to [Register app](https://apps.dev.microsoft.com/portal/register-app) and check Guided Setup

# Solution Architecture Design Notes
- AzureManagmentPOC is the web application that provides a user interface. It should not "know about" the Azure Fluent UI. Its functionality 
comes through tha AzureManagementLib. The idea is to add a WebAPI so that an external app can use the functionality exposed in AzureManagementLib.
- AzureManagementLib is designed to separate the Azure Fluent API from the UI
- AzureManagementCommon is designed to be used in either AzureManagementPoc (the website) or AzureManagementLib (which accesses the Azure Fluent library)

# References
See
- [Add sign-in with Microsoft to an ASP.NET web app](https://docs.microsoft.com/en-us/azure/active-directory/develop/guidedsetups/active-directory-aspnetwebapp)
- [Azure Tools for Visual Studio](https://github.com/Azure/azure-sdk-for-net)

# The Ugly
When building this from scratch in Visual Studio 2017, there is a mismatch between .NET Standard target and .NET Framework target
This is referenced on [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/library)
The fix used in this example is to set the .NET Standard targets in the library to version 1.2 

