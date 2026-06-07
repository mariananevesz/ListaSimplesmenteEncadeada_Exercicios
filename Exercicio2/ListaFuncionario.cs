public class ListaFuncionario
{
    public NoFuncionario inicio;
    public NoFuncionario fim;

    public ListaFuncionario()
    {
        this.inicio = null;
        this.fim = null;
    }

    public void inserirInicio(string nome, int idade, string telefone, double salario)
    {
        NoFuncionario novoNo = new NoFuncionario(nome, idade, telefone, salario);
        if (this.inicio == null)
        {
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else
        {
            novoNo.prox = this.inicio;
            this.inicio = novoNo;
        }
    }

    
}