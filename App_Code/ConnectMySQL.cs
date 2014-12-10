using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for ConnectMySQL
/// </summary>
public class ConnectMySQL
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;
	public ConnectMySQL()
	{
		//
		// TODO: Add constructor logic here
		//
        Initialize();
	}

    private void Initialize(){
        server = "123.30.238.206";
        database = "shop09";
        uid = "shopweb";
        password = "23654789";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        connection = new MySqlConnection(connectionString);
    }

    private bool openConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex) {
           return false;
        }
    }

    private bool closeConnection()
    {
        try{
        connection.Close();
         return true;
        }catch(MySqlException ex)
        {
            return false;
        }
    }

    public void insertCategory( string cate_name, int order, int parent, string url){
        string query = "INSERT INTO shop.category (cate_name,order1,parent,url) VALUES (@cate_name,@order,@parent,@url)";
      //  string query = "INSERT INTO shop.category (id,cate_name,order,parent,url) VALUES ('3','dasdas','2','0','dasdasdsa')";
        if(this.openConnection()==true){
            
        MySqlCommand cmd = new MySqlCommand(query,connection);
        cmd.Parameters.Add("@cate_name", MySqlDbType.VarChar).Value =cate_name;
        cmd.Parameters.Add("@order", MySqlDbType.Int32).Value = order;
        cmd.Parameters.Add("@parent", MySqlDbType.Int32).Value = parent;
        cmd.Parameters.Add("@url", MySqlDbType.VarChar).Value = url;
                try{
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    this.closeConnection();
                }
            this.closeConnection();
        }
    }

    public bool checkMatchCategory(string cate_name)
    {
        string query = "SELECT * FROM shop.category WHERE parent = @cate_name";
      
        if (this.openConnection() == true)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.Add("@cate_name", MySqlDbType.VarChar).Value = cate_name;
            try
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
               // MySqlDataReader dataReader = cmd.ExecuteReader();
                if (count>0)
                {
                    this.closeConnection();
                    return false;
                }
                else
                {
                    this.closeConnection();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                this.closeConnection();

            }
        } return false;
    }

    public Dictionary<string, int> selectParentCategory()
    {

        string query = "SELECT * FROM shop.category WHERE cate_name = 0";
        Dictionary<string, int> test = new Dictionary<string, int>();
       
        test.Add("Default", 0);
        if (this.openConnection() == true)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string name = dataReader["cate_name"].ToString();
                int value = Int32.Parse(dataReader["id"].ToString());
                test.Add(name, value);
            }
        }
        this.closeConnection();
        return test;
    }
}