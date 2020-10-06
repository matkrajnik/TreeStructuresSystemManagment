var target;

/**
 * Showing pop-up window to add node
 * */
$(".add").on('click', (e) => {
    e.preventDefault();
    target = e.target;
     var bodyMessage = $(target).data('body-message');

     $('.modal-body-message').text(bodyMessage);
     $('#add-modal').modal('show');
});

/**
 * Confirm Action
 * */
$('#confirm-add').on('click', (e) => {
    var Id = $(target).data('id');
    if ($('#name').length < 1) {
        $('add-input-name').val("This field is required and should contain at least 1 characters!");
        console.log("DUPA")
    } else {
        Add(Id, e);
    }
    
});

/**
 * Add request
 */
function Add(id, event) {
    var ev = event;
    var categoryObj = {
        Name: $('#name').val(),
        ParentID: id,
    };
    if (categoryObj.Name.length < 1) {
   
        $('#add-error').text("This field is required and should contain at least 1 characters!");
    } else {
           $.ajax({
               url: "/TreeStructure/Create",
               data: JSON.stringify(categoryObj),
               type: "POST",
               contentType: "application/json:charset=UTF-8",
               dataType: "json",
               success: function (data) {
                   $('#add-modal').modal('hide');
                   setInterval(() => location.reload(true), 300);
               },
               error: function (data) {
                }
            });
        }
   
    return this.data;
}