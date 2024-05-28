document.addEventListener('DOMContentLoaded', function() {
    var citySelect = document.getElementById('citySelect');
    var navigateButton = document.getElementById('navigateButton');

    if (citySelect && navigateButton) {
        navigateButton.addEventListener('click', function() {
            var selectedValue = citySelect.value;
            if (selectedValue != '-1') {
                // Şehir adını al ve küçük harfe çevir
                var cityName = citySelect.options[citySelect.selectedIndex].value.toLowerCase();
               
                // URL oluştur
                var url = 'https://avbisresim.tarimorman.gov.tr/AVBIS/AvlakHaritalari/'+ cityName +'.jpg';
                // Yönlendir
                window.location.href = url;
            } else {
                alert('Lütfen bir şehir seçiniz.');
            }
        });
    } else {
        console.error('citySelect veya navigateButton bulunamadı.');
    }
});