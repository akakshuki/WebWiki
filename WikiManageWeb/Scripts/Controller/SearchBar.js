var SearchBarController = {
    init: function() {
        SearchBarController.registerEvent();
    },
    registerEvent: function() {
        $("#Searchtxt").keyup(function() {
            $('#autoCompleteSearch').show();;
            SearchBarController.GetListautoComplete();
        });
      
    },
    GetListautoComplete: function () {
        $.ajax({
            url: "/Menu/SearchProduct/",
            type: 'GET',
            dataType: 'json',
            data: {
                name: $("#Searchtxt").val()
            }, success: function (response) {
                var data = response.data;
                var html = '';
                var template = $('#data-template').html();
                $.each(data,
                    function (i, item) {
                        html += Mustache.render(template,
                            {
                                ID: item.ID,
                                Name: item.Title
                               });
                    });
                $('#autoCompleteSearch').html(html);
            }

    });
    }
    
}
SearchBarController.init();