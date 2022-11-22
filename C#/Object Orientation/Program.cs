using bytebank;

CurrentAccount AccountOfMurilo = new CurrentAccount();
AccountOfMurilo.titular = "Murilo Faria";
AccountOfMurilo.numero_agencia = 15;
AccountOfMurilo.conta = "1010-X";
AccountOfMurilo.saldo = 100;

Console.WriteLine("Saldo da conta do Murilo = " + AccountOfMurilo.saldo);
