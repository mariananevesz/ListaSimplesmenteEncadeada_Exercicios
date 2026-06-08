public class ListaDisciplina
{
    public NoDisciplina inicio;
    public NoDisciplina fim;

    public ListaDisciplina()
    {
        this.inicio = null;
        this.fim = null;
    }

    public void inserirOrdenado(string nome, int periodo, int cargaHoraria, string professorResponsavel)
    {
        NoDisciplina novoNo = new NoDisciplina(nome, periodo, cargaHoraria, professorResponsavel);

        if (this.inicio == null)
        {
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else if (string.Compare(nome, this.inicio.nome) < 0)
        {
            novoNo.prox = this.inicio;
            this.inicio = novoNo;
        }
        else
        {
            NoDisciplina atual = this.inicio;

            while (atual.prox != null && string.Compare(nome, atual.prox.nome) > 0)
            {
                atual = atual.prox;
            }

            novoNo.prox = atual.prox;
            atual.prox = novoNo;

            if (novoNo.prox == null)
            {
                this.fim = novoNo;
            }
        }

        Console.WriteLine("Disciplina inserida com sucesso!");
    }

    public bool buscarPorNome(string nome)
    {
        NoDisciplina atual = this.inicio;

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

    public void removerPorNome(string nome)
    {
        if (this.inicio == null)
        {
            Console.WriteLine("Lista vazia!");
        }
        else if (this.inicio.nome == nome)
        {
            this.inicio = this.inicio.prox;

            if (this.inicio == null)
            {
                this.fim = null;
            }

            Console.WriteLine("Disciplina removida com sucesso!");
        }
        else
        {
            NoDisciplina atual = this.inicio;

            while (atual.prox != null && atual.prox.nome != nome)
            {
                atual = atual.prox;
            }

            if (atual.prox == null)
            {
                Console.WriteLine("Disciplina não encontrada.");
            }
            else
            {
                atual.prox = atual.prox.prox;

                if (atual.prox == null)
                {
                    this.fim = atual;
                }

                Console.WriteLine("Disciplina removida com sucesso!");
            }
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
            NoDisciplina atual = this.inicio;

            while (atual != null)
            {
                Console.Write(atual.nome + ", " + atual.periodo + ", " + atual.cargaHoraria + ", " + atual.professorResponsavel + " -> ");
                atual = atual.prox;
            }

            Console.WriteLine("NULL");
        }
    }
}