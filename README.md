# Introduction 
This is the source code for the new Agility website. It demonstrates how you can use .NET Core, [Agility](https://agilitycms.com), and React to create an isomorphic web app that is high performant, SEO friendly, supports modern frontend tooling, easy to manage content, and showcases content architecture best-practices.

## Getting Started
1.  Run Locally
    - clone the repo
    - copy the **Website/appsettings.json.sample** and rename it to **appsettings.json**
    - enter the *WebsiteName*, *SecurityKey*, *UGC Key** and *UGC Password* in the **appsettings.json** file

2.  Software dependencies
    - ensure at least .NET core 2.2 runtime is installed


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
1.  Build Frontend
    ```
    Website\wwwroot> npm run build
    ```

2.  Build .NET Core site
    ```
    Website> dotnet build
    ```


## Contribution - Rules of Engagement
The following instructions are only applicable to Agility developers contributing to this source code.
1. Under no circumstances can any PID, passwords, or access tokens be checked into source control
2. Create your own feature branch for any changes, feel free to publish the branch or keep local
3. When ready to deploy updates to UAT, merge into *uat* branch
4. When ready to deploy to production, mergin into *master* branch
5. Delete the unusused feature branch you initially created

---
**Note**: This repository has a one-way sync between a private VSTS git repository and a public [Agility-AspNetCore-ReactSampleSite GitHub repo](https://github.com/agility/Agility-AspNetCore-ReactSampleSite)