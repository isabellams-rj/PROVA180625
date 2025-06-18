using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROVA180625
public class Funcionario
{
    public string Nome;
    public string CPF;
    public double SalarioBase;

    public Funcionario(string nome, string cpf, double salarioBase)
    {
        Nome = nome;
        CPF = cpf;
        SalarioBase = salarioBase;
    }
    public virtual double CalcularSalarioFinal()
    {
        return SalarioBase;
    }
}
public class Gerente : Funcionario
{
    private const double Bonus = 2000.0;

    public Gerente(string nome, string cpf, double salarioBase)
        : base(nome, cpf, salarioBase) {}

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + Bonus;
    }
}

public interface IEstagiario
{
    double CalcularSalarioFinal();
}
