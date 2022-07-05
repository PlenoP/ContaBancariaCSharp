using System;
namespace meuPrimeiroPrograma // Nome do local que irei editar as infos

{
            class Program // Classe
            {
                static void Main(string[] args)     // idk
                {
                    ContaCorrente conta_do_kaka = new ContaCorrente( "Guilherme", 7777, 6666, 400 ); // Utiliza a variável da Conta Corrente para colocar infos em cima dela, separadamente.
                    ContaCorrente conta_02 = new ContaCorrente( "Zero2", 5555, 4444, 600 );
                    ContaCorrente conta_03 = new ContaCorrente( "Zero3", 1111, 2222, 1500 );


                    Console.WriteLine("A conta é do (a): " + conta_do_kaka.Titular + 
                                      ", a agência é: " + conta_do_kaka.Agencia +
                                      ", o número é: " + conta_do_kaka.Numero + 
                                      " e o Saldo é de: " + conta_do_kaka.Saldo + 
                                      " reais ");

                                      Console.WriteLine("A conta é do (a): " + conta_02.Titular + 
                                      ", a agência é: " + conta_02.Agencia +
                                      ", o número é: " + conta_02.Numero + 
                                      " e o Saldo é de: " + conta_02.Saldo + 
                                      " reais ");

                                      Console.WriteLine("A conta é do (a): " + conta_03.Titular + 
                                      ", a agência é: " + conta_03.Agencia +
                                      ", o número é: " + conta_03.Numero + 
                                      " e o Saldo é de: " + conta_03.Saldo +
                                      " reais ");


                    bool sacar_conta1 = conta_do_kaka.Sacar(100);
                    bool sacar_conta2 = conta_02.Sacar(100);
                    bool sacar_conta3 = conta_03.Sacar(100);


Console.WriteLine( "                 " +
                   "Saque Concluído: " );


Console.WriteLine(
                                    "A conta é do (a): " + conta_do_kaka.Titular + 
                                      ", a agência é: " + conta_do_kaka.Agencia +
                                      ", o número é: " + conta_do_kaka.Numero + 
                                      " e o Saldo é de: " + conta_do_kaka.Saldo + 
                                      " reais ");

                                      Console.WriteLine("A conta é do (a): " + conta_02.Titular + 
                                      ", a agência é: " + conta_02.Agencia +
                                      ", o número é: " + conta_02.Numero + 
                                      " e o Saldo é de: " + conta_02.Saldo + 
                                      " reais ");

                                      Console.WriteLine("A conta é do (a): " + conta_03.Titular + 
                                      ", a agência é: " + conta_03.Agencia +
                                      ", o número é: " + conta_03.Numero + 
                                      " e o Saldo é de: " + conta_03.Saldo +
                                      " reais ");


                }

            }
}