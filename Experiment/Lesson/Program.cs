﻿int Max (int arg1, int arg2, int arg3)
{
int result = arg1;
if(arg2 > result) result = arg2;
if(arg3 > result) result = arg3;
return result;
}
int a1 = 15;
int b1 = 10;
int c1 = 27;
int a2 = 39;
int b2 = 61;
int c2 = 43;
int a3 = 31;
int b3 = 23;
int c3 = 7;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);