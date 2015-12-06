using SassAndCoffee.JavaScript.CoffeeScript;
using Spectator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spectator.CoffeeScript {
    public class CoffeeScriptToJavaScriptTransformer : IScriptTransformer {
        public string CoffeeScript { get; set; }
        public IConfiguration Config { get; set; }

        public CoffeeScriptToJavaScriptTransformer(string coffee, IConfiguration config) {
            this.CoffeeScript = coffee;
            this.Config = config;
        }

        public TransformerResult TransformScript() {
            return new TransformerResult { Result = new CoffeeScriptCompiler().Compile(this.CoffeeScript, this.Config) };
        }

        public TransformerResult Transform() {
            return this.TransformScript();
        }
    }
}
