$(document).ready(function () {
    $("body #cssmenu li>ul").parent().addClass("has-sub");
    $("body #cssmenu li>:not(ul)").parent().addClass("last");

    $("body #cssmenu").find("li.has-sub>a").on('click', function () {
        $(this).removeAttr('href');
        var element = $(this).parent('li');
        if (element.hasClass('open')) {
            element.removeClass('open');
            element.find('li').removeClass('open');
            element.find('ul').slideUp();
        }
        else {
            element.addClass('open');
            element.children('ul').slideDown();
            element.siblings('li').children('ul').slideUp();
            element.siblings('li').removeClass('open');
            element.siblings('li').find('li').removeClass('open');
            element.siblings('li').find('ul').slideUp();
        }
    });
});