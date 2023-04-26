# Bridgestone Console Application

This application is responsible to pull OR update all the listed tyres from the BSAF online feed.

<img src="https://img.shields.io/badge/branch-env%2Fproduction-blue"/>

The `production` branch contains the Live environment

<img src="https://img.shields.io/badge/branch-env%2Fdevelopment-blue"/>

The `development` branch is used for th QA environment

<img src="https://img.shields.io/badge/branch-env%2Fstaging-blue"/>

Merge changes from the feature branches to the `staging` branch that will later be merged with the QA and Live environment

![Console-App.jpeg](docs/Console-App.jpeg)

#

## Contribution

Please create a branch from the `production` branch with one of the following naming convention for the branch name

1. `feature/example` When creating a new feature for the application
2. `fix/example` Fixing a bug with the application
3. `hot_fix/example` When a bug fix needs to be taken live immediately 
4. `update/example` Working on a update for application
5. `develop/example` Working on a already developed feature of the application
6. `testing/example` Testing of a feature/development or an issue

## How to scaffold the Database tables

To scaffold the tables from the db. 

```csharp
dotnet ef dbcontext scaffold "Server=(YOUR_LOCAL_SERVER);Database=(DATABASE_NAME);Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False;" Microsoft.EntityFrameworkCore.SqlServer -o Models --use-database-names -c (CONTEXT_NAME) -d -v --table (TABLE_NAME)
```

Remove the `OnConfiguring` method from the `DbContext` class.