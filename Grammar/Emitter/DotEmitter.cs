using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilize.Grammar.Emitter
{
    using Mobilize.Grammar.Language;

    public static class DotEmitter
    {
        public static DotParser.GraphContext EmitGraph()
        {
            var graph = new DotParser.GraphContext(DotParser.GraphContext.EmptyContext, 1);
            return graph;
        }

    }
}
