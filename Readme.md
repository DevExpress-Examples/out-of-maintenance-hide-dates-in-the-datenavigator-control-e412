<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128633673/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E412)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DateNavigator-S92168/Form1.cs) (VB: [Form1.vb](./VB/DateNavigator-S92168/Form1.vb))
* [Program.cs](./CS/DateNavigator-S92168/Program.cs) (VB: [Program.vb](./VB/DateNavigator-S92168/Program.vb))
<!-- default file list end -->
# Hide dates in the DateNavigator control


<p>This example illustrates how to hide dates of  the previous/next month in the <strong>DateNavigator</strong> control.<br />For versions before v15.2 it is recommended to implement a DateNavigator class descendant and override the <strong>CalcDayNumberCells</strong> method. <br /><br /></p>


<h3>Description</h3>

Starting from&nbsp;15.2, the&nbsp;<a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraSchedulerDateNavigator_InactiveDaysVisibilitytopic">DateNavigator.InactiveDaysVisibility</a>&nbsp;property allows you to hide dates which do not belong to the current month displayed in the <a href="http://help.devexpress.com/#WindowsForms/CustomDocument1740">DateNavigator</a>&nbsp;control. Default value is&nbsp;<strong>CalendarInactiveDaysVisibility.FirstLast&nbsp;</strong>to display only dates of the months before and after the months shown in the control, as illustrated in the following image.<br /><img data-image="8fe5c08f-8ea7-11e5-80bf-00155d62480c"><br /><br /><br />

<br/>


