#pragma checksum "C:\Users\4504\blazor-web\Client\Shared\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c649d373807a5ac1263cad571720cb8f3318a9"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor_web.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\4504\blazor-web\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\4504\blazor-web\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\4504\blazor-web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\4504\blazor-web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\4504\blazor-web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\4504\blazor-web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\4504\blazor-web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\4504\blazor-web\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\4504\blazor-web\Client\_Imports.razor"
using blazor_web.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\4504\blazor-web\Client\_Imports.razor"
using blazor_web.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\4504\blazor-web\Client\_Imports.razor"
using blazor_web.Shared;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "list-unstyled");
            __builder.AddAttribute(2, "b-7o5vn9wfjj");
#nullable restore
#line 4 "C:\Users\4504\blazor-web\Client\Shared\ProductList.razor"
     foreach (var product in Products)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "li");
            __builder.AddAttribute(4, "class", "media my-3");
            __builder.AddAttribute(5, "b-7o5vn9wfjj");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "media-img-wrapper mr-2");
            __builder.AddAttribute(8, "b-7o5vn9wfjj");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "href", "#");
            __builder.AddAttribute(11, "b-7o5vn9wfjj");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "class", "media-img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 9 "C:\Users\4504\blazor-web\Client\Shared\ProductList.razor"
                                                 product.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "alt", 
#nullable restore
#line 9 "C:\Users\4504\blazor-web\Client\Shared\ProductList.razor"
                                                                         product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "b-7o5vn9wfjj");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "media-body");
            __builder.AddAttribute(20, "b-7o5vn9wfjj");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "#");
            __builder.AddAttribute(23, "b-7o5vn9wfjj");
            __builder.OpenElement(24, "h4");
            __builder.AddAttribute(25, "class", "mb-0");
            __builder.AddAttribute(26, "b-7o5vn9wfjj");
            __builder.AddContent(27, 
#nullable restore
#line 14 "C:\Users\4504\blazor-web\Client\Shared\ProductList.razor"
                                      product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "p");
            __builder.AddAttribute(30, "b-7o5vn9wfjj");
            __builder.AddContent(31, 
#nullable restore
#line 16 "C:\Users\4504\blazor-web\Client\Shared\ProductList.razor"
                    product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "h5");
            __builder.AddAttribute(34, "class", "price");
            __builder.AddAttribute(35, "b-7o5vn9wfjj");
            __builder.AddMarkupContent(36, "\r\n                    $");
            __builder.AddContent(37, 
#nullable restore
#line 18 "C:\Users\4504\blazor-web\Client\Shared\ProductList.razor"
                      product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\4504\blazor-web\Client\Shared\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\4504\blazor-web\Client\Shared\ProductList.razor"
       
    private static List<Product> Products = new List<Product>();

    protected override async Task OnInitializedAsync()
    {
        var result = await Http.GetFromJsonAsync<List<Product>>("api/Product");
        if (result != null)
            Products = result;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591