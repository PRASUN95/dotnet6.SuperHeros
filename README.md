# dotnet6.SuperHeros

**Commands used to create this project**:
```
   1. dotnet new webapi --name SuperHeroes.API
   2. dotnet new sln --name SuperHeroes
   3. dotnet sln SuperHeroes.sln add SuperHeroes.API/SuperHeroes.API.csproj
   4. dotnet sln SuperHeroes.sln list
   5. dotnet new gitignore
   6. dotnet run
```

**API End Points**:
``` GET  : http://localhost:5124/api/SuperHeroes
    GET  : http://localhost:5124/api/SuperHeroes/1
    POST : http://localhost:5124/api/SuperHeroes
    PUT  : http://localhost:5124/api/SuperHeroes
    Delete : http://localhost:5124/api/SuperHeroes/1 
```
  
**Sample body for Post and Put requests**:
```Javascript
    {
	"Id" : "5",
	"Name":"Thor",
	"FirstName": "Mighty",
	"LastName": "Thor",
	"Location": "Asgard"
    }
```

