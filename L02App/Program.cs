

Console.WriteLine("Enter a number larger than 0. \n0 to exit program!");

string input = Console.ReadLine();

int num = int.Parse(input);
int a = 0;
int b = 1;
for (int i = 0; i < num; i++)
{
    int temp = a;
    a = b;
    b = temp + b;
    Console.WriteLine(a);
}
