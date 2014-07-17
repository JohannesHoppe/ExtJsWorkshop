var doneRenderer = function (value) {
    return Ext.String.format('<span style="color:{0};">{1}</span>', value ? "green" : "red", value);
};

Ext.onReady(function () {

    var grid = Ext.getCmp("grid");

    var handleSelectionchange = function(model, selected, eOpts) {

        var data = selected[0].data;

        // get the DOM element
        var titleField = Ext.get("titleField");
        titleField.setValue(data.Title);

        var dueDateField = Ext.get("dueDateField");
        dueDateField.setValue(data.DueDate);

        var descriptionField = Ext.get("descriptionField");
        descriptionField.setValue(data.Description);

        // get as Cmp

        var doneField = Ext.getCmp("doneField");
        doneField.setValue(data.Done);
    };

    grid.on("selectionchange", handleSelectionchange);

});