var Main = {
    InitDatePicker: function(options) {

        var defaults = {
            format: "dd/MM/yyyy",
            parseFormat: "dd/MM/yyyy",
            weekStart: 1, // Monday
            autoclose: true,
            todayHighlight: true
        };

        var settings = $.extend(defaults, options);

        $(document).off("focus", ".datepicker");
        $(document).on("focus", ".datepicker", function() {
            $(this).datepicker(settings);
        });
    },

    InitOnFlyCustomerCreation: function(formId) {
        $(formId).on("submit", function(event) {
            event.preventDefault();

            $(this).validate();
            if (!$(this).valid())
                return false;

            var submitUrl = $(this).attr("action");

            $.ajax({
                async: false,
                type: "POST",
                url: submitUrl,
                data: $(this).serialize(),
                dataType: "text",
                processData: false,
                contentType: "application/x-www-form-urlencoded"
            }).done(function(data) {
                $("#NewCustomerModal").modal("hide");

                if (!data)
                    return;

                var newCustomer = JSON.parse(data);
                if (!newCustomer)
                    return;

                $(".customer-select2").select2("data", { "id": newCustomer.id.toString(), "text": newCustomer.text});
            });

            return true;
        });
    },

    InitCustomerSelector: function () {
        var select2Element = $(".customer-select2").select2({
            width: "resolve",
            minimumInputLength: 2,
            delay: 250,
            placeholder: "აირჩიეთ კლიენტი",
            ajax: {
                url: "/Epi/Customers",
                dataType: "json",
                data: function(term) {
                    return {
                        searchTerm: term
                    };
                },
                results: function(data) {
                    return { results: data };
                }
            }
        });

        return select2Element;
    },

    InitSelect2: function () {
        $("select:not(.ignore)").select2({ width: "resolve" });
    }
};