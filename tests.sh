#!/bin/bash
pushd source/MrRobot.ConsoleApp

RESULT=`dotnet run <<< '2
10 22
E 2
N 1'`

echo $RESULT

if [[ $RESULT != *"=> Cleaned: 4"* ]]; then
	echo "Error!"
else
	echo "OK"
fi

RESULT=`dotnet run <<< '4
-10 0
E 10
N 10
W 10
S 10'`

echo $RESULT

if [[ $RESULT != *"=> Cleaned: 40"* ]]; then
	echo "Error!"
else
	echo "OK"
fi

RESULT=`dotnet run <<< '8
-100 100
E 10
W 10
E 10
W 10
E 10
W 10
E 10
W 10'`

echo $RESULT

if [[ $RESULT != *"=> Cleaned: 11"* ]]; then
	echo "Error!"
else
	echo "OK"
fi

RESULT=`dotnet run <<< '4
-100000 -100000
E 200000
S 200000
W 200000
N 200000'`

echo $RESULT

if [[ $RESULT != *"=> Cleaned: 800000"* ]]; then
	echo "Error!"
else
	echo "OK"
fi

popd
