using System;

public class TypeRDV
{
    private int idTypeRDV;

    private string typeRDV;

	public TypeRDV()
	{

	}

    /**setter**/
    public void SetidTypeRDV(int unidTypeRDV)
    {
        idTypeRDV = unidTypeRDV;
    }
    public void SettypeRDV(string untypeRDV)
    {
        typeRDV = untypeRDV;
    }

    /**getter**/
    public int GetidTypeRDV()
    {
        return idTypeRDV;
    }
    public string GettypeRDV()
    {
        return typeRDV;
    }
}
