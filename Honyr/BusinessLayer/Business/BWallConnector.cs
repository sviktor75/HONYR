using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Operations;

namespace BusinessLayer.Business
{
    public class BWallConnector
    {
        OWallConnector wcOP = new OWallConnector();

        public int AddConnector(string connectorid, string name, string type, string property, int locationid, int symbolId, string description)
        {
            return wcOP.AddConnector(connectorid, name, type, property, locationid, symbolId, description);
        }

        public int ModConnector(long id, string connectorid, string name, string type, string property, int locationid, int symbolId, string description)
        {
            return wcOP.ModConnector(id, connectorid, name, type, property, locationid, symbolId, description);
        }

        public int DelConnector(long id)
        {
            return wcOP.DelConnector(id);
        }

        public List<String> GetConnecctor()
        {
            return wcOP.GetConnector();
        }

        public List<String> GetConnectorByName(string name)
        {
            return wcOP.GetConnectorByName(name);
        }
    }
}
