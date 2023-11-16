$(function () {
    var el = document.getElementById('HidenEvent');
    if (el.addEventListener) {
        el.addEventListener("click", function () {
            var EventInformation = $("#HidenEvent");
            var NoiDung = $("#NoiDung")
            if ($("#HidenEvent").hasClass("EventInformation")) {
                console.log('click hidden');
                EventInformation.removeClass("EventInformation").addClass("EventInformationHidden");
                NoiDung.removeClass("NoiDung").addClass("NoiDungFullScreen");
            }
            else {
                console.log('click display');
                EventInformation.removeClass("EventInformationHidden").addClass("EventInformation");
                NoiDung.removeClass("NoiDungFullScreen").addClass("NoiDung");
            }
        }, false);
    } else { //IE8 support
        el.attachEvent("onclick", function () {
            alert("clicked");
        });
    }
});
