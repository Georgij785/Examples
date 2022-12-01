int Max(int arg1,int arg2,int arg3)
{
    int result=arg1;
    if (arg2> result) result=arg2;
    if (arg3>result) result=arg3;
    return(result);
}




int a1 = 56;
int b1 = 45;
int c1 = 5;
int a2 = 546;
int b2 = 6;
int c2 = 4545;
int a3 = 6456;
int b3 = 34;
int c3 = 53;

//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int Maximum=Max(max1,max2,max3);

Console.WriteLine(Max(Max(a1,b1,c1),Max(a2,b2,c2) ,Max(a3,b3,c3)));


