//try
//{
//    Veiculos v = new Veiculos();
//    Console.WriteLine("Digite o chassi:");
//     string chassi = Console.ReadLine();
//    v.SetVeiculo(chassi);

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

try
{
    ProprietariosPF p = new ProprietariosPF();
    Console.WriteLine("Digite o cpf:");
    string cpf = Console.ReadLine();
    p.SetCPF(cpf);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}