using RazorEngine;
using RazorEngine.Templating;
using Spectator.Interfaces;
using System;

namespace Spectator.Razor {
    public class RazorToHTMLTransformer : ITemplateTransformer {
        public string RazorTemplate { get; set; }
        public IConfiguration Config { get; set; }

        public RazorToHTMLTransformer(string template, IConfiguration config) {
            this.RazorTemplate = template;
            this.Config = config;
        }

        public TransformerResult TransformTemplate() {
            return new TransformerResult { Result = Engine.Razor.RunCompile(RazorTemplate, string.Empty, (Type)null) };
        }

        public TransformerResult Transform() {
            return this.TransformTemplate();
        }
    }
}
