using _06_ByteBank;

class ContaCorrente
{

    public _06_ByteBank.Cliente titular;
    public int agencia;
    public int numero;
    private double saldo = 100;

    public void SetSaldo (double saldo)
    {
        if (saldo < 0)
        {
            return;
        }
        else
        {   
            this.saldo = saldo;
            
        }
    }

    public double GetSaldo ()
    {
        return saldo;
    }

    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
            
    }
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    public bool Transferir (double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
   
}