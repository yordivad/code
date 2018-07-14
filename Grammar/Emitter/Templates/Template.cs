using System.IO;
using Antlr4.StringTemplate;

namespace Mobilize.Grammar.Templates
{
    public class Template
    {
        private readonly TemplateGroup group;

        public Template(string name)
        {
            Name = name;
            group = new TemplateGroupFile($"{Directory.GetCurrentDirectory()}/{Name}");
        }

        public string Name { get; }

        public Binder Bind(string specification)
        {
            var template = group.GetInstanceOf(specification);
            return new Binder(template);
        }
    }
}