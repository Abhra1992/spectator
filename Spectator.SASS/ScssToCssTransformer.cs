using LibSassNet;
using Spectator.Interfaces;

namespace Spectator.SASS {
    public class ScssToCssTransformer : IStylesheetTransformer {
        public string Sass { get; set; }
        public IConfiguration Config { get; set; }

        public ScssToCssTransformer(string sass, IConfiguration config) {
            this.Sass = sass;
            this.Config = config;
        }

        public TransformerResult TransformStylesheet() {
            var sassCompiler = new SassCompiler();
            return new TransformerResult { Result = sassCompiler.Compile(this.Sass) };
        }

        public TransformerResult Transform() {
            return this.TransformStylesheet();
        }
    }
}
