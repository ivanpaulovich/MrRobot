#!/bin/bash
RESULT=`dotnet run --project "source/MrRobot.ConsoleApp/MrRobot.ConsoleApp.csproj" < input/backforththensmall-21810.txt`

echo $RESULT

if [[ $RESULT != *"=> Cleaned: 21810"* ]]; then
	echo "Error!"
else
	echo "OK"
fi

RESULT=`dotnet run --project "source/MrRobot.ConsoleApp/MrRobot.ConsoleApp.csproj" < input/crossSE-15001.txt`

echo $RESULT

if [[ $RESULT != *"=> Cleaned: 15001"* ]]; then
	echo "Error!"
else
	echo "OK"
fi

RESULT=`dotnet run --project "source/MrRobot.ConsoleApp/MrRobot.ConsoleApp.csproj" < input/longsteps-2399996.txt`

echo $RESULT

if [[ $RESULT != *"=> Cleaned: 2399996"* ]]; then
	echo "Error!"
else
	echo "OK"
fi

RESULT=`dotnet run --project "source/MrRobot.ConsoleApp/MrRobot.ConsoleApp.csproj" < input/visitcorners-600001.txt`

echo $RESULT

if [[ $RESULT != *"=> Cleaned: 600001"* ]]; then
	echo "Error!"
else
	echo "OK"
fi

RESULT=`dotnet run --project "source/MrRobot.ConsoleApp/MrRobot.ConsoleApp.csproj" < input/visitmedium-58777801.txt`

echo $RESULT

if [[ $RESULT != *"=> Cleaned: 58777801"* ]]; then
	echo "Error!"
else
	echo "OK"
fi

RESULT=`dotnet run --project "source/MrRobot.ConsoleApp/MrRobot.ConsoleApp.csproj" < input/visitmuch-163489327.txt`

echo $RESULT

if [[ $RESULT != *"=> Cleaned: 163489327"* ]]; then
	echo "Error!"
else
	echo "OK"
fi

RESULT=`dotnet run --project "source/MrRobot.ConsoleApp/MrRobot.ConsoleApp.csproj" < input/visitmuch2-666800001.txt`

echo $RESULT

if [[ $RESULT != *"=> Cleaned: 666800001"* ]]; then
	echo "Error!"
else
	echo "OK"
fi
