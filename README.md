# :zap: What is Mr. Robot?
A programmatically Cleaning Robot that informs the number of places cleaned after each execution.

# :rocket: Running Unit Tests

```
dotnet test tests/MrRobot.UnitTests/MrRobot.UnitTests.csproj
```

# :airplane: Running Demos

```
dotnet run --project "source/MrRobot.ConsoleApp/MrRobot.ConsoleApp.csproj"
2
10 22
E 2
N 1
```

Expected Output:

```
=> Cleaned: 4
```

Or try the `demo.sh` which runs the robot for multiple inputs

```
chmod 777 demo.sh
./demo.sh
```

Expected Output:

```
=> Cleaned: 4
=> Cleaned: 40
=> Cleaned: 11
=> Cleaned: 800000
```

Usage:

```
dotnet run --project "source/MrRobot.ConsoleApp/MrRobot.ConsoleApp.csproj"
[number of commands]
[initial position x] [initial position y]
[direction] [number of steps]
[direction] [number of steps]
..
[direction] [number of steps]

Where:

[number of commands] : 0..N
[initial position x] : -100000..100000
[initial position y] : -100000..100000
[direction] : N E S W
[number of steps] : 0..200000
```

## :floppy_disk: Setup SQL Server (Optional)

### Setup SQL Server in Docker

Run `scripts/sql-docker-up.sh` to setup a SQL Server in a Docker container with the following Connection String:

```
Server=localhost;User Id=sa;Password=<YourNewStrong!Passw0rd>;
```

#### Add Migration

Run the EF Tool to add a migration to the `MrRobot.Infrastructure` project.

```sh
dotnet ef migrations add "InitialCreate" -o "EntityFrameworkDataAccess/Migrations" --project source/MrRobot.Infrastructure --startup-project source/MrRobot.ConsoleApp
```

#### Update the Database

Generate tables and seed the database via Entity Framework Tool:

```sh
dotnet ef database update --project source/MrRobot.Infrastructure --startup-project source/MrRobot.ConsoleApp
```

## :checkered_flag: Development Environment

* MacOS Sierra
* VSCode :heart:
* [.NET Core SDK 2.2](https://www.microsoft.com/net/download/dotnet-core/2.2).
* Docker :whale:
* SQL Server.

## :telephone: Support and Issues

I am happy to answer issues. Give a :star: if you like the project.