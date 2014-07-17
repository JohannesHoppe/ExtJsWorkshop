var superGrid = (function() {

    var onselectionChange = function(model, selected, eOpts) {

        var data = selected[0].data;

        var titleField = Ext.get("titleField");
        titleField.setValue(data.Title);

        var dueDateField = Ext.get("dueDateField");
        dueDateField.setValue(data.DueDate);

        var descriptionField = Ext.get("descriptionField");
        descriptionField.setValue(data.Description);
    }

    return {
        onselectionChange: onselectionChange
    }
})();