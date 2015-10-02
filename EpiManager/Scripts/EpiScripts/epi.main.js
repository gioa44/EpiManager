var Main = {
    configureDatePicker: function (options) {

        var defaults = {
            format: "dd/mm/yyyy",
            parseFormat: "dd/mm/yy",
            weekStart: 1, // Monday
            autoclose: true,
            todayHighlight: true
        };

        var settings = $.extend(defaults, options);

        $(document).off("focus", '.datepicker');
        $(document).on('focus', '.datepicker', function () {
            $(this).datepicker(settings);
        });
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