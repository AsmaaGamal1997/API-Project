#pragma checksum "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f17ecc08882ac71672233abb94e4620b0da16da"
// <auto-generated/>
#pragma warning disable 1591
namespace Lab3_Blazer.WASM.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Lab3_Blazer.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Lab3_Blazer.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Lab3_Blazer.WASM.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
using Lab3_Blazer.shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
using Lab3_Blazer.WASM.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class UserProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
 if(prodlist !=null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-light");
            __builder.AddMarkupContent(2, "<thead><tr><th scope=\"col\">name</th>\r\n      <th scope=\"col\">info</th>\r\n      <th scope=\"col\">price</th>\r\n      <th scope=\"col\">Image</th>\r\n      <th scope=\"col\">Edit_Product</th>\r\n       <th scope=\"col\">Delete_Product</th></tr></thead>\r\n    ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 19 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
 foreach(var item in prodlist)
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
#nullable restore
#line 24 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
__builder.AddContent(6, item.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n      \r\n      \r\n      ");
            __builder.OpenElement(8, "td");
#nullable restore
#line 27 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
__builder.AddContent(9, item.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n      ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 29 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
__builder.AddContent(12, item.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n      ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "style", "width:30px");
            __builder.AddAttribute(17, "src", "/Images/" + (
#nullable restore
#line 30 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
                                                item.img

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n       ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/pro/Edit/" + (
#nullable restore
#line 31 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
                               item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n       ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
                             (()=>handleDelete(item.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "class", "btn btn-danger");
            __builder.AddContent(28, "delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
  

}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
       
    public List<Product> prodlist { get; set; }
    protected async  override Task OnInitializedAsync()//pareter /inject 
    {
        prodlist= await proservices.GetAll();
        await  base.OnInitializedAsync();
    }
    public async Task handleDelete(int id)
    {
        proservices.Delete(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServices<Product> proservices { get; set; }
    }
}
#pragma warning restore 1591
