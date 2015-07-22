/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.Viewv_testimony.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.v_testimony.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.v_testimony." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

