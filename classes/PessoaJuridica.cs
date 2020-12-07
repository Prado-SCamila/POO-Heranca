namespace POO_Heranca.classes
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;

        public string inscricaoEstadual;

        public bool ValidarCNPJ(string cnpj){
            if(cnpj != ""){
                return true;
            }
            return false;
        }
        public bool ValidarInscricao(string inscricaoEstadual){
            if(inscricaoEstadual != ""){
                return true;
            }
            return false;
        }
    }
}
