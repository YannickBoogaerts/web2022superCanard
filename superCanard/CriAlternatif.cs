// See https://aka.ms/new-console-template for more information
using superCanard;

public class CriAlternatif : ComportementCancan
{
    private bool flag;

    public CriAlternatif(ComportementCancan cancan, ComportementCancan coincoin)
    {
        Cri1 = cancan;
        Cri2 = coincoin;
    }

    public ComportementCancan Cri1 { get; }
    public ComportementCancan Cri2 { get; }

    public void Cancanner()
    {
        if (flag)
        {
            Cri1.Cancanner();
        }
        else
        {
            Cri2.Cancanner();
        }
        flag = ! flag;
    }
}