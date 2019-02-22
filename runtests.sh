#!/bin/bash
pushd source/MrRobot.ConsoleApp/bin/Debug/netcoreapp2.2

dotnet MrRobot.ConsoleApp.dll <<< '2
10 22
E 2
N 1'

dotnet MrRobot.ConsoleApp.dll <<< '4
-10 0
E 10
N 10
W 10
S 10'

dotnet MrRobot.ConsoleApp.dll <<< '8
-100 100
E 10
W 10
E 10
W 10
E 10
W 10
E 10
W 10'

dotnet MrRobot.ConsoleApp.dll <<< '4
-100000 -100000
E 200000
S 200000
W 200000
N 200000'

popd