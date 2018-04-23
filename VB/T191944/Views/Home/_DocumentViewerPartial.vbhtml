@Html.DevExpress().DocumentViewer(Sub(settings)
                                      settings.Name = "DocumentViewer"
                                      settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "DocumentViewerPartial"}
                                      settings.ExportRouteValues = New With {.Controller = "Home", .Action = "DocumentViewerPartialExport"}
                                      settings.Report = CType(Model, XtraReport)
                                      settings.ToolbarMode = DocumentViewerToolbarMode.StandardToolbar
    
                                      settings.SetCustomParameter("Categories", Sub(parameter)
                                                                                    Dim propertiesEdit As New TokenBoxProperties()
                                                                                    parameter.PropertiesEdit = propertiesEdit

                                                                                    propertiesEdit.AllowCustomTokens = False
                                                                                    propertiesEdit.ShowDropDownOnFocus = ShowDropDownOnFocusMode.Always

                                                                                    propertiesEdit.ValueField = "CategoryID"
                                                                                    propertiesEdit.TextField = "CategoryName"
                                                                                    propertiesEdit.ValueSeparator = "|"c

                                                                                    Dim db As New T191944.Models.NorthwindEntities()
                                                                                    propertiesEdit.DataSource = From category In db.Categories
                                                                                                                       Select category
                                                                                End Sub)
                                  End Sub).GetHtml()
