int[] toaleta = {1, 2, 3};
while (true)
{
    Console.Write("Input Number: ");
    sigma(int.Parse(Console.ReadLine()));


    for (int i = 0; i < toaleta.Length; i++)
    {
        Console.WriteLine(toaleta[i]);
    }
    Console.WriteLine(); 
}
void sigma(int input)
{
    Array.Resize(ref toaleta, toaleta.Length+1);
    toaleta[toaleta.Length-1] = input;
}