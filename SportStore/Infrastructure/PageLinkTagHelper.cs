using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SportStore.Models.ViewModels;

namespace SportStore.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public PagingInfo PageModel { get; set; }

        public string PageAction { get; set; }

        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        public override void Process(TagHelperContext context,
                TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder result = new TagBuilder("div");
            TagBuilder prev = new TagBuilder("a");
            prev.Attributes["href"] = urlHelper.Action(PageAction, new {productPage = PageModel.CurrentPage <= 1? 1 :PageModel.CurrentPage-1});
            prev.InnerHtml.Append("prev");
            result.InnerHtml.AppendHtml(prev);
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                
                TagBuilder tag = new TagBuilder("a");
                tag.Attributes["href"] = urlHelper.Action(PageAction,
                   new { productPage = i });
                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.CurrentPage
                        ? PageClassSelected : PageClassNormal);
                }
                tag.InnerHtml.Append(i.ToString());
                result.InnerHtml.AppendHtml(tag);
            }
            TagBuilder next = new TagBuilder("a");
            next.Attributes["href"] = urlHelper.Action(PageAction, new {productPage = PageModel.CurrentPage >= PageModel.TotalPages ? PageModel.TotalPages : PageModel.CurrentPage+1 });
            next.InnerHtml.Append("next");
            result.InnerHtml.AppendHtml(next);
            
            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}