<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596923/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T191944)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/T191944/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/T191944/Controllers/HomeController.vb))
* [ProductsReport.cs](./CS/T191944/Reports/ProductsReport.cs) (VB: [ProductsReport.vb](./VB/T191944/Reports/ProductsReport.vb))
* **[_DocumentViewerPartial.cshtml](./CS/T191944/Views/Home/_DocumentViewerPartial.cshtml)**
<!-- default file list end -->
# MVC DocumentViewer extension - Creating a multi-select parameter
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t191944/)**
<!-- run online end -->


<p><strong>NOTE</strong> Starting with version <strong>15.1</strong> the multi-select parameters for our reporting suite are available out of the box. See the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument9997/Using">Parameters Overview > Using Parameters > Multi-Value Parameters</a> help topic for more details.</p>
<p><br />This example demonstrates how to use a custom editor for the report's parameter to implement a multi-select parameter. The <a href="https://documentation.devexpress.com/#AspNet/CustomDocument16298">TokenBox</a> extension is used as a multi-select parameter editor.</p>
<br />
<p>The main idea of this approach is to use a report's parameter to pass a string that contains CategoryIDs separated by the '|' character to the report. Then on the report's <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReportBase_DataSourceDemandedtopic"><u>DataSourceDemanded</u></a> event handler the report's DataSource is populated based on the parameter value. <br />The approach demonstrated in the <a href="https://www.devexpress.com/Support/Center/p/E5053">DocumentViewer - How to customize a report parameter editor in MVC application</a> code example is used to customize the DocumentViewer parameter editor.<br /><br /></p>
<p><strong>See also:<br /></strong><a href="https://www.devexpress.com/Support/Center/p/T262163">MVC DocumentViewer - How to create a custom CheckedComboBox parameter editor with the "Select All" functionality for a report</a><br /><a href="https://www.devexpress.com/Support/Center/p/E5142">ASPxDocumentViewer - How to customize a parameter editor (Creating a multi-select parameter)</a></p>

<br/>


