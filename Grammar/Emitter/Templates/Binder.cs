using System;
using System.Collections.Generic;
using MoreLinq;

namespace Mobilize.Grammar.Templates
{
    public class Binder
    {
        private readonly Antlr4.StringTemplate.Template template;


        public Binder(Antlr4.StringTemplate.Template template)
        {
            this.template = template;
        }

        public Binder Bind<T>(string label, T value)
        {
            template.Add(label, value);
            return this;
        }

        public Binder Bind<T>(string specification, IEnumerable<T> items, Func<T, object[]> map)
        {
            items.ForEach(item => template.AddMany(specification, map));
            return this;
        }

        public string Render() => template.Render();
        
    }
}