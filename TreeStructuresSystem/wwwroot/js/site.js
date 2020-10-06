$('.menu').click(function () {
    $(this).parent('li').children('.options').toggleClass('hidden');
    $('.menu').not(this).parent('li').children('.options').addClass('hidden');
    $(this).parent().children('span').children('i').toggleClass('fa-info-circle');
    $(this).parent().children('span').children('i').toggleClass('fa-times-circle');
});

$('.tree-collapse').click(function () {
    $(this).parent('li').children('ul').collapse('toggle');
    $(this).parent().children('#menu').children('i').toggleClass('fa-plus');
    $(this).parent().children('#menu').children('i').toggleClass('fa-minus');
});

$('.collapse-all').click(function () {
    $('.collapsive').collapse('toggle');
});