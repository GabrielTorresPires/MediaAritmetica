Console.WriteLine("Descubra a Média Aritmética de 3 números");

Console.WriteLine("Digite o primeiro número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
double numero3 = Convert.ToDouble(Console.ReadLine());

double media = (numero1+numero2+numero3) / 3;

Console.WriteLine($"\n A Média é: {media:N1}");

