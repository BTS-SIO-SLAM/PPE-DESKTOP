using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

class DataBaseConnect
{
    private SqlCommand myCommand;
    private SqlDataReader myReader;
    private SqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;
    private string connectionString;

    //Constructeur
    public DataBaseConnect()
    {
        Initialize();
    }
    //Initialisation des paramètres de connexion
    private void Initialize()
{
        server = "localhost";
        database = "mabase"
        uid = "username";
        password = "mm";
        connectionString = "Data Source="+server+ ";" +"Initial Catalog="+database+";" +"User id="+uid+";" +"Password="+password+";";   
        connection = new SqlConnection(connectionString);
}

    public string getServer() 
    {
        return this.server;
    }

    public void setServer(string newServer)
    {
         this.server= newServer;
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
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }

    }
    //Close
    private bool CloseConnection()
    {

        try
        {
            connection.Close();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }

    }
    //Insert
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
}
