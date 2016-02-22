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