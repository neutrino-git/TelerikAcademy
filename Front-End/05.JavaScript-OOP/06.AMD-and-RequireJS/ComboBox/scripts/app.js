(function () {

    require.config({
        paths: {
            "jquery": "libs/jquery-2.1.1.min",
            "handlebars": "libs/handlebars-v1.3.0"
        }
    });

    require(["jquery", "controls", "data"], function ($, controls, data) {
        
        $(document).ready(function () {
            var comboBox = controls.ComboBox(data.items);
            var template = $("#template").html();
            var comboBoxHtml = comboBox.render(template);
            $('#container').html(comboBoxHtml);
        });
    });

}());