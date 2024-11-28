public class ProprietariosPF:Proprietario
{
    public int _idPf;
    public string _cpf;
    public string _rg;
    public string _sexo;
    public DateOnly _dataNascimento;
 
    public void SetCPF (string cpf)
    {
        try
        {
            if (cpf.Length == 11)
            {
                _cpf = cpf;
            }
            else
            {
                throw new Exception("Quantidade de caracteres estão incorretas!");
            }
        }
        catch (Exception ex)
        {
           throw new Exception (ex.Message);
        }
    }
}
