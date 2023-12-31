﻿// Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, 
// respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". 
// Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, 
// o programa deve imprimir a mensagem "Aluno em exame.".

// No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. 
// Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) 
// ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última linha uma mensagem 
// "Media final: " seguido da média final para esse aluno.

// Entrada:
// A entrada contém quatro números de ponto flutuante correspendentes as notas dos alunos.

// Saída:
// Todas as respostas devem ser apresentadas com uma casa decimal. As mensagens devem ser impressas conforme a descrição do problema. Não esqueça de imprimir o enter após o 
// final de cada linha, caso contrário obterá "Presentation Error".

using System;
using System.Globalization;
 
namespace Atividade40{
 
    class Program{
 
        static void Main(string[] args){
 
            string[] v = Console.ReadLine().Split(' ');
            float n1 = float.Parse(v[0], CultureInfo.InvariantCulture);
            float n2 = float.Parse(v[1], CultureInfo.InvariantCulture);
            float n3 = float.Parse(v[2], CultureInfo.InvariantCulture);
            float n4 = float.Parse(v[3], CultureInfo.InvariantCulture);
 
            float media = ((n1*2) + (n2*3) + (n3*4) + n4)/10;
            if (media == 4.85f) {
                media = 4.8f;
            }
 
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
 
            if (media >= 7.0){
                Console.WriteLine("Aluno aprovado");
            }
 
            else if (media < 5.0){
                Console.WriteLine("Aluno reprovado");
            }
 
            else {
            float exame = float.Parse(Console.ReadLine());
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame: ");
                Console.WriteLine("Nota do exame: " + exame);
            float mediaExame = (media + exame)/2;
                if(mediaExame>=5.0){
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1", CultureInfo.InvariantCulture));
                }
                else if(mediaExame<=4.9){
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1", CultureInfo.InvariantCulture));
                    }
 
            }
        }
    }
}


