// Bootstrap ve jQuery entegrasyonu
$(document).ready(function () {
    // Menünün üstüne gelindiğinde açılması için
    $('.navbar-nav .dropdown').hover(function () {
        $(this).find('.dropdown-menu').stop(true, true).delay(200).fadeIn(200);
    }, function () {
        $(this).find('.dropdown-menu').stop(true, true).delay(200).fadeOut(200);
    });
});
$(document).ready(function () {
    // Tarih seçici için jQuery UI kullanımı
    $('input[placeholder="Giriş Tarihi"]').datepicker();
    $('input[placeholder="Çıkış Tarihi"]').datepicker();
});
$(document).ready(function () {
    function fetchTours() {
        var formData = $('#filter-form').serialize();
        $.ajax({
            url: '/Turlar/Filter',
            type: 'GET',
            data: formData,
            success: function (data) {
                $('#tour-list').html(data);
            },
            error: function () {
                alert('Turlar yüklenirken bir hata oluştu.');
            }
        });
    }

    // Filtreler değiştiğinde turları yeniden yükle
    $('#filter-form input').on('change', function () {
        fetchTours();
    });

    // Sayfa yüklendiğinde turları yükle
    fetchTours();
});
