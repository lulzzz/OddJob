//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.FSharp.Core;
using WebSharper;
using WebSharper.UI;
using WebSharper.UI.Templating;
using SDoc = WebSharper.UI.Doc;
using DomElement = WebSharper.JavaScript.Dom.Element;
using DomEvent = WebSharper.JavaScript.Dom.Event;
namespace GlutenFree.OddJob.Manager.Presentation.WS.Template
{
    [JavaScript]
    public class Jobparameter
    {
        string key = System.Guid.NewGuid().ToString();
        List<TemplateHole> holes = new List<TemplateHole>();
        Instance instance;
        public struct Vars
        {
            public Vars(Instance i) { instance = i; }
            readonly Instance instance;
        }
        public class Instance : WebSharper.UI.Templating.Runtime.Server.TemplateInstance
        {
            public Instance(WebSharper.UI.Templating.Runtime.Server.CompletedHoles v, Doc d) : base(v, d) { }
            public Vars Vars => new Vars(this);
        }
        public Instance Create() {
            var completed = WebSharper.UI.Templating.Runtime.Server.Handler.CompleteHoles(key, holes, new Tuple<string, WebSharper.UI.Templating.Runtime.Server.ValTy>[] {  });
            var doc = WebSharper.UI.Templating.Runtime.Server.Runtime.GetOrLoadTemplate("jobparameter", null, FSharpOption<string>.Some("JobParameter.html"), "<!-- ClientLoad = Inline -->\r\n", null, completed.Item1, null, ServerLoad.WhenChanged, new Tuple<string, FSharpOption<string>, string>[] {  }, null, false, false, false);
            instance = new Instance(completed.Item2, doc);
            return instance;
        }
        public Doc Doc() => Create().Doc;
        public class JobParameter
        {
            string key = System.Guid.NewGuid().ToString();
            List<TemplateHole> holes = new List<TemplateHole>();
            Instance instance;
            public JobParameter Ordinal(string x) { holes.Add(TemplateHole.NewText("ordinal", x)); return this; }
            public JobParameter Ordinal(View<string> x) { holes.Add(TemplateHole.NewTextView("ordinal", x)); return this; }
            public JobParameter Name(string x) { holes.Add(TemplateHole.NewText("name", x)); return this; }
            public JobParameter Name(View<string> x) { holes.Add(TemplateHole.NewTextView("name", x)); return this; }
            public JobParameter Type(string x) { holes.Add(TemplateHole.NewText("type", x)); return this; }
            public JobParameter Type(View<string> x) { holes.Add(TemplateHole.NewTextView("type", x)); return this; }
            public JobParameter Value(string x) { holes.Add(TemplateHole.NewText("value", x)); return this; }
            public JobParameter Value(View<string> x) { holes.Add(TemplateHole.NewTextView("value", x)); return this; }
            public struct Vars
            {
                public Vars(Instance i) { instance = i; }
                readonly Instance instance;
            }
            public class Instance : WebSharper.UI.Templating.Runtime.Server.TemplateInstance
            {
                public Instance(WebSharper.UI.Templating.Runtime.Server.CompletedHoles v, Doc d) : base(v, d) { }
                public Vars Vars => new Vars(this);
            }
            public Instance Create() {
                var completed = WebSharper.UI.Templating.Runtime.Server.Handler.CompleteHoles(key, holes, new Tuple<string, WebSharper.UI.Templating.Runtime.Server.ValTy>[] {  });
                var doc = WebSharper.UI.Templating.Runtime.Server.Runtime.GetOrLoadTemplate("jobparameter", FSharpOption<string>.Some("jobparameter"), FSharpOption<string>.Some("JobParameter.html"), "<div class=\"jobparameter\" ,=\"\" style=\"margin-left: 5%\">\r\n        <div>Ordinal : <input readonly=\"readonly\" value=\"${Ordinal}\"> </div> \r\n        <div>Name: <input value=\"${Name}\" readonly=\"readonly\"> </div> \r\n        <div>Type: <input value=\"${Type}\" readonly=\"readonly\"> </div> \r\n        <div>Value: <input value=\"${Value}\" readonly=\"readonly\"></div>\r\n</div>", null, completed.Item1, null, ServerLoad.WhenChanged, new Tuple<string, FSharpOption<string>, string>[] {  }, null, true, false, false);
                instance = new Instance(completed.Item2, doc);
                return instance;
            }
            public Doc Doc() => Create().Doc;
            [Inline] public Elt Elt() => (Elt)Doc();
        }
    }
}