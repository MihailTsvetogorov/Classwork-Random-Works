// c++Exercises.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int check(int number)
{
	cin>>number;
	while(number <= 1 && number >= 15,000);{
		cin>>number;
	}
	return number;
}

int numberDigitCount(int number)
{
	int i = 0;
	for(i; number > 0; i++)
	{
		number /= 10;
	}
	return i;
}

int _tmain(int argc, _TCHAR* argv[])
{
	int N;
	N = check(N);
	numberDigitCount(N);

	return 0;
}

