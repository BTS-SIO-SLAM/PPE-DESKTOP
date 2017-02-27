using System;

public class Particulier
{
    private int numIndividu;

    private float distanceSiege;

    private string adresseIndividu;
    private string cpIndividu;
    private string villeIndividu;
    private string planAcces;
    private string infoSupplementaire;

    public Particulier()
	{

	}
    
    /** setter **/
    public void SetadresseIndividu ( string uneadresseIndividu)
    {
        adresseIndividu = uneadresseIndividu;
    }
    public void SetcpIndividu(string uncpIndividu)
    {
        cpIndividu = uncpIndividu;
    }
    public void SetvilleIndividu(string unevilleIndividu)
    {
        villeIndividu = unevilleIndividu;
    }
    public void SetplanAcces(string unplanAcces)
    {
        planAcces = unplanAcces;
    }
    public void SetinfoSupplementaire(string uneinfoSupplementaire)
    {
        infoSupplementaire = uneinfoSupplementaire;
    }
    public void SetnumIndividu(int unnumIndividu)
    {
        numIndividu = unnumIndividu;
    }
    public void SetdistanceSiege(float unedistanceSiege)
    {
        distanceSiege = unedistanceSiege;
    }

    /** getter **/
    public string GetadresseIndividu()
    {
        return adresseIndividu;
    }
    public string GetcpIndividu()
    {
        return cpIndividu;
    }
    public string GetvilleIndividu()
    {
        return villeIndividu;
    }
    public string GetplanAcces()
    {
        return planAcces;
    }
    public string GetinfoSupplementaire()
    {
        return infoSupplementaire;
    }
    public int GetnumIndividu()
    {
        return numIndividu;
    }
    public float GetdistanceSiege()
    {
        return distanceSiege;
    }
    public bool particulierTorF()
    {
	    //renvoie true ou false quand nouvel interlocuteur est différent de vide
    }
}
