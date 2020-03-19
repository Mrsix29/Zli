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
