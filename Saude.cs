// classe estática: não é uma ED
public static class Saude
{
  // Estrutura de Dados: TUPLA (ordem importa)
  // (double imc, string situacao)
  public static (double Imc, string Situacao) Imc(Pessoa pessoa)
  {
    double imc = pessoa.Peso / Math.Pow(pessoa.Altura, 2);

    string situacao;
    if (imc < 17) situacao = "Muito abaixo";
    else if (imc < 18.5) situacao = "Abaixo";
    else if (imc < 25) situacao = "Normal";
    else if (imc < 30) situacao = "Sobrepeso";
    else if (imc < 35) situacao = "Obesidade I";
    else if (imc < 40) situacao = "Obesidade II";
    else situacao = "Obesidade III";
    // TUPLA(double, string)
    return (Imc: imc, Situacao: situacao);
  }
}