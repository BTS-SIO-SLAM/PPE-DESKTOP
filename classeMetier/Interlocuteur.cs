using System;

public class Interlocuteur
{
    private string idInterlocuteur;
    private string nomInterlocuteur;
    private string prenomInterlocuteur;
    private string telInterlocuteur;
    private string mailInterlocuteur;
	private Structure LaStructure;

    public Interlocuteur()
	{

	}

    /** setter**/
    public void SetidInterlocuteur( string unidInterlocuteur)
    {
        idInterlocuteur = unidInterlocuteur;
    }
    public void SetnomInterlocuteur(string unnomInterlocuteur)
    {
        nomInterlocuteur = unnomInterlocuteur;
    }
    public void SetprenomInterlocuteur(string unprenomInterlocuteur)
    {
        prenomInterlocuteur = unprenomInterlocuteur;
    }
    public void SettelInterlocuteur(string untelInterlocuteur)
    {
        telInterlocuteur = untelInterlocuteur;
    }
    public void SetmailInterlocuteur(string unmailInterlocuteur)
    {
        mailInterlocuteur = unmailInterlocuteur;
    }

    /** Getter**/
    public string GetidInterlocuteur()
    {
        return idInterlocuteur;
    }
    public string GetnomInterlocuteur()
    {
        return nomInterlocuteur;
    }
    public string GetprenomInterlocuteur()
    {
        return GetnomInterlocuteur;
    }
    public string GettelInterlocuteur()
    {
        return telInterlocuteur;
    }
    public string GetmailInterlocuteur()
    {
        return mailInterlocuteur;
    }
}
