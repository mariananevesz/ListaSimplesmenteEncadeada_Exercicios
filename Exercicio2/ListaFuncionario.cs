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

    public void removerInicio()
    {
        if (this.inicio == null)
        {
            Console.WriteLine("Lista vazia!");
        }
        else if (this.inicio == this.fim)
        {
            this.inicio = null;
            this.fim = null;
        }
        else
        {
            this.inicio = this.inicio.prox;
        }
    }

    public void removerFim()
    {
        if (this.inicio == null)
        {
            Console.WriteLine("Lista vazia!");
        }
        else if (this.inicio == this.fim)
        {
            this.inicio = null;
            this.fim = null;
        }
        else{
            NoFuncionario atual = this.inicio;
            while (atual.prox != this.fim)
            {
                atual = atual.prox;
            }
            atual.prox = null;
            this.fim = atual;
        }
    }

    public void imprimir()
    {
        if (this.inicio == null)
        {
            Console.WriteLine("Lista vazia!");
        }
        else
        {
            NoFuncionario atual = this.inicio;
            while (atual != null)
            {
                Console.Write(atual.nome + ", " + atual.idade + ", " + atual.telefone + ", " + atual.salario + " -> ");
                atual = atual.prox;
            }
            Console.WriteLine("NULL");
        }
    }
}