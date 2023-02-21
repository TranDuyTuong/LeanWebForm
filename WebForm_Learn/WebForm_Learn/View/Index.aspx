<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebForm_Learn.View.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Danh Sách Tỉnh Thành Phố</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="col-md-12">
                    <div class="row">
                        <table class="table">
                            <thead>
                                <tr>
                                    <th scope="col">Stt</th>
                                    <th scope="col">Tên Tỉnh/Tp</th>
                                    <th scope="col">Ngày Tạo</th>
                                    <th scope="col">Thời Gian</th>
                                    <th scope="col">Lựa Chọn</th>
                                </tr>
                            </thead>
                            <tbody id="BodyCity"> 
                            </tbody>
                        </table>
                    </div>
                </div>
                <br />
            </div>
            <script type="text/javascript">
                $(document).ready(function () {
                    LoadCity();
                });

                function LoadCity() {
                    $("#BodyCity").empty();
                    var count = 0;
                    $.ajax({
                        type: "POST",
                        url: "Index.aspx/ListCity",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (result) {
                            $.each(result.d, function (key, item) {
                                count++;
                                var html = "";
                                html += '<tr id=' + item.IdCity + '>';
                                html += '<th scope="row">' + count + '</th>'
                                html += '<td>' + item.NameCity + '</td>'
                                html += '<td>' + item.Dates + '</td>'
                                html += '<td>' + item.Time + '</td>'
                                html += '</tr>';
                                $("#BodyCity").append(html);
                            });
                        }
                    })
                }
            </script>
            <%--<script src="../MyJavascript/IndexJS.js" asp-append-version="true"></script>--%>
        </div>
    </form>
</body>
</html>
