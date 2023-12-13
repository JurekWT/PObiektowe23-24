namespace Zadanie_6_10;

public struct KandydatNaStudia
{
    public string nazwisko;
    public double punktyMatematyka;
    public double punktyInformatyka;
    public double punktyJezykObcy;

    public KandydatNaStudia(string nazw, double matematyka, double informatyka, double jobcy)
    {
        this.nazwisko = nazw;
        this.punktyMatematyka = matematyka;
        this.punktyInformatyka = informatyka;
        this.punktyJezykObcy = jobcy;
    }

    public double LacznePunkty()
    {
        return (0.6 * punktyMatematyka) + (0.5 * punktyInformatyka) + (0.2 * punktyJezykObcy);
    }
}