function validateControls() {
    var isEmty = false;
    var name = $('#txtName').val();
    if (name == "" || name= null) {
        isEmty = true
        $('#ErrorName').text("This Is a Requird Feild");
        $('#ErrorName').addClass('border border-danger')


    }
     
}
$('#txtName').on('change', function () {
    var val = $(this).val();
    if (val == '' || val == null) {
        $('#ErrorName').text("This Is a Requird Feild");
        $('#ErrorName').addClass('border border-danger')
    }
    else {
        $('#ErrorName').emty();
        $('#ErrorName').removeClass('border border-danger')
    }
})


$('#btnsubmit').on('click', function () {
    if (!validateControls()) { 
    var name = $('#txtName').val();
        var description = $('#txtDescription').val();

        var obj = {
            "Name": name,
            "Description": description
        };




        $.ajax({
            url: APIURLS.department_AddDepartments,
            data: JSON.stringify(obj),
            contentTupe:"application/json", 
            type: 'post',
            success: function (resp) {
                console.log(resp);

            }


        })
        
    }
 
});