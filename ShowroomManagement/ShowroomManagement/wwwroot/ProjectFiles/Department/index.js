$(document).ready(function () {
    loadData()
});
//----------Load Data Fromn API------------------

function loadData() {
    $.ajax({
        url: APIURLS.department_DetDepartments,
        type: 'GET',
        data: null,

        success: function (resp) {
            var data = JSON.parse(resp)

            for (let item of data.Response) {
                $('#example1 tbody').append(`
                <tr>
                <td>${item.Name}</td>  
                <td>${item.Description}</td>
                </tr>

                `);

            }



         }
            
        }

    }),
}