using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercFuncionario
{
    internal class Funcionario
    {

        private string _nome;
        public double Valor { get; private set; }

        public Funcionario(string nome, double valor)
        {
            _nome = nome;
            Valor = valor;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double SalarioLiquido(double imposto)
        {
            return Valor - imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            return Valor * (porcentagem / 100) + Valor;
        }
    }
}
