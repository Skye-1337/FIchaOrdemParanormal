using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIchaOrdemParanormal
{
    public static class Database
    {
        public static void Connect()
        {

            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://MASTER:Ficha_Ordem_MASTER@fichaordemparanormal.ezpfs2p.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("FichaOrdemParanormal");

        }
        public static void Disconnect()
        {

        }

    }
}
