
function Common_AjaxGET(url, paramObj) {
    var resultData;
    $.ajax({
        url: url,
        async: false,
        data: paramObj,
        success: function (result) {
            resultData = result;
        },
        datatype: "json"
    });
    return resultData;
}

function Common_AjaxPOST(url, obj) {

    var data;
    $.ajax({
        type: "POST",
        url: url,
        data: obj,
        async: false,
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (result) {
            data = result;
        },
        complete: function (xhr, statusText) {
            if (data == null || data == "") {
                data = {
                    "statusCode": xhr.status, "statusText": statusText
                };
            }
        },
        error: function (result) {
            //data = JSON.parse(result.responseText);
        }

    });

    return data;
}

//Success Alert
function SuccessAlert(msg) {
    $.gritter.add({        
        title: 'Success!!',        
        text: msg,
        class_name: 'gritter-success'
    });
}

//Fail Alert
function FailureAlert(msg) {
    $.gritter.add({
        title: 'Error!!',
        text: msg,
        class_name: 'gritter-error'
    });
}
