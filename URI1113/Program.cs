﻿// Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma mensagem que indique se estes 
// valores foram digitados em ordem crescente ou decrescente.

// Entrada:
// A entrada contém vários casos de teste. Cada caso contém dois valores inteiros X e Y. A leitura deve ser encerrada ao ser fornecido valores iguais para X e Y.

// Saída:
// Para cada caso de teste imprima “Crescente”, caso os valores tenham sido digitados na ordem crescente, caso contrário imprima a mensagem “Decrescente”.

using System;

namespace URI1113 {
    class Program {
        static void Main(string[] args) {

            int X, Y;

            string[] vet = Console.ReadLine().Split(' '); // ler dados na mesma linha(Split).
            X = int.Parse(vet[0]);
            Y = int.Paese(vet[1]);

            while (X != y) { //enquanto x for diferente de y
                if (X < y) {
                    Console.WriteLine("Crescente");
                }
                else {
                    Console.WriteLine("Decrescente");
                }
                vet = Console.ReadLine().Split(' '); // ler dados na mesma linha(Split).
                X = int.Parse(vet[0]);
                Y = int.Paese(vet[1]);

            }

        }
    }
}