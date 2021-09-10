Run
  dotnet watch run
  ng serve
Migration:
  dotnet ef migrations add "Initial Create" -p Infrastructure -s API -c StoreContext -o Data/Migrations
Publish: 
  dotnet restore
  dotnet publish -c Release -o publish skinet.sln
ConnectionStrings:
  MySql: "Server=localhost; Port=3306; Uid=root; Pwd=secret; Database=skinet"
  Postgres: "Server=localhost; Port=5432; User Id=appuser; Password=secret; Database=skinet"