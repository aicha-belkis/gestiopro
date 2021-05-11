$(function () {

    var PlaceHolderElement = $('#PlaceHolderHere');
    $('button[data-toggle="ajax_modal"]').click(function (event)
        var url = $(this).data('url');
    $.get(url).done(function (data) {

        PlaceHolderElement.html(data);
        PlaceHolderElement.find('.modal').modal('show');


    })
     
})
PlaceHolderElement.on('click', '[data-save="modal"]', function (event) {
    var from = $(this).parents('.modal').find('from');
    var actionUrl = from.attr('action');
    var sendData = from.serialize();
    $.post(actionUrl, sendData).done(function (data) {

        PlaceHolderElement.find('.modal').modal('hide');


        })
       
})
})