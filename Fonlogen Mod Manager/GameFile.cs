using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonlogen_Mod_Manager
{
    class GameFile
    {
        string id = "";
        string path = "";
        string name = "";
        string ext = "";

        public GameFile(string id, string path, string name, string ext){
            this.id = id;
            this.path = path;
            this.name = name;
            this.ext = ext;
        }

        public GameFile()
        {

        }
    }
}
