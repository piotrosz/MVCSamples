///<reference path='jquery.d.ts' />

$(document).ready(function () {

    $(".btn-slide").click(function () {
        $("#main").slideToggle("slow");
        $(this).toggleClass("active");
    });

});