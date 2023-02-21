﻿function CheckPassword() {
    var G_Email = $("#TxtEmail").val();
    var G_Password = $("#TxtPassword").val();
    $.ajax({
        type: "POST",
        url: "Index.aspx/Login",
        data: JSON.stringify({ Email: G_Email, Password: G_Password }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            console.log(result);
        }
    })
}
$(document).ready(function () {
    $("#Btn_LoginAjax").click(function (e) {
        CheckPassword();
        e.preventDefault();
    });
});