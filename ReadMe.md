# Minimum Reproducible Example

## Issue Accessing LocalDB using Enity Framework Core 8.0

For details, see this question issue in the Entity Framework Core repository: [/dotnet/SqlClient/issues/2888](https://github.com/dotnet/SqlClient/issues/2888).

### Observation

Opening a connection to LocalDB fails with exception:

####
```
Microsoft.Data.SqlClient.SqlException:
"An attempt to attach an auto-named database for file C:\\Temp\\Test.mdf failed. A database with the same name exists, or specified file cannot be opened, or it is located on UNC share."
```

### How To Run The MRE

Just compile and debug the Visual Studio solution's sole project, `EFC-LocalDB-MRE`.
