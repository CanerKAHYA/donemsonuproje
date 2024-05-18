// nav menu style
var nav = $("#navbarSupportedContent");
var btn = $(".custom_menu-btn");
btn.click
btn.click(function (e) {

    e.preventDefault();
    nav.toggleClass("lg_nav-toggle");
    document.querySelector(".custom_menu-btn").classList.toggle("menu_btn-style")
});


function getCurrentYear() {
    var d = new Date();
    var currentYear = d.getFullYear()

    $("#displayDate").html(currentYear);
}

getCurrentYear();

  
// Arka plan resimlerinin URL'lerini bir diziye tanımlayın
var backgroundImages = [
    'url(/images/mountain.jpg)',
    'url(/images/mountain1.jpg)',
    'url(/images/mountain2.jpg)'
  ];

  var currentIndex = 0;

  function changeBackground() {
    document.querySelector('.hero_area').classList.add('fade-out'); // Arka planı yavaşça solmayı başlat

    setTimeout(function() {
      document.querySelector('.hero_area').style.backgroundImage = backgroundImages[currentIndex];
      currentIndex++;
      if (currentIndex >= backgroundImages.length) {
        currentIndex = 0;
      }
      document.querySelector('.hero_area').classList.remove('fade-out'); // Solma animasyonunu kaldır
    }, 1000); // 1 saniye sonra resmi değiştir
  }

  setInterval(changeBackground, 5000);