//// See https://aka.ms/new-console-template for more information
///*ハンズオン０１*/
//int a = 8;
//int b = 2;
//int c = a + b;
//Console.WriteLine(c + "\n");

//int d = a - b;
//Console.WriteLine(d + "\n");

//int e = a * b;
//Console.WriteLine(e + "\n");

//int f = a / b;
//Console.WriteLine(f + "\n");

//int g = a % b;
//Console.WriteLine(g + "\n");

///*ハンズオン０２*/
//int nmb = 4;
//if (nmb % 2 == 1)
//{
//    Console.WriteLine("奇数だよ\n");
//}
//else
//{
//    Console.WriteLine("偶数だよ\n");
//}

///*ハンズオン０３*/
//string ans = "f";
//string use = Console.ReadLine() ?? "";
//while (use != ans)
//{
//    Console.WriteLine("不正解\n");
//    Console.WriteLine("もう一度入力してください。\n");
//    use = Console.ReadLine() ?? "";
//}
//Console.WriteLine("正解");

///*ハンズオン０４*/
//nmb = 1;
//int loop = 0;
//loop = 2;
//while (loop <= 100)
//{
//    nmb += loop;
//    loop++;

//}
//Console.WriteLine(nmb);

///*ハンズオン 05*/
//do
//{
//    Console.WriteLine("答えを入力してください。\n");
//    use = Console.ReadLine() ?? "";
//}
//while (use != ans);
//{
//    Console.WriteLine("不正解\n");
//    Console.WriteLine("もう一度入力してください。\n");
//    use = Console.ReadLine() ?? "";
//}
//Console.WriteLine("正解");

///*ハンズオン 06*/
//int answer06 = 0;
//for (int i = 0; i < 101; i++)
//{
//    answer06 += i;
//}
//Console.WriteLine(answer06 + "\n");

///*ハンズオン 07*/

//float a6 = 8.12456f;
//float b6 = 2.12456f;
//float c6 = a6 + b6;
//Console.WriteLine(c6 + "\n");

//float d6 = a6 - b6;
//Console.WriteLine(d6 + "\n");

//float e6 = a6 * b6;
//Console.WriteLine(e6 + "\n");

//float f6 = a6 / b6;
//Console.WriteLine(f6 + "\n");

///*ハンズオン 08*/
//float number = 0f;
//for (int i = 0; i < 1000; i++)
//{
//    number += 0.001f;
//}
//Console.WriteLine(number + "\n");
//float number2 = 10000f;
//number2 += 0.0001f;
//Console.WriteLine(number2);

///*ハンズオン 09*/
//int num09 = 9;
//bool over0 = num09 >= 0;
//bool under10 = num09 <= 10;
//if (over0 && under10)
//{
//    Console.WriteLine(num09 + "shi0-10yinei\n");
//}

///*ハンズオン 10*/
//int num10 = 1;
//int add10 = 1;
//Console.WriteLine(num10);
//Console.WriteLine(add10);
//for (int i = 0; i < 40; i++)
//{
//    int next = num10 + add10;
//    Console.WriteLine(next);
//    num10 = add10;
//    add10 = next;

//}
//Console.WriteLine("\n");

//num10 = 1;
//add10 = 1;
//Console.WriteLine(num10);
//Console.WriteLine(add10);
//for (int i = 0; i < 50; i++)
//{
//    int next = num10 + add10;
//    Console.WriteLine(next);
//    num10 = add10;
//    add10 = next;
//}
//Console.WriteLine("\n");

//long numberA = 1;
//long numberB = 1;
//Console.WriteLine(numberA);
//Console.WriteLine(numberB);
//for (int i = 0; i < 50; i++)
//{
//    long next = numberA + numberB;
//    Console.WriteLine(next);
//    numberA = numberB;
//    numberB = next;
//}

///*ハンズオン 11*/
//double Xbmi = 0;
//double W = 50;
//double H = 1.78;
//Xbmi = W / H / H;
//Console.WriteLine("\n"+Xbmi);

