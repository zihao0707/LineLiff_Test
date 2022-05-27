#pragma checksum "D:\POME瑞精\lifftest\Pages\Liff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d1dbc68bf01d1297bf262b5c2f945bbe3fa8f3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(lifftest.Pages.Pages_Liff), @"mvc.1.0.razor-page", @"/Pages/Liff.cshtml")]
namespace lifftest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\POME瑞精\lifftest\Pages\_ViewImports.cshtml"
using lifftest;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d1dbc68bf01d1297bf262b5c2f945bbe3fa8f3d", @"/Pages/Liff.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"711ba8160cba9b081ae8f9ba55b32531cef095d7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Liff : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\POME瑞精\lifftest\Pages\Liff.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <!-- bootstrap 4.3.1 -->
    <link rel=""stylesheet""
          href=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/js/bootstrap.min.js""></script>
    <!--  LIFF SDK -->
    <script charset=""utf-8"" src=""https://static.line-scdn.net/liff/edge/2/sdk.js""></script>

    <script>
        //你的liff app ID, 例如 --> 0000000000-spPeRmAn
        var YourLiffAppId = '1657162167-wNkg7vn4';

        /**
        * Initialize LIFF
        */
        function initializeLiff(myLiffId) {
            liff
                .init({
                    liffId: myLiffId
                })
                .then(() => {
                    // start to use LIFF's api
                    main();
                })
                .catch((err) => {
                    document.getElementById(""liffA");
                WriteLiteral(@"ppContent"").classList.add('hidden');
                    document.getElementById(""liffInitErrorMessage"").classList.remove('hidden');
                });
        }

        function main() {
            //取得QueryString
            let urlParams = new URLSearchParams(window.location.search);
            //顯示QueryString
            $('#QueryString').val(urlParams.toString());
            //顯示UserId
            liff.getProfile().then(function (e) {
                $('#field_info').val('取得用戶資訊:' + e.userId);
            });
        }

        $(document).ready(function () {
            //init LIFF
            initializeLiff(YourLiffAppId);

            $('#ButtonScan').click(() => {
                liff.scanCode().then((ret) => {
                    //alert(JSON.stringify(ret));
                    $('#field_info').val(ret.value);
                }, (err) => {
                    alert(JSON.stringify(err));
                }
                );
            });

            $('#ButtonGe");
                WriteLiteral(@"tOS').click(() => {
                var info = liff.getOS();
                $('#field_info').val(info);
            });

            $('#ButtonGetLanguage').click(() => {
                var info = liff.getLanguage();
                $('#field_info').val(info);
            });

            //ButtonGetProfile
            $('#ButtonGetProfile').click(() => {
                //取得User Proile
                liff.getProfile().then(
                    (profile) => {
                        //顯示在text box中
                        $('#field_info').val(profile.displayName);
                        //可以alert
                        alert('done');
                    }
                );
            });

            //ButtonSendMsg
            $('#ButtonSendMsg').click(function () {
                liff.sendMessages([
                    {
                        ""type"": 'text',
                        ""text"": $('#msg').val()
                    },
                    {
                  ");
                WriteLiteral(@"      ""type"": ""sticker"",
                        ""packageId"": ""1"",
                        ""stickerId"": ""1""
                    }
                ])
                    .then(() => {
                        alert('done');
                    })
                    .catch((err) => {
                        alert('error' + err);
                    });
            });

            //ButtonShareTargetPicker
            $('#ButtonShareTargetPicker').click(function () {
                liff.shareTargetPicker([
                    {
                        ""type"": 'text',
                        ""text"": $('#msg').val()
                    },
                    {
                        ""type"": ""sticker"",
                        ""packageId"": ""1"",
                        ""stickerId"": ""1""
                    }
                ])
                    .then(() => {
                        alert('done');
                    })
                    .catch((err) => {
                        ale");
                WriteLiteral("rt(\'error\' + err);\r\n                    });\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""text-center"">
    <h1 class=""display-4"">Liff demo</h1>

    <div class=""row"">
        <div id=""MainDiv"" class=""col-md-6"" style=""margin:5px"">
            <label>QueryString:</label>
            <input class=""form-control"" type=""text"" id=""QueryString"" /><br />
            <label>info:</label>
            <textarea class=""form-control"" rows=""3"" type=""text"" id=""field_info""></textarea>   <br />
            <button class=""btn btn-primary"" id=""ButtonGetOS"">取得作業系統</button>
            <button class=""btn btn-primary"" id=""ButtonGetLanguage"">取得語系</button>
            <br />
            <br />
            <button class=""btn btn-primary"" id=""ButtonScan"">掃描 QR Code</button>
            <button class=""btn btn-primary"" id=""ButtonGetProfile"">取得用戶Profile</button>
            <hr />
            <hr />
            <label>要傳送的訊息:</label>
            <input class=""form-control"" type=""text"" id=""msg"" value=""測試文字"" /><br />
            <button class=""btn btn-primary"" id=""ButtonSendMsg"">在聊天室畫面傳送訊息</button");
            WriteLiteral(">\r\n            <button class=\"btn btn-primary\" id=\"ButtonShareTargetPicker\">選擇群組傳送訊息</button>\r\n            <br />\r\n            <br />\r\n            <br />\r\n            <hr />\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<__NameSpace__.Pages.LiffModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<__NameSpace__.Pages.LiffModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<__NameSpace__.Pages.LiffModel>)PageContext?.ViewData;
        public __NameSpace__.Pages.LiffModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
