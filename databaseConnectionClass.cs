using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

class DatabaseConnect
{
    private SqlCommand myCommand;
    private SqlDataReader myReader;
    private SqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;
    private string connectionString;

    public DatabaseConnect()
    {
        Initialize();
    }

    private void Initialize()
    {
        server = "localhost";
        database = "mabase";
        uid = "username";
        password = "mm";
        connectionString = "Data Source=" + server + ";" + "Initial Catalog=" + database + ";" + "User id=" + uid + ";" + "Password=" + password + ";";
        connection = new SqlConnection(connectionString);
    }

    public DatabaseConnect(string connectionString)
    {
        connection = new SqlConnection(connectionString);
    }

    public void SetConnection(string Aserver, string Anuid, string Apassword, string Adatabase)
    {
        server = Aserver;
        uid = Anuid;
        password = Apassword;
        database = Adatabase;
    }
    public void ConnectionLandP(string anuid, string apassword)
    {
        try
        {
            
            password = Apassword;
            uid = anuid;
            connectionString = "Data Source=" + server + ";" + "Initial Catalog=" + database + ";" + "User id=" + uid + ";" + "Password=" + password + ";";
            connection = new SqlConnection(connectionString);
            OpenConnection();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }

    public void SetConnection(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public string GetConnection()
    {
        return this.connectionString;
    }

    public string getServer()
    {
        return this.server;
    }

    public void setServer(string newServer)
    {
        this.server = newServer;
    }

    public string getDatabase()
    {
        return this.database;
    }

    public void setDatabase(string newDatabase)
    {
        this.database = newDatabase;
    }

    public string getUid()
    {
        return this.uid;
    }

    public void setUid(string newUid)
    {
        this.uid = newUid;
    }

    public string getPassword()
    {
        return this.password;
    }

    public void setPassword(string newPassword)
    {
        this.password = newPassword;
    }

    //open
    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }

    //Close
    public bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }

    //Insert
    public void Insert(string nom, string prenom, string email)
    {
        try
        {
            OpenConnection();
            SqlCommand dbCommand = new SqlCommand("INSERT INTO utilisateur VALUES(@nom,@prenom,@email)", connection);

            dbCommand.Parameters.AddWithValue("@nom", nom);
            dbCommand.Parameters.AddWithValue("@prenom", prenom);
            dbCommand.Parameters.AddWithValue("@email", email);
            dbCommand.Prepare();

            dbCommand.ExecuteNonQuery();

            CloseConnection();
        }

        catch (Exception e)
        {
            CloseConnection();
            Console.WriteLine(e.Message);
        }
    }

    //Insert without preparated statement
    public void Insert(string marequete)
    {
        try
        {
            myCommand = new SqlCommand(marequete, connection);
            OpenConnection();
            myCommand.ExecuteNonQuery();
            CloseConnection();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //Update
    public void Update(string nomOld, string nomNew)
    {
        try
        {
            OpenConnection();
            SqlCommand dbCommand = new SqlCommand("UPDATE utilisateur SET nom = '@nomNew' WHERE nom = @nomOld", connection);

            dbCommand.Parameters.AddWithValue("@nomNew", nomNew);
            dbCommand.Parameters.AddWithValue("@nomOld", nomOld);
            dbCommand.Prepare();

            dbCommand.ExecuteNonQuery();

            CloseConnection();
        }

        catch (Exception e)
        {
            CloseConnection();
            Console.WriteLine(e.Message);
        }
    }

    //Update without preparated statement
    public void Update(string marequete)
    {

        try
        {
            myCommand = new SqlCommand(marequete, connection);
            OpenConnection();
            myCommand.ExecuteNonQuery();
            CloseConnection();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //Delete
    public void Delete(string nom)
    {
        try
        {
            OpenConnection();
            SqlCommand dbCommand = new SqlCommand("DELETE FROM utilisateur WHERE nom = @nom", connection);

            dbCommand.Parameters.AddWithValue("@nom", nom);
            dbCommand.Prepare();

            dbCommand.ExecuteNonQuery();

            CloseConnection();
        }

        catch (Exception e)
        {
            CloseConnection();
            Console.WriteLine(e.Message);
        }
    }

    //Delete without preparated statement
    public void Delete(string marequete)
    {
        try
        {
            myCommand = new SqlCommand(marequete, connection);
            OpenConnection();
            myCommand.ExecuteNonQuery();
            CloseConnection();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //Select
    public SqlDataReader Select(string nom)
    {
        try
        {
            OpenConnection();
            SqlCommand dbCommand = new SqlCommand("SELECT * FROM utilisateur WHERE nom=@nom", connection);

            dbCommand.Parameters.AddWithValue("@nom", nom);
            dbCommand.Prepare();

            SqlDataReader dbReader = dbCommand.ExecuteReader();
            return dbReader;
        }

        catch (Exception e)
        {
            CloseConnection();
            Console.WriteLine(e.Message);
            return null; // ok ?
        }




    }

    //Select without preparated statement
    public DataTable Select(string marequete)
    {
        try
        {
            myCommand = new SqlCommand(marequete, connection);
            OpenConnection();
            SqlDataAdapter MyAdapter = new SqlDataAdapter();
            MyAdapter.SelectCommand = myCommand;
            DataTable dataTable = new DataTable();
            MyAdapter.Fill(dataTable);
            CloseConnection();
            return dataTable; // on retourne une datatable qu'on pourra assigner à une Datagridview.source
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    //Count
    public SqlDataReader Count(string param)
    {
        try
        {
            OpenConnection();
            SqlCommand dbCommand = new SqlCommand("SELECT COUNT() FROM utilisateur WHERE nom=@param", connection);

            dbCommand.Parameters.AddWithValue("@param", param);
            dbCommand.Prepare();

            SqlDataReader dbReader = dbCommand.ExecuteReader();
            return dbReader;
        }

        catch (Exception e)
        {
            CloseConnection();
            Console.WriteLine(e.Message);
            return null; // return null ?
        }
    }

    //Count without preparated statement
    public int Count(string marequete)
    {

        try
        {
            myCommand = new SqlCommand(marequete, connection);
            OpenConnection();
            return int.Parse(myCommand.ExecuteScalar().ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return 0; // return 0 ?
        }

    }

    public void UpdatePassword(String numUtilisateur, String newPassword)
    {

        try
        {
            OpenConnection();
            SqlCommand dbCommand = new SqlCommand("UPDATE utilisateur SET passwordUtilisateur = '@passwordUtilisateur' WHERE numUtilisateur = @numUtilisateur", connection);
            
            dbCommand.Parameters.AddWithValue("@passwordUtilisateur", newPassword);
            dbCommand.Parameters.AddWithValue("@nomOld", numUtilisateur);
            dbCommand.Prepare();

            dbCommand.ExecuteNonQuery();

            CloseConnection();
        }

        catch (Exception e)
        {
            CloseConnection();
            Console.WriteLine(e.Message);
        }   
    }
}

class program jesse  
    {   
        static void main (string[] args)
        {
        AjouterUser(Jean, Michel, mail);
        AjouterStructure(Nokia, email, téléphone);
        } 
    



         public void AjouterUser(Nom, prénom, email)
        {
        DatabaseConnect(connectionString);
        insert (Nom, prénom, email);
        }

        public void AjouterStructure(Nom,email, téléphone)
        {
        DatabaseConnect(connectionString);
        insert(Nom,email, téléphone);
        }
    }
