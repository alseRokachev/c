﻿int a = 1;
int b = 7;
int c = 3;
int d = 4;
int e = 1;

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.Write("Max = ");
Console.WriteLine(max);
