# Introduction 
This is the source code for the new Agility website. It demonstrates how you can use .NET Core, [Agility](https://agilitycms.com), and React to create an isomorphic web app that is high performant, SEO friendly, supports modern frontend tooling, easy to manage content, and showcases content architecture best-practices.

## Getting Started
1.  Run Locally
    - Clone the repo
    - Copy the **Website/appsettings.json.sample** and rename it to **appsettings.json**
    - Enter the *websiteName*, *securityKey*, *UGC Key** and *UGC Password* in the **appsettings.json** file
    - Copy the **Website/appsettings.Development.json.sample** and rename it to **appsettings.Development.json**
    - Verify the paths set for  *contentCacheFilePath* and *logFilePath* resolve to valid locations on your drive

2.  Software dependencies
    - Compatible with Windows, Linux and Mac OS
    - Ensure at least .NET core 2.2 runtime is installed


3.  Start .NET Core site
    ```
    Website> dotnet run
    ```

4.  Start Webpack Dev Server to use things like hot module replacement
    ```
    Website\wwwroot> npm install
    Website\wwwroot> npm run dev
    ```


## Build
1.  Build Frontend - also builds the server.js file used for Server-Side-Rendering
    ```
    Website\wwwroot> npm run build
    ```

2.  Build .NET Core site
    ```
    Website> dotnet build
    ```


## Contribution - Rules of Engagement
The following instructions are only applicable to Agility developers contributing to this source code in the private Azure Devops repo.
1. Under no circumstances can any PID, passwords, or access tokens be checked into source control
2. Create your own feature branch for any changes, and publish the branch
3. Commit your changes to your branch only 
4. When you are done and ready to merge, create a *Pull Request* to merge into the **uat** branch
5. A successful commit to the **uat** branch will kick off an automated deployment to the *uat environment*

---
**Note**: This repository has a one-way sync between a private Azure DevOps git repository and a public [Agility-AspNetCore-ReactSampleSite GitHub repo](https://github.com/agility/Agility-AspNetCore-ReactSampleSite)