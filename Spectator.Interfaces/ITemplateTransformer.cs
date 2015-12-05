using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spectator.Interfaces {
    public interface ITemplateTransformer : ITransformer {
        TransformerResult TransformTemplate();
    }
}
