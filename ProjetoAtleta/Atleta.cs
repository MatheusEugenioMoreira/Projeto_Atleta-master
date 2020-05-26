using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private int idade;
        private double altura, peso;

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("Nome deve ser preenchido");
                }
            }
            get { return this.nome; }
        }

        public int Idade
        {
            set { this.idade = value; }

            get { return this.idade; }
                        
        }

        public double Altura
        {
            set
            {
                if(value >= 1.00)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("Altura mínima de 1 metro");
                }
            }

            get { return this.altura; }
        }

        public double Peso
        {
            set { this.peso = value; }

            get { return this.peso; }
        }

        public string ImprimirDados()
        {
            return "Dados obtidos: \n\nNome: " + this.nome + "\nIdade: " + this.idade;
        }

        public double CalcularIMC()
        {
            return this.peso / (this.altura * this.altura);

        }


        
    }
}
