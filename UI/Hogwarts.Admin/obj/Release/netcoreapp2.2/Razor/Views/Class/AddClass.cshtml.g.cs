#pragma checksum "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\Class\AddClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4c2113cd4bccc4b8338efc5ba75386b386fdb34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Class_AddClass), @"mvc.1.0.view", @"/Views/Class/AddClass.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Class/AddClass.cshtml", typeof(AspNetCore.Views_Class_AddClass))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\_ViewImports.cshtml"
using Hogwarts.Admin;

#line default
#line hidden
#line 4 "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\Class\AddClass.cshtml"
using Hogwarts.DB.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c2113cd4bccc4b8338efc5ba75386b386fdb34", @"/Views/Class/AddClass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e2fb0031e553fe0535614bd99813057267b8fca", @"/Views/_ViewImports.cshtml")]
    public class Views_Class_AddClass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Class>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/layui/css/layui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/public.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:80%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/classAdd.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("childrenBody"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\Class\AddClass.cshtml"
  
    Layout = "";

#line default
#line hidden
            BeginContext(123, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(148, 622, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4c2113cd4bccc4b8338efc5ba75386b386fdb347691", async() => {
                BeginContext(154, 470, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Hogwarts后台管理-添加学院</title>
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">
    <meta name=""apple-mobile-web-app-status-bar-style"" content=""black"">
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta name=""format-detection"" content=""telephone=no"">
    ");
                EndContext();
                BeginContext(624, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4c2113cd4bccc4b8338efc5ba75386b386fdb348567", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(694, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(700, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4c2113cd4bccc4b8338efc5ba75386b386fdb349986", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(761, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(770, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(772, 2221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4c2113cd4bccc4b8338efc5ba75386b386fdb3412202", async() => {
                BeginContext(799, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(805, 2037, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4c2113cd4bccc4b8338efc5ba75386b386fdb3412590", async() => {
                    BeginContext(849, 170, true);
                    WriteLiteral("\r\n        <div class=\"layui-form-item layui-row layui-col-xs12\">\r\n            <label class=\"layui-form-label\">学院ID</label>\r\n            <div class=\"layui-input-inline\">\r\n");
                    EndContext();
#line 27 "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\Class\AddClass.cshtml"
                 if (Model.ClassId == 0)
                {

#line default
#line hidden
                    BeginContext(1080, 158, true);
                    WriteLiteral("                    <input type=\"text\" class=\"layui-input classId layui-disabled\" value=\"\" name=\"classId\" lay-verify=\"\" disabled placeholder=\"学院Id,不用填自动生成\">\r\n");
                    EndContext();
#line 30 "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\Class\AddClass.cshtml"
                }
                else
                {

#line default
#line hidden
                    BeginContext(1298, 81, true);
                    WriteLiteral("                    <input type=\"text\" class=\"layui-input classId layui-disabled\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1379, "\"", 1401, 1);
#line 33 "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\Class\AddClass.cshtml"
WriteAttributeValue("", 1387, Model.ClassId, 1387, 14, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1402, 60, true);
                    WriteLiteral(" name=\"classId\" lay-verify=\"\" disabled placeholder=\"学院Id\">\r\n");
                    EndContext();
#line 34 "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\Class\AddClass.cshtml"
                }

#line default
#line hidden
                    BeginContext(1481, 268, true);
                    WriteLiteral(@"            </div>
        </div>
        <div class=""layui-form-item layui-row layui-col-xs12"">
            <label class=""layui-form-label"">学院名字</label>
            <div class=""layui-input-inline"">
                <input type=""text"" class=""layui-input className""");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1749, "\"", 1773, 1);
#line 40 "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\Class\AddClass.cshtml"
WriteAttributeValue("", 1757, Model.ClassName, 1757, 16, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1774, 349, true);
                    WriteLiteral(@" name=""className"" lay-verify=""required"" placeholder=""请输入学院名字"">
            </div>
        </div>
        <div class=""layui-form-item layui-row layui-col-xs12"">
            <label class=""layui-form-label"">学院主任</label>
            <div class=""layui-input-inline"">
                <input type=""text"" class=""layui-input classDean"" name=""classDean""");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2123, "\"", 2142, 1);
#line 46 "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\Class\AddClass.cshtml"
WriteAttributeValue("", 2131, Model.Dean, 2131, 11, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2143, 193, true);
                    WriteLiteral(" lay-verify=\"required\" placeholder=\"请输入学院主任名\">\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-form-item layui-row layui-col-xs12\">\r\n            <div class=\"layui-input-block\">\r\n");
                    EndContext();
#line 51 "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\Class\AddClass.cshtml"
                 if (Model.ClassId == 0)
                {

#line default
#line hidden
                    BeginContext(2397, 110, true);
                    WriteLiteral("                    <button class=\"layui-btn layui-btn-sm\" lay-submit=\"\" lay-filter=\"addClass\">立即添加</button>\r\n");
                    EndContext();
#line 54 "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\Class\AddClass.cshtml"
                }
                else
                {

#line default
#line hidden
                    BeginContext(2567, 110, true);
                    WriteLiteral("                    <button class=\"layui-btn layui-btn-sm\" lay-submit=\"\" lay-filter=\"addClass\">立即修改</button>\r\n");
                    EndContext();
#line 58 "C:\Users\Administrator\Desktop\我的项目\数据库大作业\Hogwarts\Hogwarts\UI\Hogwarts.Admin\Views\Class\AddClass.cshtml"
                }

#line default
#line hidden
                    BeginContext(2696, 139, true);
                    WriteLiteral("                <button type=\"reset\" class=\"layui-btn layui-btn-sm layui-btn-primary\">取消</button>\r\n            </div>\r\n        </div>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2842, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2848, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4c2113cd4bccc4b8338efc5ba75386b386fdb3419388", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2915, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2921, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4c2113cd4bccc4b8338efc5ba75386b386fdb3420731", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2984, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2993, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Class> Html { get; private set; }
    }
}
#pragma warning restore 1591
