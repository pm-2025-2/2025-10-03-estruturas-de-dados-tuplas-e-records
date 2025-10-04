// PostgreSQL
// RDBMS (Relational DataBase Management System)
// Sistema Gerenciador de Bases de Dados Relacionais
Console.WriteLine("Hello, World!");
// Estruturas de Dados (ED)
// string -> ED de caracteres
// vetor -> arranjo -> array (gasta menos memória)
// array de double (64 bits = 8 bytes) - espaço reservado e
// de tamanho fixo
// array -> útil para coleções finitas
int[] semestres = [1, 2, 3, 4, 5, 6];
string[] estadoCivil = ["Cadado(a)", "Solteiro(a)", "Divorciado(a)", "Viuvo(a)"];

string[] pessoas = [
    "Fulano",     // 0
    "Beltrano",   // 1
    "Cicrano",    // 2
    "Mariano"     // 3
];

double[] alturas = new double[4];
alturas[0] = 1.70;
alturas[1] = 1.65;
alturas[2] = 1.85;
alturas[3] = 1.45;

double[] pesos = [76.4, 87.9, 56.7, 65.1];

// foreach (var peso in pesos)

int[] idades = [43, 23, 18, 67];

Console.WriteLine(pesos.Length);

for (var i = 0; i < 4; i++)
{
    Console.WriteLine($"{pessoas[i]} altura {alturas[i]} peso {pesos[i]}");
}
// array é uma estrutura de dado homogênea -> 
// de um tipo específico, array é ordenado
// a ordem em que é declarado é a ordem em que é lido

// é possível agrupar dados? estrutura heterogênea
// Um REGISTRO (record)

Pessoa p1 = new Pessoa // instanciar e inicializar
{
    Nome = "Fulano",
    Idade = 43,
    Peso = 76.4,
    Altura = 1.70
};

Console.WriteLine(p1);
Console.WriteLine(p1.Idade);

// Lista (List) // <> => Chevron
// Lista é homogênea ou heterogênea? homogênea.
List<Pessoa> povo = [];
Console.WriteLine(povo.Count); // 0
povo.Add(new Pessoa
{
    Nome = "Pedro",
    Idade = 31,
    Peso = 75,
    Altura = 1.70
});

povo.Add(p1);
povo.Add(p1);

Console.WriteLine(povo.Count);
Console.WriteLine(povo[0]); // 1ª pessoa

// para cada elemento na coleção
// for each
// for (int i = 0; i < povo.Count; i++) {
// Console.WriteLine($"Pessoa {povo[i]}");
// }
// for each pode ser realizado em qualquer
// estrutura de dados iterável/enumerável
foreach (var p in povo)
{
    Console.WriteLine($"Pessoa {p}");
}

Console.WriteLine(Saude.Imc(povo[0]));
Console.WriteLine(Saude.Imc(p1));

var resultado = Saude.Imc(new Pessoa
{
    Nome = "Marcio",
    Idade = 48,
    Peso = 80.3,
    Altura = 1.72
});

Console.WriteLine($"IMC: {resultado.Imc} SITUAÇÃO: {resultado.Situacao}");