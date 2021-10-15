
if (document.getElementById("costInput").value !== '') {
    document.getElementById('modal').style.display = 'block';
} else {
    document.getElementById('modal').style.display = 'none';
}

$(function () {
    $("form[name='order']").validate({
        success: "valid",
        onkeyup: true,
        focusInvalid: true,
        errorClass: "error",
        highlight: function (element, errorClass) {
            $(element).fadeOut(function () {
                $(element).fadeIn();
                $(element).addClass(errorClass);
            });
        },
        rules: {
            Height: {
                required: true,
            },
            Width: {
                required: true,
            },
            Depth: {
                required: true,
            },
            Weight: {
                required: true,
            },
            Courier: {
                required: true,

            }
        },
        messages: {
            Height: {
                required: "Please Enter Valid Height in CM!"
            },
            Width: {
                required: "Please Enter Valid Width in CM!"
            },
            Depth: {
                required: "Please Enter Valid Height in CM!"
            },
            Weight: {
                required: "Please Enter Valid Height in Kg!"
            },
            Courier: {
                required: "Please Chose Courier!"
            }
        },
        submitHandler: function (form) {
            form.submit();
        }
    });
});


// *** AJAX FOR ORDER

function Order() {
    var data = {
        Width: $("#Width").val(),
        Depth: $("#Depth").val(),
        Height: $("#Height").val(),
        Weight: $("#Weight").val(),
        CourierName: $("#CourierName").val(),
        CourierId: $("#CourierId").val(),
        Cost: $("#costInput").val(),
        UserId: $("#UserId").val()
    };

    $.ajax({
        type: "POST",
        url: "/Home/Order",
        data: { package: data },
        success: function (data) {
            $("#OrderModal").modal("toggle");
            console.log("Work");
            console.log(data);
        },
        error: function () {
            console.log("Dont Work");
        }
    });
}