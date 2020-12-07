namespace POO_Heranca.classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;

        public string rg;

        public bool ValidarCpf(string cpf){
           if(cpf != ""){
                return true; 
            }
            return false;
        }
        public bool ValidarRg(string rg){
            if(rg != ""){
                return true;
            }
            return false;
        }
    }
}