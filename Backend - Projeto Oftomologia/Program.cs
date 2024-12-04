using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("---- Bem vindo(a) a Saúde ocular ----");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(" ");

        //Criando o objeto Funcionário apartir da Struct
        Funcionarios Funcionarios = new Funcionarios();
        //Funcionarios Rogerio = new Funcionarios();
        //Funcionarios Yuri = new Funcionarios();

        Funcionarios.Nome = " ";

        //Loop de Login
        Funcionarios.LoginFuncionarios(Funcionarios.Nome);


        Console.WriteLine($"Bem vindo(a) {Funcionarios.Nome}");
        Console.WriteLine(" ");


        Console.WriteLine("ESCOLHA UMA OPÇÃO: ");
        Console.WriteLine("1 - AGENDAR UMA CONSULTA");
        Console.WriteLine("2 - CONSULTAR A AGENDA");
        byte opcao = byte.Parse(Console.ReadLine()!);

        var Consultar = new Consulta();

        if (opcao == 1)
        {
            Consultar.MarcarConsulta();
        }
        else if (opcao == 2)
        {
            Consultar.ConsultarAgenda();
        }
        else
        {
            Environment.Exit(0);
        }


    }
}

//Estrutura de Funcionaios + Função de login
public struct Funcionarios
{
    public string Nome;
    public string Senha;

    public string LoginFuncionarios(string loginNome)
    {

        int i = 0;
        do
        {
            //Criando o objeto Funcionário apartir da Struct
            Funcionarios Rogerio = new Funcionarios();
            Funcionarios Yuri = new Funcionarios();
            Funcionarios Moises = new Funcionarios();
            Funcionarios Daniel = new Funcionarios();
            Funcionarios Kelvin = new Funcionarios();

            //Indereçando o Login e a Senha dos Funcionarios
            Rogerio.Nome = "Rogerio";
            Rogerio.Senha = "123";

            Yuri.Nome = "Yuri";
            Yuri.Senha = "123";

            Moises.Nome = "Moises";
            Moises.Senha = "123";

            Daniel.Nome = "Daniel";
            Daniel.Senha = "123";

            Kelvin.Nome = "Kelvin";
            Kelvin.Senha = "123";



            Console.WriteLine("LOGIN: ");
            loginNome = Console.ReadLine()!;
            Console.WriteLine("SENHA: ");
            string loginSenha = Console.ReadLine()!;
            Console.WriteLine(" ");

            //Loop de Login
            if (loginNome == Rogerio.Nome && loginSenha == Rogerio.Senha
            || loginNome == Yuri.Nome && loginSenha == Yuri.Senha
            || loginNome == Moises.Nome && loginSenha == Moises.Senha
            || loginNome == Daniel.Nome && loginSenha == Daniel.Senha
            || loginNome == Kelvin.Nome && loginSenha == Kelvin.Senha)
            {
                Console.WriteLine("ACESSO PERMITIDO");
                Console.WriteLine(" ");
                Nome = loginNome;
                i = 4;
            }
            else
            {
                Console.WriteLine("ACESSO NEGADO");
                Console.WriteLine(" ");

                i++;
                if (i == 3)
                {
                    Console.WriteLine("ACESSO BLOQUEADO");
                    Environment.Exit(0);
                }
            }
        } while (i <= 2);

        return Nome;
    }
}

//Estrutura de Paciente
public struct Paciente
{
    public string nomePaciente;
    public string dataNascimentoPasciente;
    public string CPFPaciente;
}

//Estrutura de Consultas
public struct Consultas


{
    public string dataConsulta;
    public string horarioConsulta;

    public string nomeMedico;

}

public class Consulta
{

    Paciente Paciente1 = new Paciente();
    Consultas Consultas = new Consultas();

    public string medico1 = "Marcos";
    public string data1Medico1 = "9/12";
    public string horarioData1Medico1 = "ás 9:47";

    public string data2Medico1 = "17/12 ";
    public string horarioData2Medico1 = "ás 14:20";

    public string medico2 = "Marcos";
    public string data1Medico2 = "6/12";
    public string horarioData1Medico2 = "ás 15:15";

    public string data2Medico2 = "10/12";
    public string horarioData2Medico2 = "ás 12:00";

    public string medico3 = "Marcos";
    public string data1Medico3 = "17/12";
    public string horarioData1Medico3 = "ás 8:33";
    public string data2Medico3 = "19/12";
    public string horarioData2Medico3 = "ás 16:50";




