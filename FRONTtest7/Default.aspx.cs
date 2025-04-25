using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using DALtry6;
namespace FRONTtest7
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text.Trim();

            if (!string.IsNullOrEmpty(newUsername))
            {
                UserService userService = new UserService();
                userService.AddUsername(newUsername);

                lblUsernames.Text = $"Added: {newUsername}";

                // Used to refresh the table
                var usernames = userService.GetAllUsernames();
                GridViewUsers.DataSource = usernames;
                GridViewUsers.DataBind();
            }
            else
            {
                lblUsernames.Text = "Please enter a username.";
            }
        }

        
        protected void btnFetchUsers_Click(object sender, EventArgs e)
        {
            // Creates an instance of UserService from BUStry6 layer
            UserService userService = new UserService();

            var usernames = userService.GetAllUsernames();

            //// Log the usernames for debugging in vsc output window.
            System.Diagnostics.Debug.WriteLine("Usernames fetched: " + string.Join(", ", usernames));

            // Display the usernames in the label
            //lblUsernames.Text = string.Join(", ", usernames);  // Update the label with the usernames, could be useful to know
            GridViewUsers.DataSource = usernames;
            GridViewUsers.DataBind();
        }
        protected void btnRemoveUsers_Click(object sender, EventArgs e)
        {
            GridViewUsers.DataSource = null;
            GridViewUsers.DataBind();
            lblUsernames.Text = "User list has been cleared.";
        }


    }
}
