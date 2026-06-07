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

    public void inserirFim(string nome, int idade, string telefone, double salario)
    {
        NoFuncionario novoNo = new NoFuncionario(nome, idade, telefone, salario);
        if (this.inicio == null)
        {
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else
        {
            this.fim.prox = novoNo;
            this.fim = novoNo;
        }
    }

    public bool buscarporNome(string nome)
    {
        NoFuncionario atual = this.inicio;
        while (atual != null)
        {
            if (atual.nome == nome)
            {
                return true;
            }
          atual = atual.prox;  
        }
        return false;
    }

}