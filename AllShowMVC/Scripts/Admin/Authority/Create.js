$("#btn_Submit").click(function () {

    elemRequiredArr.push("EmpNo");
    elemRequiredArr.push("AuthorityNo");
    ElementsValidAdd();

    //var validator = $("#frmCall").validate({
    //    rules: { EmpNo: { required: true }, AuthorityNo: { required: true } }
    //});
    if ($("#frmCall").valid()) {
        BaseFormSubmit("frmCall", 'POST', apiUrl, url);
    }
});