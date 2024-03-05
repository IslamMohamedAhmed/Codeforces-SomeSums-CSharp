string num;
int sum1 = 0, sum2;
num = Console.ReadLine();
var arr = num.Split(' ');

int N = Convert.ToInt32(arr[0]);
int A = Convert.ToInt32(arr[1]);
int B = Convert.ToInt32(arr[2]);
int mn = Math.Min(A, B);
int mx = Math.Max(A, B);

for (int i = mn; i <= N; i++)
{
    int x = i;
    sum2 = 0;
    while (x > 0)
    {
        sum2 += x % 10;
        x /= 10;
    }

    if (sum2 >= mn && sum2 <= mx)
    {
        sum1 += i;
    }

}
Console.WriteLine(sum1);











