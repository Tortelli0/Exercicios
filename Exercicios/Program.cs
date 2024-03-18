#nullable disable
using System;
using System.Drawing;
using System.Net.Mail;
using System.Runtime.Intrinsics.X86;
using System.Xml.Serialization;
//Eduardo Tortelli

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seja bem vindo!");
        Console.WriteLine("Digite o número do exercício (1 a 29): ");
        int exe = int.Parse(Console.ReadLine());

        if (exe == 1)
        {
            //Crie um programa para calcular o volume de uma caixa retangular

            Console.WriteLine("\nDigite o comprimento: ");
            double comp = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a largura: ");
            double larg = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite altura: ");
            double alt = int.Parse(Console.ReadLine());

            double vol = comp * larg * alt;

            Console.WriteLine($"\nO Volume é {vol}.");
        }

        if (exe == 2)
        {
            //Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius

            Console.WriteLine("\nDigite a temperatura em Fahrenheit para descobrir em Celsius: ");
            int f = int.Parse(Console.ReadLine());

            double celsius = (f - 32) / 1.8;

            Console.WriteLine($"\nA temperatura em Celsius é de {celsius}");
        }

        if (exe == 3)
        {
            //Crie um programa para calcular o volume de um Cilindro

            Console.WriteLine("\nDigite o raio do cilindro: ");
            int raio = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a altura co cilindro: ");
            int altura = int.Parse(Console.ReadLine());

            double volume = 3.14 * (raio * raio) * altura;

            Console.WriteLine($"\nO volume do cilindro é de {volume}");
        }

        if (exe == 4)
        {
            //Crie um programa para calcular o consumo de combustível por Km.
            #region INPUT
            Console.WriteLine("\nDigite a quilometragem inicial: ");
            int kmi = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a quilometragem final: ");
            int kmf = int.Parse((Console.ReadLine()));

            Console.WriteLine("\nDigite o consumo de combustivel: ");
            int consumo = int.Parse((Console.ReadLine()));
            #endregion

            #region processamento
            int consumoporkm = kmi - kmf / consumo;
            #endregion

            #region OUTPUT
            Console.WriteLine($"\nO consumo de combusítvel por km é de {consumoporkm}");
            #endregion
        }

        if (exe == 5)
        {
            //Crie um programa para calcular o volume de uma esfera
            Console.WriteLine("\nDigite o raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());

            double vol = 4 / 3 * 3.14 * (raio * raio * raio);

            Console.WriteLine($"\nO volume da sua esfera é de {vol}");
        }

        if (exe == 6)
        {
            //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
            Console.WriteLine("\nDigite a temperatura em Celsius  para descobrir em Fahrenheit: ");
            int c = int.Parse(Console.ReadLine());

            double Fahrenheit = (9 / 5) * c + 32;

            Console.WriteLine($"\nA temperatura em Fahrenheit é de {Fahrenheit}");
        }

        if (exe == 7)
        {
            //Crie um programa para calcular o salário total de um vendedor.
            Console.WriteLine("\nDigite o salário base: ");
            double salariobase = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o total de vendas");
            double totalvendas = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o percentual da comissão: ");
            double percentualcomissao = double.Parse(Console.ReadLine());

            double comissao = totalvendas + (totalvendas * percentualcomissao / 100);
            double salariototal = salariobase + comissao;

            Console.WriteLine($"\nO salário total deste vendedor é de {salariototal}");
        }

        if (exe == 9)
        {
            //Crie um programa para calcular a média harmônica das notas de um Aluno

            Console.WriteLine("\nDigite as três notas do aluno:");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));

            Console.WriteLine($"\nA média ponderada das notas é: {media}");
        }

        if (exe == 10)
        {
            //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
            Console.WriteLine("\nDigite a 1° nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a 2° nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o peso da 1° prova: ");
            double peso1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o peso da 2° prova: ");
            double peso2 = double.Parse(Console.ReadLine());

            double media = (peso1 * nota1 + peso2 * nota2) / (peso1 + peso2);

            Console.WriteLine($"\nA média ponderada é de {media}");
        }

        if (exe == 12)
        {
            // Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
            Console.WriteLine("\nDigite a area: ");
            double area = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o comprimento: ");
            double comp = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a largura: ");
            double larg = double.Parse(Console.ReadLine());

            double resultado = area - comp * larg;

            Console.WriteLine($"\nA área do terreno é de {resultado}");
        }

        if (exe == 13)
        {
            Console.WriteLine("\nDigite a quantidade de pães comprados: ");
            double paes = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a quantidade de broas compradas: ");
            double broas = double.Parse(Console.ReadLine());

            double arrecadacao = (paes * 0.12) + (broas * 1.50);

            double poupanca = 0.1 * arrecadacao;

            Console.WriteLine($"\nO total arrecadado foi de {arrecadacao} e a quantidade para guardar na poupança é de {poupanca}");

        }

        if (exe == 14)
        {
            Console.WriteLine("\nDigite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\nDigite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int diastotal = idade * 365;

            Console.WriteLine($"\nOlá, {nome} você possui {diastotal} dias de vida.");
        }

        if (exe == 16)
        {
            Console.WriteLine("\nDigite seu salario: ");
            double salarioinicial = double.Parse(Console.ReadLine());

            double salarioaumento = 0.15 * salarioinicial;

            double salariofinal = salarioinicial + salarioaumento - (0.08 * salarioinicial);

            Console.WriteLine($"\nSeu salario inicial é de {salarioinicial}, o seu aumento é de {salarioaumento} e o seu salario final é de {salariofinal}.");
        }

        if (exe == 17)
        {
            Console.WriteLine("\nDigite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("\nA e B são menores que C");
            }

            else
            {
                Console.WriteLine("\nA e B são maiores que C");
            }

        }

        if (exe == 18)
        {
            Console.WriteLine("\nDigite três valores: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int temp;

            if (b == a)
            {
                Console.WriteLine("\nO segundo valor deve ser diferente do primeiro. Tente novamente.");
                return;
            }

            int c = int.Parse(Console.ReadLine());

            if (c == a || c == b)
            {
                Console.WriteLine("\nO terceiro valor deve ser diferente dos dois primeiros. Tente novamente.");
                return;
            }

            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            if (a < c)
            {
                temp = a;
                a = c;
                c = temp;
            }

            if (b < c)
            {
                temp = b;
                b = c;
                c = temp;
            }

            Console.WriteLine($"\nOs valores em ordem decrescente são: {a}, {b}, {c}");

        }

        if (exe == 19)
        {
            Console.WriteLine("\nDigite seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            imc = Math.Round(imc, 5);


            if (imc < 18.5)
            {
                Console.WriteLine($"\nA sua condição é abaixo do peso, com o imc de {imc}");
            }

            if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine($"\nA sua condição é peso normal, com o imc de {imc}");

            }

            if (imc >= 25 && imc <= 30)
            {
                Console.WriteLine($"\nA sua condição é acima do peso, com o imc de {imc}");

            }

            if (imc > 30)
            {
                Console.WriteLine($"\nA sua condição é acima do peso, com o imc de {imc}");
            }

        }

        if (exe == 20)
        {
            Console.WriteLine("\nDigite um número para saber se é ímpar ou par: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("\nO número é par.");
            }

            else
            {
                Console.WriteLine("\nO número é ímpar.");
            }
        }

        if (exe == 21)
        {
            Console.WriteLine("\nDigite o valor de A: ");
            int a = int.Parse(Console.ReadLine());


            Console.WriteLine("\nDigite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                int soma = a + b;
                Console.WriteLine($"\nO resultado da soma para os números iguais é {soma}");
            }

            if (a != b)
            {
                int multiplicacao = a * b;
                Console.WriteLine($"\nO resultado da soma para os números iguais é {multiplicacao}");
            }

        }

        if (exe == 22)
        {
            //Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

            Console.WriteLine("Digite 1 para while e 2 para for: ");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (op == 1)
            {

                int numeroimpar1 = 101;

                while (numeroimpar1 < 199)
                {
                    numeroimpar1 += 2;
                    Console.WriteLine(numeroimpar1);
                }
            }

            if (op == 2)
            { 
                for (int numeroimpar2 = 101; numeroimpar2 <= 199; numeroimpar2 += 2)
                {
                    Console.WriteLine(numeroimpar2);
                }
            }
        }

        if (exe == 23)
        {
            //Desenvolver um algoritmo que efetue a soma de todos 
            //os números ímpares que são múltiplos de três e que se encontram no conjunto dos números de 1 até 500.

            int soma = 0;

                for(int i = 1; i <= 500; i++)
                {
                    bool ehimpar = i % 2 != 0;
                    bool ehmultiplodetres = i % 3 == 0;

                    if (ehimpar && ehmultiplodetres)
                    {
                        soma += i;
                    }
                }

            Console.WriteLine($"A soma dos números é {soma}");

        }

        if ( exe == 24) 
        {
            //Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N

            Console.WriteLine("Digite um número de 1 a 10: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int resultado = i * n;
                Console.WriteLine("\n{0} x {1} = {2}", i, n, resultado);   
                Console.WriteLine("\n" i + "x" + n + "=" + resultado);   
            }

        }


        if ( exe == 25) 
        {
            //Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
            int a, fatorial = 1;

            Console.WriteLine("Digite um valor para A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write(a + "! = ");

            for(int i = a; i >= 1; i--)
            {
                Console.Write(i + " ");
                fatorial *= i;

                if(i > 1)
                {
                    Console.Write("X ");
                }

            }

            Console.Write("= " + fatorial);

            Console.ReadLine();

        }

        if (exe == 26)
        {
            Console.Write("Digite um número: ");
            int numeroDigitado = int.Parse(ConsoleReadLine());

            int fib1 = 0, fib2 = 1;

            while (fib2 < numeroDigitado)
            {
                int fib3 = fib1 + fib2;
                Console.Write(fib3 + " ");
                fib1 = fib2;
                fib2 = fib3;

            }

            Console.WriteLine();

            Console.ReadLine();

        }

        if (exe == 27)
        {
            for(int i = 1; i <= 100; i++)
            {
                if( i % 3 == 0 && 1 % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz ");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz ");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz ");
                }

                else
                {
                    Console.Write(Convert.ToString(i) + " ");
                }

            }
        }

        if (exe == 28)
        {
            for(int i = 1; i<= 10; i++)
            {
                for(int j  = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.Write("{0} x {1} = {2}\n", i, j, result);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}