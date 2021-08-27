<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128551606/16.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T498424)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/E430_MVC/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E430_MVC/Controllers/HomeController.vb))
* [Model.cs](./CS/E430_MVC/Models/Model.cs) (VB: [Model.vb](./VB/E430_MVC/Models/Model.vb))
* [GridViewPartial.cshtml](./CS/E430_MVC/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/E430_MVC/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to implement a single cell editing feature in GridView
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t498424/)**
<!-- run online end -->


When a cell is modified, a custom callback is sent via component ASPxCallback and the grid data source is updated manually.<br>The steps to implement are:<br>1. Place GridView with the enabled Batch Edit mode on the page;<br>2. Handle the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientGridView_BatchEditEndEditingtopic">ASPxClientGridView.BatchEditEndEditing</a> event;<br>3. In the BatchEditEndEditing event handler, collect the information about the edited row and send the information to the server side. Use the jQuery.ajax method for this.<br>4. In the controller action, update the data source with the new data and return the result string (OK or the error message);<br>5. Use the success handler to return the focus to the last edited cell if something went wrong. For example, a server-side validation error.<br><br>See also: <a href="https://www.devexpress.com/Support/Center/p/e430">How to implement a single cell editing feature in the ASPxGridView</a>

<br/>


