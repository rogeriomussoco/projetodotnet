namespace seriesdio
{
    public class Serie: EntidadeBase
    {
      //Atributos
        private Genero genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}

        private int Ano {get; set;}

          //Métodos
    public Serie (int id, Genero genero, string titulo, string descricao, int ano)
    {
      this.Id = id;
      this.Genero =genero;
      this.Titulo=titulo;
      this.Descricao=descricao;
      this.Ano= ano;[]
    } 
    }
}