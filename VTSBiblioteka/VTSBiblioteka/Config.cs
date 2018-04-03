using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VTSBiblioteka
{
    class Config
    {
        public string servername;
        public string port;
        public string username;
        public string password;
        public string db;
        public Config()
        {
            StreamReader sr = new StreamReader("config.txt");
            servername = sr.ReadLine();
            port = sr.ReadLine();
            username = sr.ReadLine();
            password = sr.ReadLine();
            db = sr.ReadLine();
            sr.Close();
        }
    }
}
