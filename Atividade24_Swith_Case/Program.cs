﻿using System;

namespace Curso {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x) {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terça";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sábado";
                    break;
                default:
                    dia = "Valor inválido";
                    break;
                }

            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadLine();
        }
    }
}