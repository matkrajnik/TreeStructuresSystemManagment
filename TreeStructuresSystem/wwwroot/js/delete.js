var url;
var redirectUrl;
var target;


/**
 * Showing pop-up window to add node
 * */
$('.delete').on('click', (e) => {
    e.preventDefault();
    target = e.target;
    var bodyMessage = $(target).data('body-message');
    $('.modal-body-message').text(bodyMessage);
    $('#delete-modal').modal('show');
});

/**
 * Confirm Action
 * */
$('#confirm-delete').on('click', (e) => {
    var Id = $(target).data('id');
    Delete(Id, e);
});

function Delete(id, event) {
    var ev = event;
    var categoryObj = {
        Name: $('#name').val(),
        ParentID: id,
    };

    $.ajax({
        url: "/TreeStructure/Delete/" + id,
        data: JSON.stringify(categoryObj),
        type: "DELETE",
        contentType: "application/json:charset=UTF-8",
        dataType: "json",
        success: function (data) {
            $('#delete-modal').modal('hide');
            setInterval(() => location.reload(true), 300);
        },
        error: function (data) { 
        }
    });
    return this.data;
}