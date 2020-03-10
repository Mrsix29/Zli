using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSISSystem.ENTITIES;
using FSISSystem.DAL;
using System.Threading;

namespace FSISSystem.BLL
{
    
    public class GuardianController
    {
        public Guardian Guardians_FindByID(int guardianID)
        {
            using (var context = new FSISContext())
            {
                return context.Guardians.Find(guardianID);
            }
        }

    }
    public class PlayerController
    {
        public Player Players_FindByID(int playerID)
        {
            using (var context = new FSISContext())
            {
                return context.Players.Find(playerID);
                int a = 0;
            }
        }
    }
    public class TeamController
    {
        public Team Teams_FindByID(int teamID)
        {
            using (var context = new FSISContext())
            {
                return context.Teams.Find(teamID);
            }
        }
    }
}
