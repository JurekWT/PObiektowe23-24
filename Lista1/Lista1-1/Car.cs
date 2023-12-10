namespace Lista1;

public class Car
{
    public string Marka { get; private set; }
    public int Rok { get; private set; }
    private string model;
    private int iloscDrzwi;
    private int pojemnoscSilnika;
    public double srednieSpalanie;
    
    public Car(string marka, int rokProdukcji)
    {
        if (rokProdukcji < 1769 )
        {
            this.Rok = 1769;
        }

        else if (rokProdukcji > 2017)
        {
            this.Rok = 2017;
        }
        else
        {
            this.Rok = rokProdukcji;
        }
        this.Marka = marka;
    }

    private double ObliczSpalanie(double dlugoscTrasy)
    {
        return srednieSpalanie * dlugoscTrasy;
    }

    public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
    {
        return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
    }
}