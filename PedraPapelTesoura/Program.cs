Random random = new Random();
int sys = 0;
int user = 0;
int sysWin = 0;
int userWin = 0;
int draw = 0;
string escolhaUser;
string[] escolhaSys = {"Pedra", "Papel", "Tesoura"};

do
{
    sys = random.Next(0, 3);


    Console.Write("1.Pedra\n2.Papel\n3.Tesoura\n0.Sair\nEscolha: ");
    while(!int.TryParse(Console.ReadLine(), out user) || user < 0 || user > 3){Console.Write("Número inválido! Tente novamente: ");}
    escolhaUser = user == 1 ? "Pedra" : user == 2 ? "Papel" : "Tesoura";


    Console.Write($"\nVocê escolheu: {escolhaUser}\nSistema escolheu: {escolhaSys[sys]}\nResultado: ");
    if(sys == user - 1)
    {
        Console.Write("Empate!\n\n");
        draw ++;
    }
    else if(sys == 0 && user == 3 || sys == 1 && user == 1 || sys == 2 && user == 2)
    {
        Console.Write("Sistema venceu!\n\n");
        sysWin++;
    }
    else
    {
        Console.Write("Você venceu!\n\n");
        userWin++;
    }


    Console.Write($"Resultados:\nUsuário: {userWin} vitória(s)\nSistema: {sysWin} vitória(s)\nEmpate: {draw} empate(s)\n\n");
}
while(user != 0);
