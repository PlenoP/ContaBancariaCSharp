public class ContaCorrente //classe
{
    public string Titular; //objetos
    public int Agencia;
    public int Numero;
    public double Saldo;


     public ContaCorrente (string Titular, int Agencia, int Numero, double Saldo) //construtor
     {
         this.Titular = Titular;
         this.Agencia = Agencia;
         this.Numero = Numero;
         this.Saldo = Saldo;

     }

    public bool Sacar (double valorSaque) { //método
        if (this.Saldo >= valorSaque){
            this.Saldo = this.Saldo - valorSaque;
            return true;
    }
            return false;
    }

}