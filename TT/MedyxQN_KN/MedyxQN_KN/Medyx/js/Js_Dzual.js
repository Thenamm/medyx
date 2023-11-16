//class: "checkNullControl", "checkInt", "checkDecimal", "checkNamSanXuat"
//Atrribute: AttrMaxControl, AttrMinControl

function Dzual_trimSpace(thisControl)
{
    while(thisControl[0] == ' ')
    {
        thisControl = thisControl.substring(1,thisControl.length);
    }
    return thisControl;
}

function Dzual_CheckNull(checkNullControl) {
    if (checkNullControl.value == null || checkNullControl.value == "") {
        alert("Dữ liệu không được để trống");
        checkNullControl.focus();
        return false;
    }
    return true;
}

function Dzual_CheckInt(checkInt) {
    if (Dzual_CheckNull(checkInt)) {
        for (var i = 0; i < checkInt.value.length; i++) {
            if ("1234567890,".split(checkInt.value[i]).length == 1) {
                alert("Yêu cầu nhập dữ liệu kiểu số nguyên");
                checkInt.focus();
                return false;
            }
        }
        _checkInt = checkInt.value;
        while (_checkInt.indexOf(',') != -1) {
            _checkInt = _checkInt.replace(',', '');
        }

        ValueInt = '';
        for (var i = _checkInt.length; i > 0; i--) {
            if ((i) % 3 == 0 && i != _checkInt.length) {
                ValueInt = ',' + ValueInt;
            }
            ValueInt = _checkInt[i - 1] + ValueInt;
        }
        checkInt.value = ValueInt;
    }
    else {
        return false;
    }
    return true;
}

function Dzual_CheckDecimal(checkDecimal) {
    if (Dzual_CheckNull(checkDecimal)) {
        for (var i = 0; i < checkDecimal.value.length; i++) {
            if ("1234567890.,".split(checkDecimal.value[i]).length == 1) {
                alert("Yêu cầu nhập dữ liệu kiểu số");
                checkDecimal.focus();
                checkDecimal.value = '';
                return false;
            }
        }
        var arrayCheckDecimal = checkDecimal.value.split('.');
        if ((arrayCheckDecimal != null) && ((arrayCheckDecimal.length > 2) || (arrayCheckDecimal.length == 2 && (arrayCheckDecimal[0].length + 1) < checkDecimal.value.lastIndexOf(',')))) {
            alert("Yêu cầu nhập dữ liệu kiểu số");
            checkDecimal.focus();
            checkDecimal.value = '';
            return false;
        }

        _CheckDecimal = checkDecimal.value.substring(0, checkDecimal.value.lastIndexOf('.'));
        while (_CheckDecimal.indexOf(',') != -1) {
            _CheckDecimal = _CheckDecimal.replace(',', '');
        }

        ValueDecimal = '';
        for(var i=_CheckDecimal.length; i > 0; i --)
        {
            if ((i) % 3 == 0 && i != _CheckDecimal.length) {
                ValueDecimal = ',' + ValueDecimal;
            }
            ValueDecimal = _CheckDecimal[i-1] + ValueDecimal;
        }
        checkDecimal.value = ValueDecimal;
    }
    else {
        checkDecimal.value = '';
        return false;
    }
    return checkDecimal.value;
}

function Dzual_CheckNamSanXuat(checkNamSanXuat) {
    if (Dzual_CheckNull(checkNamSanXuat)) {
        if (eval(checkNamSanXuat.value) < 1900 || eval(checkNamSanXuat.value) > new Date().getFullYear()) {
            alert('Năm sản xuất không được vượt quá năm hiện tại và không được nhỏ hơn năm 1900');
            checkNamSanXuat.focus();
            return false;
        }
    }
    else {
            return false;
    }
    return true;
}

function Dzual_CheckIntMaxControl(checkInt, AttrMaxControl) {
    if (Dzual_CheckInt(checkInt)) {
        if (AttrMaxControl != null) {
            if (eval(checkInt.value) > eval(AttrMaxControl)) {
                alert("Yêu cầu dữ liệu nhập vào phải nhỏ hơn hoặc bằng " + AttrMaxControl);
                checkInt.focus();
                return false;
            }
        }
    }
    else {
        return false;
    }
    return true;
}

