namespace Dio.Bank
{
    public class Conta
    {
        private TipoConta tipoConta { get ; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        public Conta(TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this.tipoConta = tipoConta;
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
        }

        public bool Sacar(double valorSaque)
        {
            if(Saldo - valorSaque < (Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            Saldo -= valorSaque;

            Console.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");

            return true;
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;

            Console.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if(Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
        }
        public override string ToString()
		{
            string retorno = "";
            retorno += "TipoConta " + this.tipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
			return retorno;
		}
	}
}