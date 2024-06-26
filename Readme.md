<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128551606/16.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T498424)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# GridView for ASP.NET MVC - How to implement a single cell edit feature

This example demonstrates how to edit a grid cell in batch mode and update the data source on a callback.

Follow the steps below to configure a single cell's edit functionality:

1. Place GridView with the enabled Batch Edit mode on the page.
2. Handle the [BatchEditEndEditing](https://docs.devexpress.com/AspNet/js-ASPxClientGridView.BatchEditEndEditing) event. In the handler, collect the information about the edited row and send the information to the server side. Use the jQuery.ajax method for this.
3. In the controller action, update the data source with the new data and return the result string (OK or the error message).
4. Use the success handler to return the focus to the last edited cell if something went wrong. For example, a server-side validation error.

## Files to Review

* [HomeController.cs](./CS/E430_MVC/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E430_MVC/Controllers/HomeController.vb))
* [Model.cs](./CS/E430_MVC/Models/Model.cs) (VB: [Model.vb](./VB/E430_MVC/Models/Model.vb))
* [GridViewPartial.cshtml](./CS/E430_MVC/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/E430_MVC/Views/Home/Index.cshtml)

## Documentation

* [Grid in Batch Edit Mode](https://docs.devexpress.com/AspNetMvc/16147/components/grid-view/data-editing-and-validation/batch-edit)

## More Examples

* [Grid View for ASP.NET Web Forms - How to implement a single cell edit feature](https://github.com/DevExpress-Examples/asp-net-web-forms-grid-single-cell-editing)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-grid-single-cell-editing&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-grid-single-cell-editing&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
