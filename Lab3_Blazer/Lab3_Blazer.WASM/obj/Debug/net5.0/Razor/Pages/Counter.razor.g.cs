#pragma checksum "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1567b195ae87c73827fb956edb4278b12670e25b"
// <auto-generated/>
#pragma warning disable 1591
namespace Lab3_Blazer.WASM.Pages
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
#line 12 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Lab3_Blazer.shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\ITI\API\API Sara Project\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Lab3_Blazer.WASM.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\r\n\r\n");
            __builder.AddMarkupContent(1, "<head><title>Login Page</title>\r\n   \r\n   \r\n\t\r\n\t<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css\" integrity=\"sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO\" crossorigin=\"anonymous\">\r\n    \r\n    \r\n\t<link rel=\"stylesheet\" href=\"httpsss://use.fontawesome.com/releases/v5.3.1/css/all.css\" integrity=\"sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU\" crossorigin=\"anonymous\">\r\n\r\n\t\r\n\t<link rel=\"stylesheet\" type=\"text/css\" href=\"styles.css\">\r\n\t<style>\r\nbody{margin: 0;padding: 0;/*background: url(https://i.ibb.co/VQmtgjh/6845078.png) no-repeat;*/\r\n    \r\nheight: 100vh;font-family: sans-serif;background-size: cover;\r\n\r\nbackground-repeat: no-repeat;background-position: center;overflow: hidden}\r\n\r\nbody\r\n{background-size:cover }\r\n#particles-js{height: 100%}.loginBox\r\n{position: absolute;top: 50%;left: 50%;transform: translate(-50%,-50%);width: 500px;min-height: 300px;background: #eee;border-radius: 10px;padding: 50px;box-sizing: border-box}\r\n.user{margin: 0 auto;display: block;margin-bottom: 20px}h3{margin: 0;padding: 0 0 20px;color: #59238F;text-align: center}\r\n.loginBox input{width: 100%;margin-bottom: 20px}.loginBox input[type=\"text\"], \r\n.loginBox input[type=\"password\"]{border: none;border-bottom: 2px solid #262626;outline: none;height: 40px;color: #ffff;background: transparent;font-size: 16px;padding-left: 20px;box-sizing: border-box}\r\n.loginBox input[type=\"text\"]:hover, .loginBox input[type=\"password\"]:hover{color: #42F3FA;border: 1px solid #42F3FA;box-shadow: 0 0 5px rgba(0,255,0,.3), 0 0 10px rgba(0,255,0,.2), 0 0 15px rgba(0,255,0,.1), 0 2px 0 black}.loginBox input[type=\"text\"]:focus, .loginBox input[type=\"password\"]:focus{border-bottom: 2px solid #42F3FA}.inputBox{position: relative}.inputBox span{position: absolute;top: 10px;color: #262626}.loginBox input[type=\"submit\"]{border: none;outline: none;height: 40px;font-size: 16px;background: #59238F;color: #fff;border-radius: 20px;cursor: pointer}.loginBox a{color: #262626;font-size: 14px;font-weight: bold;text-decoration: none;text-align: center;display: block}\r\n\r\n\r\n\r\n\r\n\t</style></head>\r\n");
            __builder.AddMarkupContent(2, @"<div class=""loginBox""><h3>Sign in here</h3>
        <form action=""login.php"" method=""post""><div class=""inputBox""><input id=""uname"" type=""text"" name=""Username"" placeholder=""Username""> 
                
                <input id=""pass"" type=""password"" name=""Password"" placeholder=""Password""></div> 
                <br><br> <br>
               <a href=""http://localhost:20166/admin"" class=""btn btn-success"" style=""padding:8px"">Log in</a></form> 
        <br> <br>
        <a href=""#"">Forget Password<br></a>
        <br>
        <div class=""text-center""><p style=""color: #59238F;"">Sign-Up</p></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
