using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FSISSystem.ENTITIES;
using FSISSystem.BLL;

namespace WebAppFSIS.ExercisePages
{
    public partial class ExerciseHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Player player = new Player();
            PlayerController playerController = new PlayerController();
            player = playerController.Players_FindByID(131);

            SIN.Text = player.PlayerID.ToString();
            Name.Text = player.FirstName.ToString() + " " + player.LastName.ToString();
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            int a = 000;
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            int a = 000;
        }
    }


}