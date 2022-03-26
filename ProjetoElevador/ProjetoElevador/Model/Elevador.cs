using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        private int andarAtual = 0; // andar em que o elevador está atualmente
        private int andaresTotal = 0; // quantidade de andares do prédio
        private int capacidadeTotal = 0; // capacidade de pessoas dentro do elevador
        private int capacidadeAtual = 0; // quantidade de pessoas presentes dentro do elevador atualmente

        // Inicializa o sistema: parâmetros iniciais
        // Retorna TRUE se os valores estiverem corretos e FALSE se houver algum erro
        public bool inicializar(int andares, int capacidade)
        {
            // andares e capacidade precisam ser valores positivos.
            if ((andares <= 0) || (capacidade <= 0)) 
            {
                return false;
            }
            else
            {
                andarAtual = 0; // sistema começa com elevador no térreo
                capacidadeAtual = 0; // sistema começa com elevador vazio

                capacidadeTotal = capacidade;
                andaresTotal = andares;

                return true;
            }
        }

        // Adiciona 1 pessoa dentro do elevador
        public void entrar()
        {
            if ((capacidadeAtual + 1) <= capacidadeTotal)
            {
                capacidadeAtual++;
            }
        }

        // Retira 1 pessoa do elevador
        public void sair()
        {
            if (capacidadeAtual > 0)
            {
                capacidadeAtual--;
            }
        }

        // Sobe 1 andar no elevador
        public void subir()
        {
            if ((andarAtual + 1) <= andaresTotal)
            {
                andarAtual++;
            }
        }

        // Desce 1 andar no elevador
        public void descer()
        {
            if ((andarAtual - 1) >= 0)
            {
                andarAtual--;
            }
        }

        // Retona o andar atual do elevador
        public int getAndarAtual()
        {
            return andarAtual;
        }

        // Retorna a quantidade de pessoal atualmente dentro do elevador
        public int getCapacidadeAtual()
        {
            return capacidadeAtual;
        }

    }

}

