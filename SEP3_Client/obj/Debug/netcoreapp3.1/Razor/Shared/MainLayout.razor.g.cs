#pragma checksum "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b68eae3f02ad4ade680b4a033f801e91ba7aa02e"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3_Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Shared\MainLayout.razor"
 if (show)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "sidebar");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenComponent<SEP3_Client.Shared.NavMenu>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 8 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Shared\MainLayout.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\">\r\n        <a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddContent(15, 
#nullable restore
#line 17 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Shared\MainLayout.razor"
 
    private static bool show = false;
    
    public static void Login()
    {
        show = true;
    }
    
    public static void Logout()
    {
        show = false;
    }
    
    public static bool IsLogin()
    {
        return show;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
