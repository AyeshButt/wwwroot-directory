# wwwroot-directory
An ASP.NET Core project demonstrating how to configure and change the WebRootPath in the application configuration. Details about the wwwroot directory and static files are provided in the README.

#**ASP.NET Core wwwroot Directory Overview**

###**Root Directory**:
The wwwroot folder contains static files such as JS, CSS, images, and other assets that are available for access via HTTP requests.

###**Serving Static Files**:
These files are served to clients when the application is run. To enable this, the UseStaticFiles middleware must be configured.

###**Security**:
Only files inside the wwwroot directory are accessible by clients, ensuring that other files remain secure and inaccessible from the web.

###**Empty Template**:
The wwwroot folder exists by default in MVC and Razor Pages templates. In an empty template, you must manually create the wwwroot folder for static file handling to work.

###**Configuring the WebApplication**

##**WebApplicationOptions**: This class provides configuration options for WebApplicationBuilder. It contains:

###**ContentRootPath**:
The absolute path to your application.

###**WebRootPath**:
The path to your wwwroot directory.

###**EnvironmentName**:
The environment in which the application is running (e.g., Development, Production).

###**ApplicationName**:
The name of the application.

###**Args**:
Command-line arguments passed to the application.

##**Program.cs Overview**

###**WebApplicationBuilder**:
The WebApplicationBuilder is used to configure services, middleware, and settings.

###**Building the WebApplication**:
After configuring, you build the application using Build(). This creates a WebApplication instance that handles incoming requests.

###**Customization**:
You can change the default wwwroot directory name by passing a WebApplicationOptions instance to the CreateBuilder method. This allows you to specify a custom static file directory.
To achieve this, create a WebApplicationOptions object, set the WebRootPath property, and then pass it to CreateBuilder().
