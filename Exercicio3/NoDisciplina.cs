public class NoDisciplina
{
    public string nome;
    public string periodo;
    public int cargaHoraria;
    public string professorResponsavel;
    public NoDisciplina prox;
    public NoDisciplina(string nome, string periodo, int cargaHoraria, string professorResponsavel)
    {
        this.nome = nome;
        this.periodo = periodo;
        this.cargaHoraria = cargaHoraria;
        this.professorResponsavel = professorResponsavel;
        this.prox = null;
    }
}