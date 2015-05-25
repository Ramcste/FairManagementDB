using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{

    
    class VisitorManager
    {
       ZoneGateway zoneGateway=new ZoneGateway();

       VisitorGateway visitorGateway=new VisitorGateway();


        public List<Zone> GetAllZones()
        {
            return zoneGateway.GetZones();
            
        }
    }
}
