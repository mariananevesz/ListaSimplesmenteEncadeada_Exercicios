public class NoFuncionario
{
    public string nome;
    public int idade;
    public string telefone;
    public double salario;
    public NoFuncionario prox;

    public NoFuncionario(string nome, int idade, string telefone, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.telefone = telefone;
        this.salario = salario;
        this.prox = null;
    }
}