using B.HardwareTown.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.HardwareTown.Web.TagHelpers
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
        public ProductsPagingViewModel PageModel { get; set; }
        public string PageAction { get; set; }
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder result = new TagBuilder("div");
            TagBuilder prev = new TagBuilder("a");
            prev.Attributes["href"] = urlHelper.Action(PageAction, new
            {
                productPage = PageModel.PagingInfo.CurrentPage <= 1 ? 1 : PageModel.PagingInfo.CurrentPage - 1,
                PageSize = PageModel.PagingInfo.ItemsPerPage ,
                search = PageModel.PagingInfo.Search,
                categoryname = PageModel.PagingInfo.CategoryName,
                orderBy = PageModel.PagingInfo.OrderBy
            });
            if (PageClassesEnabled)
            {
                prev.AddCssClass(PageClass);
            }
            prev.InnerHtml.Append("Previous");
            result.InnerHtml.AppendHtml(prev);
            for (int i = 1; i <= PageModel.PagingInfo.TotalPages; i++)
            {

                TagBuilder tag = new TagBuilder("a");
                tag.Attributes["href"] = urlHelper.Action(PageAction,
                   new {
                       productPage = i,
                       PageSize = PageModel.PagingInfo.ItemsPerPage,
                       search = PageModel.PagingInfo.Search,
                       categoryname = PageModel.PagingInfo.CategoryName,
                       orderBy = PageModel.PagingInfo.OrderBy
                   });
                //tag.Attributes["href"] = urlHelper.Action()
                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.PagingInfo.CurrentPage
                        ? PageClassSelected : PageClassNormal);
                    
                }
                tag.InnerHtml.Append(i.ToString());
                result.InnerHtml.AppendHtml(tag);
            }
            TagBuilder next = new TagBuilder("a");
            next.Attributes["href"] = urlHelper.Action(PageAction, new
            {
                productPage = PageModel.PagingInfo.CurrentPage >= PageModel.PagingInfo.TotalPages ? PageModel.PagingInfo.TotalPages : PageModel.PagingInfo.CurrentPage + 1,
                PageSize = PageModel.PagingInfo.ItemsPerPage ,
                search = PageModel.PagingInfo.Search,
                categoryname = PageModel.PagingInfo.CategoryName,
                orderBy = PageModel.PagingInfo.OrderBy

            });
            if (PageClassesEnabled)
            {
                next.AddCssClass(PageClass);
            }
            next.InnerHtml.Append("Next");
            result.InnerHtml.AppendHtml(next);

            output.Content.AppendHtml(result.InnerHtml);
        }

    }
}