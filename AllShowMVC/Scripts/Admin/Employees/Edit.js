$(document).ready(function () {
    if ($('#ChangePwd').is(":checked")) {
        $("#EmpPwd").attr('disabled', false);
        $("#ConfirmPassword").attr('disabled', false);
    } else {
        $("#EmpPwd").attr('disabled', true);
        $("#ConfirmPassword").attr('disabled', true);
    }
});

$('#ChangePwd').change(function () {
    if (this.checked) {
        $("#EmpPwd").attr('disabled', false);
        $("#ConfirmPassword").attr('disabled', false);
    } else {
        $("#EmpPwd").attr('disabled', true);
        $("#ConfirmPassword").attr('disabled', true);
    }
});
