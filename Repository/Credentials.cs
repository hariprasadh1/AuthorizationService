using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationService.Repository
{
    public class Credentials: ICredentials
    {
        private Dictionary<string,string> ValidUsersDictionary = new Dictionary<string, string>()
        {
               {"1","Hariprasadh"},
               {"2","Charulatha"},
               {"3","Anjali"},
               {"4","Aishwarya"}
        };
        public Dictionary<string,string> GetCredentials()
        {
            return ValidUsersDictionary;
        }
    }
}
