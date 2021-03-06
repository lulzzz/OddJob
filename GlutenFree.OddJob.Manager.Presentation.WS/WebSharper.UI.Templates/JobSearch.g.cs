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
    public class Jobsearch
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
            var doc = WebSharper.UI.Templating.Runtime.Server.Runtime.GetOrLoadTemplate("jobsearch", null, FSharpOption<string>.Some("JobSearch.html"), "<html lang=\"en\">\r\n<body>\r\n    <div style=\"width: 400px\">\r\n        <h1>My TODO list</h1>\r\n        <div id=\"search\"></div>\r\n        <div style=\"display: none\"></div>\r\n    </div>\r\n</body>\r\n</html>", null, completed.Item1, null, ServerLoad.WhenChanged, new Tuple<string, FSharpOption<string>, string>[] {  }, null, true, false, false);
            instance = new Instance(completed.Item2, doc);
            return instance;
        }
        public Doc Doc() => Create().Doc;
        [Inline] public Elt Elt() => (Elt)Doc();
        public class ListItem
        {
            string key = System.Guid.NewGuid().ToString();
            List<TemplateHole> holes = new List<TemplateHole>();
            Instance instance;
            public ListItem ShowDone(Attr x) { holes.Add(TemplateHole.NewAttribute("showdone", x)); return this; }
            public ListItem ShowDone(IEnumerable<Attr> x) { holes.Add(TemplateHole.NewAttribute("showdone", Attr.Concat(x))); return this; }
            public ListItem ShowDone(params Attr[] x) { holes.Add(TemplateHole.NewAttribute("showdone", Attr.Concat(x))); return this; }
            public ListItem Job(string x) { holes.Add(TemplateHole.NewText("job", x)); return this; }
            public ListItem Job(View<string> x) { holes.Add(TemplateHole.NewTextView("job", x)); return this; }
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
                var doc = WebSharper.UI.Templating.Runtime.Server.Runtime.GetOrLoadTemplate("jobsearch", FSharpOption<string>.Some("listitem"), FSharpOption<string>.Some("JobSearch.html"), "<li>\r\n                    <div class=\"checkbox\">\r\n                        <label ws-attr=\"ShowDone\">\r\n                            <!--<input type=\"checkbox\" ws-var=\"Done\" />-->\r\n                            ${Job}\r\n                            <!--<button class=\"btn btn-danger btn-xs pull-right\" type=\"button\" ws-onclick=\"Clear\">X</button>-->\r\n                        </label>\r\n                    </div>\r\n                </li>", null, completed.Item1, null, ServerLoad.WhenChanged, new Tuple<string, FSharpOption<string>, string>[] {  }, null, true, false, false);
                instance = new Instance(completed.Item2, doc);
                return instance;
            }
            public Doc Doc() => Create().Doc;
            [Inline] public Elt Elt() => (Elt)Doc();
        }
        public class Main
        {
            string key = System.Guid.NewGuid().ToString();
            List<TemplateHole> holes = new List<TemplateHole>();
            Instance instance;
            public Main ListContainer(Doc x) { holes.Add(TemplateHole.NewElt("listcontainer", x)); return this; }
            public Main ListContainer(IEnumerable<Doc> x) { holes.Add(TemplateHole.NewElt("listcontainer", SDoc.Concat(x))); return this; }
            public Main ListContainer(params Doc[] x) { holes.Add(TemplateHole.NewElt("listcontainer", SDoc.Concat(x))); return this; }
            public Main ListContainer(string x) { holes.Add(TemplateHole.NewText("listcontainer", x)); return this; }
            public Main ListContainer(View<string> x) { holes.Add(TemplateHole.NewTextView("listcontainer", x)); return this; }
            public Main SearchQueueName(Var<string> x) { holes.Add(TemplateHole.NewVarStr("searchqueuename", x)); return this; }
            public Main SearchMethodName(Var<string> x) { holes.Add(TemplateHole.NewVarStr("searchmethodname", x)); return this; }
            public Main Search(Action<DomElement, WebSharper.JavaScript.Dom.MouseEvent> x) { holes.Add(TemplateHole.NewActionEvent("search", x)); return this; }
            public Main Search(Action x) { holes.Add(TemplateHole.NewEvent("search", FSharpConvert.Fun<DomElement, DomEvent>((a,b) => x()))); return this; }
            public Main Search(Action<WebSharper.UI.Templating.Runtime.Server.TemplateEvent<Vars, WebSharper.JavaScript.Dom.MouseEvent>> x) { holes.Add(TemplateHole.NewEvent("search", FSharpConvert.Fun<DomElement, DomEvent>((a,b) => x(new WebSharper.UI.Templating.Runtime.Server.TemplateEvent<Vars, WebSharper.JavaScript.Dom.MouseEvent>(new Vars(instance), a, (WebSharper.JavaScript.Dom.MouseEvent)b))))); return this; }
            public Main NewTaskName(string x) { holes.Add(TemplateHole.NewText("newtaskname", x)); return this; }
            public Main NewTaskName(View<string> x) { holes.Add(TemplateHole.NewTextView("newtaskname", x)); return this; }
            public Main Clear(Action<DomElement, WebSharper.JavaScript.Dom.MouseEvent> x) { holes.Add(TemplateHole.NewActionEvent("clear", x)); return this; }
            public Main Clear(Action x) { holes.Add(TemplateHole.NewEvent("clear", FSharpConvert.Fun<DomElement, DomEvent>((a,b) => x()))); return this; }
            public Main Clear(Action<WebSharper.UI.Templating.Runtime.Server.TemplateEvent<Vars, WebSharper.JavaScript.Dom.MouseEvent>> x) { holes.Add(TemplateHole.NewEvent("clear", FSharpConvert.Fun<DomElement, DomEvent>((a,b) => x(new WebSharper.UI.Templating.Runtime.Server.TemplateEvent<Vars, WebSharper.JavaScript.Dom.MouseEvent>(new Vars(instance), a, (WebSharper.JavaScript.Dom.MouseEvent)b))))); return this; }
            public struct Vars
            {
                public Vars(Instance i) { instance = i; }
                readonly Instance instance;
                [Inline] public Var<string> SearchQueueName => (Var<string>)TemplateHole.Value(instance.Hole("searchqueuename"));
                [Inline] public Var<string> SearchMethodName => (Var<string>)TemplateHole.Value(instance.Hole("searchmethodname"));
            }
            public class Instance : WebSharper.UI.Templating.Runtime.Server.TemplateInstance
            {
                public Instance(WebSharper.UI.Templating.Runtime.Server.CompletedHoles v, Doc d) : base(v, d) { }
                public Vars Vars => new Vars(this);
            }
            public Instance Create() {
                var completed = WebSharper.UI.Templating.Runtime.Server.Handler.CompleteHoles(key, holes, new Tuple<string, WebSharper.UI.Templating.Runtime.Server.ValTy>[] { Tuple.Create("searchqueuename", WebSharper.UI.Templating.Runtime.Server.ValTy.String), Tuple.Create("searchmethodname", WebSharper.UI.Templating.Runtime.Server.ValTy.String) });
                var doc = WebSharper.UI.Templating.Runtime.Server.Runtime.GetOrLoadTemplate("jobsearch", FSharpOption<string>.Some("main"), FSharpOption<string>.Some("JobSearch.html"), "\r\n            <ul class=\"list-unstyled\" ws-hole=\"ListContainer\">\r\n                \r\n            </ul>\r\n            <form onsubmit=\"return false\">\r\n                <div class=\"form-group\">\r\n                    <label>New task</label>\r\n                    <div class=\"input-group\">\r\n                        <input class=\"form-control\" ws-var=\"SearchQueueName\">\r\n                        <input class=\"form-control\" ws-var=\"SearchMethodName\">\r\n                        <span class=\"input-group-btn\">\r\n                            <button class=\"btn btn-primary\" type=\"button\" ws-onclick=\"Search\">Search</button>\r\n                        </span>\r\n                    </div>\r\n                    <p class=\"help-block\">You are going to add: ${NewTaskName}<span></span></p>\r\n                </div>\r\n                <button class=\"btn btn-default\" type=\"button\" ws-onclick=\"Clear\">Clear Criteria</button>\r\n            </form>\r\n        ", null, completed.Item1, null, ServerLoad.WhenChanged, new Tuple<string, FSharpOption<string>, string>[] {  }, null, false, false, false);
                instance = new Instance(completed.Item2, doc);
                return instance;
            }
            public Doc Doc() => Create().Doc;
        }
    }
}