    public void MarcarConsulta()
    {
        Console.WriteLine("NOME DO PACIENTE: ");
        Paciente1.nomePaciente = Console.ReadLine()!;
        Console.WriteLine("DATA DE NASCIMENTO: ");
        Paciente1.dataNascimentoPasciente = Console.ReadLine()!;
        Console.WriteLine("CPF: ");
        Paciente1.CPFPaciente = Console.ReadLine()!;
        Console.WriteLine("");

        Console.WriteLine("Escolha qual Médico desejado: ");
        Console.WriteLine("1 - Marcos");
        Console.WriteLine("2 - José");
        Console.WriteLine("3 - Maria");
        byte opcao1 = byte.Parse(Console.ReadLine()!);
        Console.WriteLine("");
        Console.WriteLine("Datas Disponíveis");
        Console.WriteLine("");

        switch (opcao1)
        {
            case 1:
                {
                    Consultas.nomeMedico = "Marcos";
                    Console.WriteLine($"1 - {data1Medico1} {horarioData1Medico1} ");
                    Console.WriteLine($"2 - {data2Medico1} {horarioData2Medico1}");
                    byte opcao2 = byte.Parse(Console.ReadLine()!);

                    if (opcao2 == 1)
                    {
                        Consultas.dataConsulta = data1Medico1;
                        Consultas.horarioConsulta = horarioData1Medico1;
                    }
                    else
                    {
                        Consultas.dataConsulta = data1Medico1;
                        Consultas.horarioConsulta = horarioData2Medico1;
                    }; break;
                }
            case 2:
                {
                    Consultas.nomeMedico = "José";
                    Console.WriteLine($"1 - {data1Medico2} {horarioData1Medico2}");
                    Console.WriteLine($"2 - {data2Medico2} {horarioData1Medico2}");
                    ; byte opcao2 = byte.Parse(Console.ReadLine()!);

                    if (opcao2 == 1)
                    {
                        Consultas.dataConsulta = data1Medico2;
                        Consultas.horarioConsulta = horarioData1Medico2;
                    }
                    else
                    {
                        Consultas.dataConsulta = data2Medico2;
                        Consultas.horarioConsulta = horarioData2Medico2;
                    }
                    break;
                }
            case 3:
                {
                    Consultas.nomeMedico = "Maria";
                    Console.WriteLine($"1 - {data1Medico3} {horarioData1Medico3}");
                    Console.WriteLine($"2 - {data2Medico3} {horarioData2Medico3}");
                    byte opcao2 = byte.Parse(Console.ReadLine()!);

                    if (opcao2 == 1)
                    {
                        Consultas.dataConsulta = data1Medico3;
                        Consultas.horarioConsulta = horarioData1Medico3;
                    }
                    else
                    {
                        Consultas.dataConsulta = data2Medico3;
                        Consultas.horarioConsulta = horarioData1Medico3;
                    }; break;
                }
            default: MarcarConsulta(); break;

        }
        Console.WriteLine(Consultas.dataConsulta);



        Console.WriteLine("Consulta agendada!");

        Console.WriteLine("");
        Console.WriteLine("Deseja encerrar o sistem?");
        Console.WriteLine("1 - Encerrar o sistema");
        Console.WriteLine("2 - Marcar nova consulta");
        Console.WriteLine("3 - Consultar agenda");

        byte opcao3 = byte.Parse(Console.ReadLine()!);

        if (opcao3 == 1)
        {
            Environment.Exit(0);
        }
        else if (opcao3 == 2)
        {
            MarcarConsulta();
        }
        else if (opcao3 == 3)
        {
            ConsultarAgenda();

        }
        else
        {
            Environment.Exit(0);
        }
    }


    public void ConsultarAgenda()
    {
        Console.WriteLine("Digite qual data quer pesquisar: ");
        string dataPesquisa = Console.ReadLine()!;

        if (dataPesquisa == Consultas.dataConsulta)
        {
            Console.WriteLine($"Data: {Consultas.dataConsulta} {Consultas.horarioConsulta}");
            Console.WriteLine($"Doutor(a): {Consultas.nomeMedico}");
            Console.WriteLine($"Paciente: {Paciente1.nomePaciente}");
            Console.WriteLine($"Data ne Nascimento do Paciente: {Paciente1.dataNascimentoPasciente}");
            Console.WriteLine($"CPF Paciente: {Paciente1.CPFPaciente}");

            Console.WriteLine("");
            Console.WriteLine("1 - Consultar agenda");
            Console.WriteLine("2 - Encerrar Sistema");
            byte opcao4 = byte.Parse(Console.ReadLine()!);

            if (opcao4 == 1)
            {
                ConsultarAgenda();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        else
        {
            Console.WriteLine("Nenhuma consulta agendada");
            ConsultarAgenda();
        }


    }


}



