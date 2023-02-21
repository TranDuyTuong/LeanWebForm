function CheckPassword() {
    $("#ErrorNotifi").empty();
    var G_Email = $("#TxtEmail").val();
    var G_Password = $("#TxtPassword").val();
    $.ajax({
        type: "POST",
        url: "View/Login.aspx/Login_v",
        data: JSON.stringify({ Email: G_Email, Password: G_Password }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            switch (result.d.Id) {
                case 2:
                    $("#ErrorNotifi").append(result.d.Message);
                    break;
                default:
                    window.location.href = result.d.Message;
                    break;
            }
        }
    })
}
$(document).ready(function () {
    $("#Btn_LoginAjax").click(function (e) {
        CheckPassword();
        e.preventDefault();
    });
});