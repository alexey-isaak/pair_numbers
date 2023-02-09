int array_length = 10;

int[] array_p = new int[array_length];
for (int i=0;i<array_length;i++)
{
    Random random = new Random();
    int a = random.Next(1, 9);
    array_p[i] = a;
}

var str = string.Join(" ", array_p);
Console.WriteLine(str);

int[] summ_pair = new int[array_length / 2];
int first_index = 0;
int last_index = array_length - 1;
for (int i=0;i<array_length / 2;i++)
{
    summ_pair[i] = array_p[first_index] + array_p[last_index];
    first_index = first_index + 1;
    last_index = last_index - 1;
    Console.WriteLine("Сумма крайних: " + summ_pair[i]);

}
