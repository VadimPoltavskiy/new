int [] array ={13,21,37,45,59,61,76,58,95};
int n = array.Length;
int find = 37;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index=index + 1;
    index++;
}