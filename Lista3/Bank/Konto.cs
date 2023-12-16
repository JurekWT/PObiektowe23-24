namespace Bank;

public class Konto
{
    private decimal saldoPoczatkowe;
    private decimal saldoKoncowe;

    public Konto(decimal saldoPoczatkowe)
    {
        this.saldoPoczatkowe = saldoPoczatkowe;
        saldoKoncowe = saldoPoczatkowe;
    }

    public void Przelew(decimal kwota)
    {
        saldoKoncowe += kwota;
    }
}