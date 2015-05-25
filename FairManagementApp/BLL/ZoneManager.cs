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
            if (zone.TypeName == string.Empty)
            {
                return "Zone Name is missing";
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
    }
}