///*ハンズオン 12*/
//double Xbmi12 = 0;
//Console.WriteLine("身長を入力してください。\n");
//string useH = Console.ReadLine() ?? "";
//Console.WriteLine("体重を入力してください。\n");
//string useW = Console.ReadLine() ?? "";
//double W12 = double.Parse(useW);
//double H12 = double.Parse(useH);
//Xbmi12 = W12 / H12 / H12;
//Console.WriteLine("あなたのBMIは"+Xbmi12+ "です。");

///*ハンズオン 13*/
//Console.WriteLine("身長を入力してください。\n");
//string useH = Console.ReadLine() ?? "";
//double H = 0;
//try
//{
//    H = double.Parse(useH);

//}
//catch (Exception e)
//{
//    Console.WriteLine("数字を入力してください。\n" + e.ToString());
//    useH = Console.ReadLine() ?? "";
//    H = double.Parse(useH);
//}
//finally
//{
//    Console.WriteLine("身長は" + H + "です。");
//}
//Console.WriteLine("体重を入力してください。\n");
//string useW = Console.ReadLine() ?? "";
//double W = 0;
//try
//{
//    W = double.Parse(useW);

//}
//catch (Exception e)
//{
//    Console.WriteLine("数字を入力してください。\n" + e.ToString());
//    useW = Console.ReadLine() ?? "";
//    W = double.Parse(useW);
//}
//finally
//{
//    Console.WriteLine("体重は" + W + "です。");
//}
//double Xbmi = W / H / H;
//Console.WriteLine("あなたのBMIは" + Xbmi + "です。");

///*ハンズオン 14*/
//Console.WriteLine("身長を入力してください。\n");
//string useH = Console.ReadLine() ?? ""; ;
//double H;
//bool parseSuccessH = double.TryParse(useH, out H);
//if (parseSuccessH)
//{
//    Console.WriteLine("身長は" + H + "です。");
//}
//else
//{
//    Console.WriteLine("数字を入力してください。\n");
//    useH = Console.ReadLine() ?? "";
//    H = double.Parse(useH);
//    Console.WriteLine("身長は" + H + "です。");
//}

//Console.WriteLine("体重を入力してください。\n");
//string useW = Console.ReadLine() ?? "";
//double W;
//bool parseSuccessW = double.TryParse(useW, out W);
//if (parseSuccessW)
//{
//    Console.WriteLine("体重は" + W + "です。");
//}
//else
//{
//    Console.WriteLine("数字を入力してください。\n");
//    useW = Console.ReadLine() ?? "";
//    W = double.Parse(useW);
//    Console.WriteLine("体重は" + W + "です。");
//}
//double Xbmi = W / H / H;
//Console.WriteLine("あなたのBMIは" + Xbmi + "です。");

/*ハンズオン 15*/
int a = 0;
double max = 0;
double add = 0;
double min = 999999999999999;
double ave = 0;
double[] intArray = new double[] { 45, 11, 111, 123, 134, 124, 545, 466, 12, 314, 566, 5, 2, 5454, 667, 78, 8956, 34 ,121};
for (int i = 0; i < intArray.Length; i++)
{
    add += intArray[i];
    a += 1;
    if (intArray[i] >= max)
    {
        max = intArray[i];
    }
    if (intArray[i] <= min)
    {
        min = intArray[i];
    }
}
ave = add / a;
Console.WriteLine("個数は" + a + "です。");
Console.WriteLine("合計値は" + add + "です。");
Console.WriteLine("最大値は" + max + "です。");
Console.WriteLine("最小値は" + min + "です。");
Console.WriteLine("平均値は" + ave + "です。");
if (a % 2 == 1)
{
    int i = a / 2 ;
    Console.WriteLine("中値は" + intArray[i] + "です。");
}
else
{
    Console.WriteLine("偶数だよ\n");
}
