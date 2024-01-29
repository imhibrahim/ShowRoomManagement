$(document).ready(function () {
    loadData()
    alert()
});
//----------Load Data Fromn API------------------

function loadData() {
        alert(),
    $.ajax({
        url: APIURLS.department_GetDepartments,
        type: 'GET',
        data: null,

        success: function (resp) {
            var data = JSON.parse(resp)
            alert();
            console.log(data.Response);
            for (let item of data.Response) {
                $('#example1 tbody').append(`
                <tr>
                <td>${item.Name}</td>
                <td>${item.Description}</td>
                </tr>
                `);


            }
        }

        })

        }



            //$("#example1").DataTable({
            //    dom: 'lBfrtip',
            //    "responsive": true, "lengthChange": false, "autoWidth": false,
            //    "buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]
            //}).buttons().container().appendTo('#example1_wrapper .col-md-6:eq(0)');
            //$('#example2').DataTable({
            //    "paging": true,
            //    "lengthChange": false,
            //    "searching": false,
            //    "ordering": true,
            //    "info": true,
            //    "autoWidth": false,
            //    "responsive": true,
            //});
