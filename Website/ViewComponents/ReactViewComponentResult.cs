using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using React;
using React.AspNet;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Website.ViewComponents
{
    public class ReactViewComponentResult : IViewComponentResult
    {
        public ReactViewComponentResult(string componentName)
        {
            this.ComponentName = componentName;
            this.ContainerTag = "div";
        }
        public ReactViewComponentResult(string componentName, object props)
: this(componentName)
        {
            this.Props = props;
        }

        public string ComponentName { get; set; }

        public string ContainerTag { get; set; }

        public string ContainerCssClass { get; set; }

        public object Props { get; set; }

        public bool ClientOnly { get; set; }

        public bool ServerOnly { get; set; }

        private string RenderHtml() {
            var component = React.ReactEnvironment.Current.CreateComponent(this.ComponentName, this.Props, clientOnly: this.ClientOnly, serverOnly: this.ServerOnly);
            component.ContainerTag = !string.IsNullOrWhiteSpace(this.ContainerTag) ? this.ContainerTag : "div";
            component.ContainerClass = this.ContainerCssClass;
            return component.RenderHtml(this.ClientOnly, this.ServerOnly);
        }

        public void Execute(ViewComponentContext context)
        {   
            context.Writer.Write(this.RenderHtml());
        }

        public Task ExecuteAsync(ViewComponentContext context)
        {
            return context.Writer.WriteAsync(this.RenderHtml());
        }
    }
}
