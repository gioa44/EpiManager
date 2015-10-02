﻿var Main = {
    configureDatePicker: function (elementSelector, options) {

        var defaults = {
            format: "dd/mm/yyyy",
            parseFormat: "dd/mm/yy",
            weekStart: 1, // Monday
            autoclose: true,
            todayHighlight: true
        };

        var settings = $.extend(defaults, options);

        $(elementSelector).datepicker(settings);

        //$(document).off("focus", '.datepicker');
        //$(document).on('focus', '.datepicker', function () {
        //    $(this).datepicker(settings);
        //});


        $.validator.addMethod('date', function (value, element, params) {
            if (this.optional(element)) {
                return true;
            };
            var result = false;
            try {
                $.datepicker.parseDate(settings.parseFormat, value);
                result = true;
            } catch (err) {
                result = false;
            }
            return result;
        }, '');

    }

};


//var Main = function () {
//    var configureDatePicker = function (options) {

//        var defaults = {
//            format: "dd/mm/yyyy",
//            parseFormat: "dd/mm/yy",
//            weekStart: 1, // Monday
//            autoclose: true,
//            todayHighlight: true
//        },

//            settings = $.extend(defaults, options);

//        $(document).off('focus', '.datepicker');
//        $(document).on('focus', '.datepicker', function () {
//            $(this).datepicker(settings);
//        });
//    };

//    return {
//        configureDatePicker: configureDatePicker
//    }

//}();