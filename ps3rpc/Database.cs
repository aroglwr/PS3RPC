using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections;
using System.Media;
using Microsoft.VisualBasic;

namespace ps3rpc
{
    class Database
    {
        System.Collections.Generic.Dictionary<string, object> db = default!;
        
        public void LoadDB()
        {
            var json = File.ReadAllText(@"./assets/db.json");
            var result = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            if (result != null)
            {
                this.db = result;
            }
            

        }

        public DBGame SearchDB(string id)
        {
            DBGame details = new();

            
            if (this.db.ContainsKey(id))
            {
                var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(db[id].ToString()!);
                details.name = result!["name"];
                
                details.region = result["region"];
                details.type = result["type"];
                details.year = result["year"];
                details.developer = result["developer"];
                details.publisher = result["publisher"];
                details.cover = result["cover"];
                details.thumb = result["thumb"];
            }
            
            //DBGame game = new DBGame();
            
            return details;
        }

        public class DBGame
        {
            public string name = default!;
            public string region = default!;
            public string type = default!;
            public string year = default!;
            public string developer = default!;
            public string publisher = default!;
            public string cover = default!;
            public string thumb = default!;
        }
        
        
        
    }
}
