using System.Collections.Generic;  
using DALtry6;  

public class UserService
{
   
    public List<string> GetAllUsernames()
    {
        //using (var db = new AppDbContext())
        //{
        //    // Querying the 'Users' table to get all usernames
        //    return db.Users.Select(u => u.Username).ToList();
        //}
        DBLayer layer = new DBLayer();
        return layer.GetUserNames();
    }

    // Can also add more methods like creating a user, logging in, etc.

    public void AddUsername(string username)
    {
        DBLayer layer = new DBLayer();
        layer.AddUsername(username);
    }


}
