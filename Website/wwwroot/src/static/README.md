## Get Started
Start Frontend (only, no backend)
```
Website\wwwroot>npm install
Website\wwwroot> npm run static
```
View [Help Page](http://localhost:8080/help) once running for more information.

## Contribution - Rules of Engagement
The following instructions are only applicable to Agility developers contributing to this source code in the private Azure Devops repo.
1. Under no circumstances can any PID, passwords, or access tokens be checked into source control
2. Create your own feature branch for any changes, and publish the branch
3. Commit your changes to your branch only 
4. When you are done and ready to merge, create a *Pull Request* to merge into the **uat** branch
5. A successful commit to the **uat** branch will kick off an automated deployment to the *uat environment*

---
**Note**: This repository has a one-way sync between a private Azure DevOps git repository and a public [Agility-AspNetCore-ReactSampleSite GitHub repo](https://github.com/agility/Agility-AspNetCore-ReactSampleSite)
