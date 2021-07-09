$("#btn_Submit").click(function () {
    var obj = $("#frmCall").serializeObject();

    $.ajax({
        url: apiUrl,
        type: 'POST',
        data: obj,
        error: function (xhr, textStatus, errorThrown) {
            alert('Error');
        },
        success: function (data, textStatus, xhr) {
            //console.log(xhr.status);
        },
        complete: function (xhr, textStatus) {
            //console.log(xhr.status);
            if (xhr.status == 201) {
                location.href = url;
            }
        }
    });
});