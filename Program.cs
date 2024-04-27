Console.WriteLine("Quantas pessoas irá ter?");
int[] idades = new int[int.Parse(Console.ReadLine())];

string[] nomes = new string[idades.Length];

int maiores = 0;

for (int i = 0; i < idades.Length; i++)
{
    Console.WriteLine($"Qual a {i + 1} idade?");
    idades[i] = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual o nome?");
    nomes[i] = Console.ReadLine();

    if (idades[i] >= 18)
    {
        maiores++;
    }
}
Console.WriteLine($"{maiores} pessoas são maiores de idade");