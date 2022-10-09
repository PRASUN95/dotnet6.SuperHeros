# dotnet6.SuperHeros

Commands used to create this project:
  dotnet new webapi --name SuperHeroes.API
  dotnet new sln --name SuperHeroes
  dotnet sln SuperHeroes.sln add SuperHeroes.API/SuperHeroes.API.csproj
  dotnet sln SuperHeroes.sln list
  dotnet new gitignore
  dotnet run

API EndPoints:
  GET  : http://localhost:5124/api/SuperHeroes
  GET  : http://localhost:5124/api/SuperHeroes/1
  POST : http://localhost:5124/api/SuperHeroes
  PUT  : http://localhost:5124/api/SuperHeroes
  Delete : http://localhost:5124/api/SuperHeroes/1
  
Sample Request Body For Post/Put:
  	{
		"Id" : "5",
		"Name":"Thor",
		"FirstName": "Mighty",
		"LastName": "Thor",
		"Location": "Asgard"
	}
