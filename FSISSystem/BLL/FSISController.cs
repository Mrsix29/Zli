using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSISSystem.ENTITIES;
using FSISSystem.DAL;
namespace FSISSystem.BLL
{
    public class GuardianController
    {
        public Guardian Guardians_FindByID(int GuardianID)
        {
            using (var context = new FSISContext())
            {
                return context.Guardians.Find(GuardianID);
            }
        }
    }
    public class PlayerController
    {
    }
    public class TeamController
    {
    }
}
