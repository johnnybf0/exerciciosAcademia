﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjeto7
{
    public class Aluguel
    {
        private DateTime inicioAluguel;
        private DateTime fimAluguel;
        private double valorDiaria;
        private int diasAlugados;
        private double valorFinal;
        public Carro carro;
        public Cliente cliente;

        public void alugar(DateTime inicio, DateTime fim, double valor)
        {
            this.inicioAluguel = inicio;
            this.fimAluguel = fim;
            this.valorDiaria = valor;
        }

        public DateTime getInicioAluguel()
        {
            return this.inicioAluguel;
        }

        public DateTime getFimAluguel()
        {
            return fimAluguel;
        }

        public double valorAluguel()
        {
            DateTime inicio = getInicioAluguel();
            DateTime fim = getFimAluguel();
            int dias = (int)fim.Subtract(inicio).TotalDays;
            valorFinal = this.valorDiaria * dias;
            return valorFinal;
        }

    }
}
