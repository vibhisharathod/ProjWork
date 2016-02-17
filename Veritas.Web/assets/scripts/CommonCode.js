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