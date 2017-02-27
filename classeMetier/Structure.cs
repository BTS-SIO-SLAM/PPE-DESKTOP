using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Structure
{
    private int numStructure;

    private float distanceSiege;

    private string cpStructure;
    private string denominationSocial;
    private string adresseStructure;
    private string villeStructure;
    private string planAcces;
    private string infoSupplementaire;
	private TypeStructure leType;
	private List<Interlocuteur> lesInterlocuteur;

    public Structure()
	{

	}


    /**  setter  **/
    public void SetdenominationSociale(string unedenominationSocial)
    {
        denominationSocial = unedenominationSocial;
    }

    public void SetadresseStructure(string uneadresseStructure)
    {
        adresseStructure = uneadresseStructure;
    }

    public void SetvilleStructure(string unevilleStructure)
    {
        villeStructure = unevilleStructure;
    }

    public void SetplanAcces(string unplanAcces)
    {
        planAcces = unplanAcces;
    }

    public void SetinfoSupplementaire(string uneinfoSupplementaire)
    {
        infoSupplementaire = uneinfoSupplementaire;
    }

    public void SetcpStructure(string uncpStructure)
    {
        cpStructure = uncpStructure;
    }

    public void SetnumStructure(int unnumStructure)
    {
        numStructure = unnumStructure;
    }

    public void SetdistanceSiege(float unedistanceSiege)
    {
        distanceSiege = unedistanceSiege;
    }
	
	public void SetStructureInterlocuteur(string unInterlocuteur)
	{
		lesInterlocuteurs.Add(unInterlocuteur);	
	}

    /**  getter  **/

    public string GetdenominationSociale()
    {
        return denominationSocial;
    }

    public string GetadresseStructure()
    {
        return adresseStructure;
    }

    public string GetvilleStructure()
    {
        return villeStructure;
    }

    public string GetplanAcces()
    {
        return planAcces;
    }

    public string GetinfoSupplementaire()
    {
        return infoSupplementaire;
    }

    public string GetcpStructure()
    {
        return cpStructure;
    }

    public int GetnumStructure()
    {
        return numStructure;
    }

    public float GetdistanceSiege()
    {
        return distanceSiege;
    }


}
