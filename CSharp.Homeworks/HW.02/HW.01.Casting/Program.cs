////Explicit conversion
//Example 1
byte abyte = 4;
long blong = abyte;
Console.WriteLine(blong);
//Example 2
sbyte csbyte = 8;
short dshort = csbyte;
Console.WriteLine(dshort);
//Example 3
short ashort = 3;
double adouble = ashort;
Console.WriteLine(adouble);
//Example 4
long along = 45;
decimal adecinal = along;
Console.WriteLine(adecinal);
//Example 5
int aint = 65;
double bdouble = aint;
Console.WriteLine(bdouble);
//Example 6
float afloat = 49;
double cdouble = afloat;
Console.WriteLine(cdouble);
//Example 7
char achar = 't';
int bint = achar;
Console.WriteLine(bint);
//Example 8
uint auint = 39;
double hdouble = auint;
Console.WriteLine(hdouble);
//Example 9
sbyte asbyte = 32;
long clong = asbyte;
Console.WriteLine(clong);
//Example 10
ulong aulong = 689529;
decimal bdecinal = aulong;
Console.WriteLine(bdecinal);

////Implicit conversion
//Example 1
double edouble = 67.5;
decimal cdecimal = (decimal)edouble;
Console.WriteLine(cdecimal);
//Example 2
int cint = 879;
byte cbyte = (byte)(aint + cint);
Console.WriteLine(cbyte);
//Example 3
ulong bulong = (ulong)afloat;
Console.WriteLine(bulong);
//Example 4
decimal fdecimal = 4612;
short bshort = (short)fdecimal;
Console.WriteLine(bshort);
//Example 5
bint = (int)edouble;
Console.WriteLine(bint);
//Example 6
char bchar = (char)fdecimal;
Console.WriteLine(bchar);
//Example 7
blong = (long)cint;
//Example 8
double ndouble = 89.5;
short gshort = (short)ndouble;
Console.WriteLine(gshort);
//Example 9
decimal gdecimal = 7136485;
uint cuint = (uint)gdecimal;
Console.WriteLine(cuint);
//Example 10
int qint = (int)achar;
Console.WriteLine(qint);

////boxing
//Example 1
int val1 = 98;
object obj1 = val1;
Console.WriteLine(obj1);
//Example 2
float fval1 = 15;
object obj2 = fval1;
Console.WriteLine(obj2);
//Example 3
double dval1 = 789.5;
object obj3 = dval1;
Console.WriteLine(obj3);
//Example 4
char charval1 = 'r';
dynamic dynval1 = charval1;
Console.WriteLine(dynval1);
//Example 5
dynamic dynval2 = val1;
Console.WriteLine(dynval2);
//Example 6
bool logic1 = true;
object logic2 = logic1;
Console.WriteLine(logic2);
//Example 7
bool logic3 = true;
dynamic dynval3 = logic3;
Console.WriteLine(dynval3);
//Example 8
float fval3 = 49;
dynamic dynval4 = fval3;
Console.WriteLine(dynval4);
//Example 9
double dval2 = 492;
dynamic dynval5 = dval2;
Console.WriteLine(dynval5);
//Example 10
int val2 = 4135;
dynamic dynval6 = val2;
Console.WriteLine(dynval6);

////Unboxing
//Example 1
int valUnboxed1 = (int)obj1;
Console.WriteLine(valUnboxed1);
//Example 2
float fvalUnboxed1 = (float)obj2;
Console.WriteLine(fvalUnboxed1);
//Example 3
double dvalUnboxed1 = (double)obj3;
Console.WriteLine(dvalUnboxed1);
//Example 4
int val3 = 169;
object obj4 = val3;
int valUnboxed4 = (int)obj4;
Console.WriteLine(valUnboxed4);
//Example 5
int valUnboxed2 = (int)dynval2;
Console.WriteLine(valUnboxed2);
//Example 6
bool boolUnboxed1 = (bool)logic2;
Console.WriteLine(boolUnboxed1);
//Example 7
bool logic4 = false;
object logic5 = logic4;
bool boolUnboxed2 = (bool)logic5;
Console.WriteLine(boolUnboxed2);
//Example 8
float fval4 = 49;
object obj5 = fval4;
float fvalUnboxed2 = (float)obj5;
Console.WriteLine(fvalUnboxed2);
//Example 9
object obj6 = dval2;
double dvalUnboxed2 = (double)obj6;
Console.WriteLine(dvalUnboxed2);
//Example 10
object obj7 = val2;
int valUnboxed3 = (int)obj7;
Console.WriteLine(valUnboxed3);