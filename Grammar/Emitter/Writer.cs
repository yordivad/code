using Mobilize.Grammar.Templates;

namespace Mobilize.Grammar.Emitter
{
    public abstract class Writer
    {
        private Template template;
        
        public abstract string File { get; }

        public Template Template => template ?? (template = new Template(File));
    }
}