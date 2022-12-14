@Code
    ViewData("Title") = "Contact"
    Layout = "~/Views/_LayoutPage1.vbhtml"
End Code

<!-- contact form -->
<section class="w3l-contacts-12 py-5" id="contact">
    <div class="container py-md-3">
        <div class="contacts12-main">
            <div class="title-section">
                <h3 class="main-title-w3 mb-md-5 mb-4">
                    Want to get in touch? <br>Find me on
                    <a href="tel:+12-331-456-789" class="editContent">phone</a>,
                    <a href="mailto:mymail@mail.com" class="editContent">email</a>,
                    <a href="#twitter" class="editContent">twitter</a>
                    or <a href="#linkedin" class="editContent">linkedin</a>.
                </h3>
            </div>
            <form action="https://sendmail.w3layouts.com/submitForm" method="post" class="">
                <div class="main-input">
                    <input type="text" name="w3lName" placeholder="Enter your name" class="contact-input" required="" />
                    <input type="email" name="w3lSender" placeholder="Enter your mail" class="contact-input" required="" />
                    <input type="email" name="w3lSubject" placeholder="Subject" class="contact-input" />
                    <textarea class="contact-textarea contact-input" name="w3lMessage" placeholder="Enter your message" required=""></textarea>
                </div>
                <div class="text-right">
                    <button class="btn-primary btn btn-style">Send</button>
                </div>
            </form>
        </div>
    </div>
</section>
<!-- //contact form -->
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
