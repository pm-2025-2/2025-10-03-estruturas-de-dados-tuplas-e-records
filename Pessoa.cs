// Um Registro -> Substantivo, ex: a Pessoa, o Pagamento, a Transferencia, o Veiculo, a Motocicleta, o Estudante, o Curso, ...
// Estrutura de Dados Heterogênea
public record class Pessoa
{
    // Propriedades (a ordem não faz diferença)
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
}
