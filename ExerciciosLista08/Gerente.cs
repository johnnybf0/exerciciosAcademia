﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista08
{
    class Gerente : Funcionario
    {
        public Gerente() { }
        public Gerente(string nome, string departamento, double salario, string data, string rg, bool ativo) : base(nome, departamento, salario, data, rg, ativo) { }
        public override void ExecutaTrabalho()
        {
            Console.WriteLine("Função: Gerente");
        }



    }
}
