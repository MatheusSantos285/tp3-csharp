namespace MatriculaDeFaculdade
{
    public class Matricula
    { 
        public string NomeDoAluno { get; set; }
        public string Curso { get; set; }
        public int NumeroMatricula { get; set; }
        public string Situacao { get; set; }
        public string DataInicial { get; set; }

        public Matricula(string nomeDoAluno, string curso, int numeroMatricula, string situacao, string dataInicial)
        {
            this.NomeDoAluno = nomeDoAluno;
            this.Curso = curso;
            this.NumeroMatricula = numeroMatricula;
            this.Situacao = situacao;
            this.DataInicial = dataInicial;
        }

        public void Trancar()
        {
            Situacao = "Trancada";
        }

        public void Reativar()
        {
            Situacao = "Ativa";
        }

        public string ExibirInformacoes()
        {
            return $"Nome do aluno: {NomeDoAluno}\n" +
                   $"Curso: {Curso}\n" +
                   $"Situação: {Situacao}\n" +
                   $"Data inicial: {DataInicial}";
        }
    }
}
