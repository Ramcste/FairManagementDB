using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{

    
    class VisitorManager
    {
       ZoneGateway zoneGateway=new ZoneGateway();

       VisitorGateway visitorGateway=new VisitorGateway();

        

       public string Save(Visitor visitor)
       {
           if (visitor.Name == string.Empty) 
           {
               return "Please Enter Visitor Name";
           }

           else if (visitor.Email == string.Empty)
           {
               return "Please Enter Visitor Email";
           }

           else if (visitor.ContactNo == string.Empty)
           {
               return "Please Enter Visitor Contact Number";
           }

           else if(visitorGateway.IsThisEmailExists(visitor.Email))
           {
           return "This Email Id already Exists.Try Again!!";
           }

           else 
           {
               int value = visitorGateway.Save(visitor);

               if (value > 0)
               {
                 


                   return "Visitor Information Saved Successfully";


               }

               else 
               {
                   return "Save Operation Failed";
               }
           }

       
       }

        public List<Zone> GetAllZones()
        {
            return zoneGateway.GetZones();
            
        }



        public void GetCheckBox(List<string> checkboxList)
        {
            visitorGateway.GetCheckBoxes(checkboxList);
            
        }


        public List<Visitor> GetAllVisitorListByZoneTypeName(string name)
        {
            return visitorGateway.GetVisitorsList(name);
        } 
    }
}
