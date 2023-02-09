// Tabuada de 10
int num;
int calc;
Console.WriteLine("Olá! Vamos fazer a tabuada de 10 de um número que você desejar!");
Console.WriteLine("Digite um número que deseja fazer a tabuada:");
num = int.Parse(Console.ReadLine());
for(int i = 0; i < 11; i++){
    calc = num * i;
    Console.WriteLine($"{num} x {i} = {calc}");
}
