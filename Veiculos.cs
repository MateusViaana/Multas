public class Veiculos
{
    public int IdVeiculos;
    private string _NIV;
    public string _placa;
    public string _Nmotor;
    public string _Revavam;
    public int _ano;
    public string _situacao;
    public string _cor;
    public Proprietario _proprietario;
    public Modelos _modelo;
    public Cidades _cidade;
   

    public void SetVeiculo (string chassi)
    {
        try
        {
            
            if (chassi.Length == 17)
            {
                _NIV = chassi;
            }
            else
            {
                throw new Exception ("Quantidade de caracteres incorreto!");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
       

    }
}