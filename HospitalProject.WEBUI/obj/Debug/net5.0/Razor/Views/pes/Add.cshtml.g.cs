#pragma checksum "C:\Users\DELL\Downloads\HospitalProject-main\HospitalProject-main\HospitalProject-main\HospitalProject.WEBUI\Views\pes\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35eb5259d2a57940774db29361c41c67d92d0177"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_pes_Add), @"mvc.1.0.view", @"/Views/pes/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35eb5259d2a57940774db29361c41c67d92d0177", @"/Views/pes/Add.cshtml")]
    public class Views_pes_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HospitalProject.WEBUI.Model.Specimenanddiseaseinformation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL\Downloads\HospitalProject-main\HospitalProject-main\HospitalProject-main\HospitalProject.WEBUI\Views\pes\Add.cshtml"
  
    ViewData["Title"] = "Add";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    h4 {
        float: left;
        display: inline-block;
        background-color: #00771e;
        color: #fff;
        font-size: 1.5em;
        padding: 5px 10px;
        text-decoration: none;
    }
</style>

<h4>Specimenanddiseaseinformation</h4>
<br />
<br />
<br />
<br />

<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Add"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <p>collection_date</p>
                <label asp-for=""collection_date"" class=""control-label""></label>
                <input asp-for=""collection_date"" class=""form-control"" />
                <span asp-validation-for=""collection_date"" class=""text-danger""></span>
            </div>
            <br />
            <div class=""form-group"">
                <p>collection_time</p>
                <label asp-for=""collection_time"" class=""control-label""></label>
                <input asp-for=");
            WriteLiteral(@"""collection_time"" class=""form-control"" />
                <span asp-validation-for=""collection_time"" class=""text-danger""></span>
            </div>
            <br />
            <div class=""form-group"">
                <p>anatomical_region</p>
                <label asp-for=""anatomical_region"" class=""control-label""></label>
                <input asp-for=""anatomical_region"" class=""form-control"" />
                <span asp-validation-for=""anatomical_region"" class=""text-danger""></span>
            </div>
            <br />
            <div class=""form-group"">
                <p>group_type</p>
                <label asp-for=""group_type"" class=""control-label""></label>
                <input asp-for=""group_type"" class=""form-control"" />
                <span asp-validation-for=""group_type"" class=""text-danger""></span>
            </div>
            <br />
            <div class=""form-group"">
                <p>OPERASYON_PROSED??R??</p>
                <label asp-for=""OPERASYON_PROSED??R??"" class=""c");
            WriteLiteral(@"ontrol-label""></label>
                <input asp-for=""OPERASYON_PROSED??R??"" class=""form-control"" />
                <span asp-validation-for=""OPERASYON_PROSED??R??"" class=""text-danger""></span>
            </div>
            <br />
            <div class=""form-group"">
                <p>Diagnosis_date</p>
                <label asp-for=""Diagnosis_date"" class=""control-label""></label>
                <input asp-for=""Diagnosis_date"" class=""form-control"" />
                <span asp-validation-for=""Diagnosis_date"" class=""text-danger""></span>
            </div>
            <br />
            <div class=""form-group"">
                <p>Clinical_diagnosis</p>
                <label asp-for=""Clinical_diagnosis"" class=""control-label""></label>
                <input asp-for=""Clinical_diagnosis"" class=""form-control"" />
                <span asp-validation-for=""Clinical_diagnosis"" class=""text-danger""></span>
            </div>
            <br />
            <div class=""form-group"">
                <p>Dia");
            WriteLiteral(@"gnotstic_Code</p>
                <label asp-for=""Diagnotstic_Code"" class=""control-label""></label>
                <input asp-for=""Diagnotstic_Code"" class=""form-control"" />
                <span asp-validation-for=""Diagnotstic_Code"" class=""text-danger""></span>
            </div>
            <br />
            <div class=""form-group"">
                <p>Numune_To_lama_ekli</p>
                <label asp-for=""Numune_To_lama_ekli"" class=""control-label""></label>
                <input asp-for=""Numune_To_lama_ekli"" class=""form-control"" />
                <span asp-validation-for=""Numune_To_lama_ekli"" class=""text-danger""></span>
            </div>
            <br />
            <div class=""form-group"">
                <p>Mikroskopik_analize</p>
                <label asp-for=""Mikroskopik_analize"" class=""control-label""></label>
                <input asp-for=""Mikroskopik_analize"" class=""form-control"" />
                <span asp-validation-for=""Mikroskopik_analize"" class=""text-danger""></span>
     ");
            WriteLiteral(@"       </div>
            <br />
            <div class=""form-group"">
                <p>patolojik_tani</p>
                <label asp-for=""patolojik_tani"" class=""control-label""></label>
                <input asp-for=""patolojik_tani"" class=""form-control"" />
                <span asp-validation-for=""patolojik_tani"" class=""text-danger""></span>
            </div>
            <br />
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 118 "C:\Users\DELL\Downloads\HospitalProject-main\HospitalProject-main\HospitalProject-main\HospitalProject.WEBUI\Views\pes\Add.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospitalProject.WEBUI.Model.Specimenanddiseaseinformation> Html { get; private set; }
    }
}
#pragma warning restore 1591
