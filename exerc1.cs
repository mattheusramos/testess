System.Console.Write("Digite o valor de A: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Digite o valor de B: ");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Digite o valor de C: ");
int C = Convert.ToInt32(Console.ReadLine());

int soma = A + B;
System.Console.WriteLine(soma);

if(soma < C){
    System.Console.WriteLine("A soma de A + B é menor que C!");
}else{
    System.Console.WriteLine("A soma dos valores é maior que C!");
}