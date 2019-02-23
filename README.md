# :zap: What is Mr. Robot?
A programmatically Cleaning Robot that informs the number of places cleaned after each execution.

# :rocket: Running Unit Tests

```
dotnet test tests/MrRobot.UnitTests/MrRobot.UnitTests.csproj
```

# :airplane: Running Tests in Terminal

```
dotnet run <<< '2
10 22
E 2
N 1'
```

Expected Output:

```
=> Cleaned: 4
```

Or try the demo which run the robot for multiple inputs

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