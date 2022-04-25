namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        
        private Genero _genero;
        private string _titulo;
        private string _descricao;
        private int _ano;
        private bool _excluido;

        public Serie(Genero genero, string titulo, string descricao, int ano, int id) : base(id)
        {
            _genero = genero;
            _titulo = titulo;
            _descricao = descricao;
            _ano = ano;
            _excluido = false;
        }

        public override string ToString()
        {
            string enter = Environment.NewLine;
            string retorno = "";
            retorno += "Gênero: " + _genero + enter;
            retorno += "Titulo: " + _titulo + enter;
            retorno += "Descrição: " + _descricao + enter;
            retorno += "Ano: " + _ano + enter;
            retorno += "Excluído: " + _excluido;
            return retorno;
        }

        public string retornaTitulo(){
            return _titulo;
        }

        public int retornaId(){
            return _id;
        }

        public bool retornaExcluido(){
            return _excluido;
        }

        public void Excluir(){
            _excluido = true;
        }


    }


}