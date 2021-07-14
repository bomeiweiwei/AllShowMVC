/*
    函數：表單序列化
    備註：
        var objData = $('form').serializeObject();        
        var offID = objData["Offense_ID"];//取值
        資料處理...
*/
$.fn.serializeObject = function () {
    var o = {};
    var a = this.serializeArray();
    $.each(a, function () {
        if (o[this.name] !== undefined) {
            if (!o[this.name].push) {
                o[this.name] = [o[this.name]];
            }
            o[this.name].push(this.value || '');
        } else {
            o[this.name] = this.value || '';
        }
    });
    return o;
};

String.format = function () {
    var param = [];
    for (var i = 0, l = arguments.length; i < l; i++) {
        param.push(arguments[i]);
    }
    var statment = param[0]; // get the first element(the original statement)
    param.shift(); // remove the first element from array
    return statment.replace(/\{(\d+)\}/g, function (m, n) {
        return param[n];
    });
}

/*
    函數：轉成參數字串?key1=value1&key2=value2&key2=value3
    參數：
        obj => {key:value}
*/
function getParamstrByObj(obj) {
    var paramStr = '?';
    for (var key in obj) {
        if (obj.hasOwnProperty(key)) {
            if (Array.isArray(obj[key])) {
                obj[key].forEach(function (item, index, array) {
                    paramStr += (key + "=" + item + "&");
                });
            }
            else {
                paramStr += (key + "=" + obj[key] + "&");
            }
        }
    }
    var lastChar = paramStr.charAt(paramStr.length - 1);
    if (lastChar == '?')
        paramStr = '';
    else if (lastChar == '&')
        paramStr = paramStr.substring(0, paramStr.length - 1);

    return paramStr;
}

/*
    函數：url參數轉成物件{key:value}
    參數：
        url => xxx.ooo?test1=a&test2=2
*/
function getQueryStringObj(url) {
    var urlArr = new Array(); //定義一陣列
    urlArr = url.split('?'); //字元分割
    var query_string = {};
    if (urlArr.length > 1) {
        var query = urlArr[1];
        var vars = query.split("&");
        for (var i = 0; i < vars.length; i++) {
            var pair = vars[i].split("=");
            // If first entry with this name
            if (typeof query_string[pair[0]] === "undefined") {
                query_string[pair[0]] = pair[1];
                // If second entry with this name
            } else if (typeof query_string[pair[0]] === "string") {
                var arr = [query_string[pair[0]], pair[1]];
                query_string[pair[0]] = arr;
                // If third or later entry with this name
            } else {
                query_string[pair[0]].push(pair[1]);
            }
        }
    }
    return query_string;
}
/*
    函數：網站轉址
    參數：
        url => 要轉的位址
        data => 帶入參數
        isNewWindow => 是否另開視窗
*/
function RedirectPage(url, data, isNewWindow) {
    var form = $('<form></form>');
    $(form).hide().attr('method', 'post').attr('action', url);
    if (isNewWindow)
        $(form).attr('target', '_blank');
    for (var i in data) {
        if (i) {
            var input = $('<input type="hidden" />').attr('name', i).val(data[i]);
            $(form).append(input);
        }
    }
    //debugger;
    $(form).appendTo('body').submit();
    $(form).remove();
}
/*
    函數：表單Submit to webapi
    參數：
        formName => 表單名稱
        Method => POST、PUT
        apiUrl => Web Api網址
        url => 成功後導頁
*/
function BaseFormSubmit(formName, Method, apiUrl, url) {
    var obj = $("#" + formName).serializeObject();
    $.ajax({
        url: apiUrl,
        type: Method,
        data: obj,
        error: function (xhr, textStatus, errorThrown) {
            var jsonResponse = JSON.parse(xhr.responseText);
            var msg = jsonResponse.Message;
            var errObj;
            try {
                errObj = $.parseJSON(msg);
            } catch (e) {
                errObj = '';
            }
            if (typeof errObj == "object") {
                //設為object及Code代號為程式設定
                if (errObj.hasOwnProperty('Code') && errObj.Code == 1) {
                    var result = $.parseJSON('[' + errObj.Message + ']');
                    for (var i = 0; i < result[0].length; i++) {
                        $('span[data-valmsg-for="' + result[0][i].ValidateFiled + '"]').text(result[0][i].ValidateMessage);
                        $('span[data-valmsg-for="' + result[0][i].ValidateFiled + '"]').removeClass().addClass("field-validation-error").addClass("txtRed");
                        $('span[data-valmsg-for="' + result[0][i].ValidateFiled + '"]').show();
                    }
                }
                else {
                    ShowErrorMessage(ResErrorMsg);
                }
            } else if (typeof errObj == "string") {
                //ShowErrorMessage(msg);
                ShowErrorMessage(ResErrorMsg);
            }
        },
        success: function (data, textStatus, xhr) {
        },
        complete: function (xhr, textStatus) {
            if (xhr.status == 200 || xhr.status == 201) {
                location.href = url;
            }
        }
    });
}
/*
    函數：顯示錯誤訊息
    參數：
        msg => 訊息
*/
function ShowErrorMessage(msg) {
    var dialog = new BootstrapDialog({
        title: ResInformation,
        message: function (dialog) {
            var $message = $('<div>' + msg + '</div>');
            return $message;
        },
        closable: true
    });
    dialog.realize();
    dialog.getModalHeader().css('background-color', '#FF0000');
    dialog.open();
}
/*
    函數：新增需要動態驗證的欄位
*/
function ElementsValidAdd() {
    var errMsg = ResField_Require_InputMsg;
    elemRequiredArr.forEach(function (item) {
        $("#" + item).rules("add", {
            required: true,
            messages: {
                required: errMsg
            }
        });
    });
}
/*
    函數：刪除需要動態驗證的欄位
*/
function ElementsValidRemove() {
    elemRequiredArr.forEach(function (item) {
        $("#" + item).rules("remove");
    });
}