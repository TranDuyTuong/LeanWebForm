function Btn_Login() {
    $.ajax({
        url: "_Default/Login",
        type: "GET",
        data: {
            Email: $("#TxtEmail").val(),
            Password: $("#TxtPassword").val()
        },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            alert(result);
        }
    })
}