function Dzual_CheckIntMinControl(checkInt, AttrMinControl) {
    if (Dzual_CheckInt(checkInt)) {
        if (AttrMaxControl != null) {
            if (eval(checkInt.value) < eval(AttrMinControl)) {
                alert("Yêu cầu dữ liệu nhập vào lớn hơn hoặc bằng " + AttrMinControl);
                checkInt.focus();
                return false;
            }
        }
    }
    else {
        return false;
    }
    return true;
}

function Dzual_CheckDecimalMaxControl(checkDecimal, AttrMaxControl) {
    if (Dzual_CheckDecimal(checkDecimal)) {
        if (AttrMaxControl != null) {
            if (eval(checkDecimal.value) > eval(AttrMaxControl)) {
                alert("Yêu cầu dữ liệu nhập vào phải nhỏ hơn hoặc bằng " + AttrMaxControl);
                checkDecimal.focus();
                return false;
            }
        }
    }
    else {
        return false;
    }
    return true;
}

function Dzual_CheckDecimalMinControl(checkDecimal, AttrMinControl) {
    if (Dzual_CheckDecimal(checkDecimal)) {
        if (AttrMaxControl != null) {
            if (eval(checkDecimal.value) < eval(AttrMinControl)) {
                alert("Yêu cầu dữ liệu nhập vào lớn hơn hoặc bằng " + AttrMinControl);
                checkDecimal.focus();
                return false;
            }
        }
    }
    else {
        return false;
    }
    return true;
}


function Dzual_EnterForcusControl() {
    var $Obj_Obj = $("label[id*=rdo], input[id*=cbo]:text:enabled:visible, input[id*=txt]:text:enabled:visible, input[id*=dt]:text:enabled:visible, input[id*=ch]:text:enabled:visible");
    $Obj_Obj.bind('keydown', function (e) {
        if (e.which == 13) {// Khi bàn phím nhấn phím Enter hoặc phím tab
            e.preventDefault();
            var index = $Obj_Obj.index(this);
            var $ObjControl = $Obj_Obj[index];

            //Kiểm tra lại coltrol xem có thuộc tính classValueNull không nếu có thì phải checks null
            var $ObjClass = $($ObjControl).attr("class");

            // Check Number với class: checkNumber
            if ($ObjClass != null && $ObjClass.indexOf('checkInt') >= 0 && !Dzual_CheckInt($ObjControl)) {
                return false;
            }
            if ($ObjClass != null && $ObjClass.indexOf('checkDecimal') >= 0 && !Dzual_CheckDecimal($ObjControl)) {
                return false;
            }
            // Check Number với class: checkNamSanXuat
            if ($ObjClass != null && $ObjClass.indexOf('checkNamSanXuat') >= 0 && !Dzual_CheckNamSanXuat($ObjControl)) {
                return false;
            }
            // Check Number với class: checkNullControl
            if ($ObjClass != null && $ObjClass.indexOf('checkNullControl') >= 0 && !Dzual_CheckNull($ObjControl)) {
                return false;
            }
            //Check Number với class: checkInt, AttrMaxControl
            if ($ObjClass != null && $ObjClass.indexOf('checkInt') >= 0 && $($ObjControl).attr("AttrMaxControl") != null && !Dzual_CheckIntMaxControl($ObjControl, $($ObjControl).attr("AttrMaxControl"))) {
                return false;
            }

            //Check Number với class: checkInt, AttrMinControl
            if ($ObjClass != null && $ObjClass.indexOf('checkInt') >= 0 && $($ObjControl).attr("AttrMinControl") != null && !Dzual_CheckIntMinControl($ObjControl, $($ObjControl).attr("AttrMinControl"))) {
                return false;
            }

            //Check Decimal với class: checkInt, AttrMaxControl
            if ($ObjClass != null && $ObjClass.indexOf('checkDecimal') >= 0 && $($ObjControl).attr("AttrMaxControl") != null && !Dzual_CheckDecimalMaxControl($ObjControl, $($ObjControl).attr("AttrMaxControl"))) {
                return false;
            }

            //Check Decimal với class: checkInt, AttrMinControl
            if ($ObjClass != null && $ObjClass.indexOf('checkDecimal') >= 0 && $($ObjControl).attr("AttrMinControl") != null && !Dzual_CheckDecimalMinControl($ObjControl, $($ObjControl).attr("AttrMinControl"))) {
                return false;
            }

            // Chuyển sang cotrol khác để focus
            index = index + 1;
            $ObjControl = $Obj_Obj[index];
            $Obj_Obj[index].focus();
            return true;
        }
    });
}

