// Bootstrap ve jQuery entegrasyonu
$(document).ready(function () {
    // Menünün üstüne gelindiğinde açılması için
    $('.navbar-nav .dropdown').hover(function () {
        $(this).find('.dropdown-menu').stop(true, true).delay(200).fadeIn(200);
    }, function () {
        $(this).find('.dropdown-menu').stop(true, true).delay(200).fadeOut(200);
    });
});
