# Creating a WPF Chart Dashboard to visualize the billionaire’s details, industry, and country list in 2023.

This sample describes a chart dashboard of the world billionaires list in 2023. The chart dashboard includes [line series](https://help.syncfusion.com/wpf/charts/seriestypes/lineandstepline#line-chart), [bar series](https://help.syncfusion.com/wpf/charts/seriestypes/columnandbar#bar-chart), and [doughnut series](https://help.syncfusion.com/wpf/charts/seriestypes/pieanddoughnut#doughnut-chart).The line series displays details such as billionaire names, ranks, net worth, and countries for the year 2023. The bar series shows the top 5 categories and the number of billionaires in 2023. The doughnut series illustrates the top 5 billionaire countries in 2023 along with the respective billionaire counts.

## Customization the chart appearnce
We can customize the chart appearnce using [header](https://help.syncfusion.com/wpf/charts/header), [gridlines](https://help.syncfusion.com/wpf/charts/axis#grid-lines), [axis line](https://help.syncfusion.com/wpf/charts/axis#axisline), [series palatte](https://help.syncfusion.com/wpf/charts/appearance#palettes), [angle](https://help.syncfusion.com/wpf/charts/axis#axis-labels).

## Customize the chart using annotation
We can use [annotation](https://help.syncfusion.com/wpf/charts/annotations) instances to add context within a specific chart area, here [positioning](https://help.syncfusion.com/wpf/charts/annotations#positioning-the-annotation) the text based on pixels.

## Customize the chart using interactivity
[Trackball](https://help.syncfusion.com/wpf/charts/interactive-features/trackball), which allows you to track a data point closer to the cursor. Additionally, you can customize the trackball using the [TrackBallLabelTemplate](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_TrackBallLabelTemplate). Using [PositionChanged](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartTrackBallBehavior.html#Syncfusion_UI_Xaml_Charts_ChartTrackBallBehavior_PositionChanged) event to retrieve the cursor's data points. Then, we'll bind these data points to a text block.

## Troubleshooting
#### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

<img width="815" alt="ChartDashBoard" src="https://github.com/SyncfusionExamples/Creating-billionaires-chart-dashboard-using-WPF-chart-controls/assets/102796134/28ba3eff-e2dd-4f77-bc7a-7923fa39c62a">


For a step-by-step procedure, refer to the [Visualize WPF Chart Dashboard for billionaires in 2023 blog]().


