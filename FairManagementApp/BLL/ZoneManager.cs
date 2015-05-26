using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{
    class ZoneManager
    {
        ZoneGateway zoneGateway=new ZoneGateway();


        public string Save(Zone zone)
        {
            int totalzonetype = zoneGateway.GetCountZoneType();

            if (zone.TypeName == string.Empty)
            {
                return "Zone Name is missing";
            }

            else if (totalzonetype < 9)
            {
                return "We can't create more than 8 Zone";
            }

            else
            {
                int value = zoneGateway.Save(zone);

                if (value > 0)
                {
                    return "Save Successfully";
                }
                else
                {
                    return "Save Failed";
                }
            }

        }


        public List<Zone> GetAllZones()
        {
            return zoneGateway.GetZones();

        }

        public int GetTotalNoOfVisitors()
        {
            return zoneGateway.GetTotalVisitors();
        }
        
    }
}
