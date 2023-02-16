# Azure AD B2C App in .NET for User Sign In with Progressive Profile
This repository contains sample code for implementing an Azure AD B2C App in .NET responsible for user sign in with a progressive profile. The app displays all existing attributes in edit mode, and prompts the user to provide an additional mandatory default attribute, game. Once the user provides a value for the game attribute, they will not be prompted to edit their profile on subsequent sign-ins. When users sign out, they will also be signed out of the linked application 1.

# Demo
<b> Access the app at <a href="https://uniccapp2.azurewebsites.net">App 2</a> </b>
1. You will be directed to the sign in page OR if you are signed into the linked App 1, you will be signed in directly (Single Sign On)
2. Navigate to the sign in page.
3. If the user has not provided a value for the game attribute, they will be prompted to edit their profile and provide a value for it.
4. If the user has provided a value for the game attribute, they will be signed in directly to application 2.
5. When the user signs out, they will also be signed out of the linked application 1 (Single Log Out).


## Getting Started
### Prerequisites
To use this app, you will need the following:

- An Azure account
- An Azure AD B2C tenant
- Visual Studio or another .NET development environment
- Another application linked to your Azure AD B2C tenant

### Installation 
1. Clone the repository to your local machine.
2. Open the project in Visual Studio or another .NET development environment.
3. Build the project.

### Serve app with different Azure account
1. In the appsettings.json file, replace the placeholders with your Azure AD B2C tenant information.

### Usage
To use the app, follow these steps:

1. Run the project.
2. Navigate to the sign in page.
3. If the user has not provided a value for the game attribute, they will be prompted to edit their profile and provide a value for it.
4. If the user has provided a value for the game attribute, they will be signed in and redirected to the application 2.
When the user signs out, they will also be signed out of the linked application 1.

### Resources
<a href="https://docs.microsoft.com/en-us/azure/active-directory-b2c/">Azure AD B2C Documentation </a> <br/>
<a href="https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-6.0&tabs=visual-studio">ASP.NET Core Identity Documentation </a>
