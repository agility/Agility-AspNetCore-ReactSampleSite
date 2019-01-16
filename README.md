# Introduction 
Agility CMS Website - 2019 - built using .Net Core with Agility.Web and Webpack

# Getting Started
1.  Installation process
    - clone the repo
    - rename the **Website/appsettings.json.sample** file to **appsettings.json**
    - enter the *WebsiteName*, *SecurityKey*, *UGC Key** and *UGC Password* in the **appsettings.json** file

2.  Software dependencies
    - ensure at least .NET core 2.2 runtime is installed

3.  Start .NET Core site
    ```
    Website> dotnet run
    ```

4.  Start Webpack Dev Server to use things like hot module replacement
    ```
    Website\wwwroot> npm run dev
    ```


# Build

1.  Build Frontend
    ```
    Website\wwwroot> npm run build
    ```

2.  Build .NET Core site
    ```
    Website> dotnet build
    ```




