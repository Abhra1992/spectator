using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suave;

namespace Spectator.Server {
    public class Server {
        public static void Main(string[] args) {
            Suave.Web.startWebServer(Suave.Web.defaultConfig, Suave.Http.Successful.OK("Hello World"));
        }
    }
}
