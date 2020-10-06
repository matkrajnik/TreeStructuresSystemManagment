var loadEdit = function (categoryID) {
        $.ajax({
            type: 'POST',
            url: "TreeStructure/EditPartial",
            data: { "Id": categoryID },
            success: function (response) {
                $('#modalBody').html(response);
                $('#edit-modal').modal('show');
            }
        })
    }
