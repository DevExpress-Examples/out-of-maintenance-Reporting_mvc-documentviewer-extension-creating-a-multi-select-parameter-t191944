<!DOCTYPE html>

<html>
<head>
    <title>DevExpress ASP.NET project</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
    
    @Html.DevExpress().GetStyleSheets(
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.HtmlEditor},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.PivotGrid},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Chart},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Report},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Scheduler},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.TreeList},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Spreadsheet},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.SpellChecker}
)
@Html.DevExpress().GetScripts(
    New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
    New Script With {.ExtensionSuite = ExtensionSuite.HtmlEditor},
    New Script With {.ExtensionSuite = ExtensionSuite.GridView},
    New Script With {.ExtensionSuite = ExtensionSuite.PivotGrid},
    New Script With {.ExtensionSuite = ExtensionSuite.Editors},
    New Script With {.ExtensionSuite = ExtensionSuite.Chart},
    New Script With {.ExtensionSuite = ExtensionSuite.Report},
    New Script With {.ExtensionSuite = ExtensionSuite.Scheduler},
    New Script With {.ExtensionSuite = ExtensionSuite.TreeList},
    New Script With {.ExtensionSuite = ExtensionSuite.Spreadsheet},
    New Script With {.ExtensionSuite = ExtensionSuite.SpellChecker}
)
</head>

<body>
    <div class="content-wrapper">
        <div class="header">
            <h1>DevExpress ASP.NET project</h1>
            @Html.DevExpress().Menu(Sub(settings)
                                        settings.Name = "HeaderMenu"
                                        settings.ItemAutoWidth = False
                                        settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
                                        settings.Styles.Style.Border.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(0)
                                        settings.Styles.Style.Paddings.Padding = System.Web.UI.WebControls.Unit.Pixel(0)
                                        settings.Items.Add("Home")
                                        settings.Items.Add("About")
                                        settings.Items.Add("Contact")
                                    End Sub).GetHtml()
        </div>

        <div class="content">
            @RenderBody()
        </div>

        <div class="footer">
            <p>&copy; @DateTime.Now.Year - DevExpress ASP.NET project copyright</p>
        </div>
    </div>
</body>
</html>