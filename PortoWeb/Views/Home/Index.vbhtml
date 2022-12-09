@Code
    ViewData("Title") = "Home"
    Layout = "~/Views/_LayoutPage1.vbhtml"
End Code

<!--  Main banner section -->
<section class="w3l-main-banner">
    <div class="banner-view">
        <div class="banner-info container">
            <h3 class="banner-text">
                <small>Hello, I'm </small>
                Adrian Putradinata
            </h3>
            <p class="mt-3 mb-5">
                i just graduate from Institute Technology of Sumatera. Welcome to my Simple Portofolio
                This time i'll test my skill on ASP.Net. Certainly i like this programming language since the first time i open IDE. u can build any project with this
                language like Web, Mobile Apps, Dekstop Apps etc.
            </p><br>
          
        </div>
    </div>

    <div id='stars'></div>
    <div id='stars2'></div>
    <div id='stars3'></div>
</section>
<!--  //Main banner section -->
<!-- w3l-content-photo-5 -->
<div class="w3l-content-photo-5 py-5" id="about">
    <div class="content-main pt-lg-5 pt-md-3 pb-0">
        <div class="container">
            <div class="row">
                <div class="col-lg-4 content-photo">
                    <a href="#"><img src="~/images/image2.jpg" class="img-fluid" alt="content-photo"></a>
                </div>
                <div class="col-lg-8 content-left mt-lg-0 mt-5 ">
                    <h3>Lookin for Full Stack Developer Jobs</h3>
                    <p class="mb-0">
                        Sebagai fresh graduate aku akan menjalani karir dengan memulai full stack developer. Itu akan membuatku memiliki ilmu yang cukup dalam bidang Front End
                        maupun Back End Developer.
                    </p>
                    
                </div>
            </div>
        </div>
    </div>
</div>


<!-- iphone home block QUOTE -->

<section class="w3l-quote-main" id="client">
    <div class="quote py-5">
        <div class="container py-lg-5">
            <div class="row">
                <div class="col-lg-9">
                    <h4>
                        " Education never ends, Watson. It is a series of lessons, with the greatest for the last  "
                    </h4>
                </div>
                <div class="col-lg-3 mt-lg-0 mt-3 text-lg-center tablet-grid">
                    <img src="~/imageimages/client1.jpg" alt="" class="img-fluid" />
                    <div>
                        <h6 class="mb-0 mt-lg-3">Sherlock Holmes</h6>
                        <h5 class="mt-1">Series Sherlock Holmes </h5>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- home page blog  BLOG -->
<section class="w3l-blog py-5">
    <div class="container py-lg-5 py-md-3">
        <div class="row">
            <div class="col-lg-5">
                <h3>Beberapa Project Yang Pernah Saya Buat</h3>
                <h5 class="mt-3">Website / Mobile Apps / Dekstop Apps </h5>
                <p class="mt-4">
                    Website Dinas Pertanian Kota Bandar Lampung ( Back End Dev / Program Kerja Lapangan )
                    Website ini dimaksudkan untuk masyarakat dalam melihat data-data seputar pertanian dan peternakan kota Bandar Lampung
                    Aku membuat bagian Back-End dengan menambahkan menu Admin untuk admin melakukan posting kegiatan-kegiatan yang sudah dilakukan Dinas Pertanian Bandar Lampung
                    dan meng-update Data secara berkala.
                </p><p class="mt-5">
                    Aplikasi Sadahi Berbasis Augmented Reality ( Tugas Akhir )
                    Aplikasi Mobile ini berbasis Augmented Reality menggunakan bahasa C# yang dapat menampilkan informasi dan objek virtual 3D
                </p> <br />
                <p class="mt-6">
                    Aplikasi Dekstop Pendataan Barang Sayuran Sahabat Hidroponik ( Tugas Besar Mata Kuliah Proyek Perangkat Lunak )
                    Keluaran dari Project ini berupa aplikasi dekstop untuk pendataan barang / sayuran pada Sahabat Hidroponik dengan Saya sebagai Project Manager 
                    yang menghubungkan Team Developer dan Kebutuhan Client.
                </p>
            </div>
            <div class="col-lg-7 mt-lg-0 mt-4">
                <div class="img-block">
                    <a href="single.html">
                        <img src="~/images/WebDinas.jpg" class="img-fluid" alt="image" />
                        <span>A collection of Creative Website Design</span>
                    </a>
                </div>
               
                    </a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- //home page blog-->

<!-- Footer -->
<footer>
    <section class="w3l-footers-1">
        <div class="footer py-3">
            <div class="container">
                <div class="footer-content">
                    <div class="row">
                        <div class="col-lg-8 footer-left">
                            <p class="m-0">&copy; 2022 Gusti Made Adrian Putradinata </p>
                        </div>
                        <div class="col-lg-4 footer-right text-lg-right text-center mt-lg-0 mt-3">
                            <ul class="social m-0 p-0">
                                <li><a href="#facebook"><span class="fa fa-facebook"></span></a></li>
                                <li><a href="#linkedin"><span class="fa fa-linkedin"></span></a></li>
                                <li><a href="#instagram"><span class="fa fa-instagram"></span></a></li>
                                <li><a href="#twitter"><span class="fa fa-twitter"></span></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- move top -->
    <button onclick="topFunction()" id="movetop" class="editContent" title="Go to top">
        <span class="fa fa-angle-up"></span>
    </button>
    <script>// When the user scrolls down 20px from the top of the document, show the button
  window.onscroll = function () {
    scrollFunction()
  };

  function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
      document.getElementById("movetop").style.display = "block";
    } else {
      document.getElementById("movetop").style.display = "none";
    }
  }

  // When the user clicks on the button, scroll to the top of the document
  function topFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
  }</script>
    <!-- /move top -->
    <!-- common jquery -->
    <script src="~/js/jquery-3.3.1.min.js"></script>
    <!-- //common jquery -->
    <!-- disable body scroll which navbar is in active -->
    <script>$(function () {
    $('.navbar-toggler').click(function () {
      $('body').toggleClass('noscroll');
    })
  });</script>
    <!-- disable body scroll which navbar is in active -->
    <!-- for blog carousel slider -->
    <script src="~/js/owl.carousel.js"></script>
    <script>$(document).ready(function () {
    var owl = $('.owl-carousel');
    owl.owlCarousel({
      stagePadding: 20,
      margin: 15,
      nav: false,
      loop: false,
      responsive: {
        0: {
          items: 1
        },
        600: {
          items: 2
        },
        1000: {
          items: 3
        }
      }
    })
  })</script>
    <!-- //for blog carousel slider -->
    <!-- stats number counter-->
    <script src="~/js/jquery.waypoints.min.js"></script>
    <script src="~/js/jquery.countup.js"></script>
    <script>$('.counter').countUp();</script>
    <!-- //stats number counter -->
    <!-- jQuery-Photo-filter-lightbox-portfolio-plugin -->
    <script src="~/js/jquery-1.7.2.js"></script>
    <script src="~/js/jquery.quicksand.js"></script>
    <script src="~/js/script.js"></script>
    <script src="~/js/jquery.prettyPhoto.js"></script>
    <!-- //jQuery-Photo-filter-lightbox-portfolio-plugin -->
    <!--  bootstrap js -->
    <script src="~/js/bootstrap.min.js"></script>
    <!--  //bootstrap js -->

