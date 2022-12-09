<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    <link href="~/css/style-starter.css" rel="stylesheet" />
    <a href="~/fonts/fontawesome-webfont.eot"></a>
    <a href="~/fonts/fontawesome-webfont.ttf"></a>
    <a href="~/fonts/fontawesome-webfont.woff"></a>
    <a href="~/fonts/fontawesome-webfont.woff2"></a>
    <a href="~/fonts/FontAwesome.otf"></a>
    <script src="~/js/bootstrap.min.js"></script>
    <script src="~/js/jquery-1.7.2.js"></script>
    <script src="~/js/jquery-3.3.1.min.js"></script>
    <script src="~/js/jquery.countup.js"></script>
    <script src="~/js/jquery.prettyPhoto.js"></script>
    <script src="~/js/jquery.quicksand.js"></script>
    <script src="~/js/jquery.waypoints.min.js"></script>
    <script src="~/js/owl.carousel.js"></script>
    <script src="~/js/script.js"></script>
</head>
<body>
    <!-- header -->
    <header>
        <link href="@Url.Content("/css/style-starter.css")" rel="stylesheet" />
        <div class="w3l-header" id="home">
            <div class="container">
                <nav class="navbar navbar-expand-lg navbar-dark pl-0 pr-0">
                    <a class="navbar-brand m-0" @Html.ActionLink("Natz-kun", "Index", "Home") </a>
                    <!-- if logo is image enable this
                    <a class="navbar-brand" href="#index.html">
                        <img src="image-path" alt="Your logo" title="Your logo" style="height:35px;" />
                    </a> -->
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false"
                            aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon fa fa-bars"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarNav">
                        <ul class="navbar-nav ml-auto">
                            <li class="nav-item active mr-lg-4">
                                <a class="nav-link pl-0 pr-0" @Html.ActionLink("Home", "Index", "Home") </a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link pl-0 pr-0" @Html.ActionLink("Contact", "About", "Home")</a>
                            </li>


                        </ul>
                    </div>
                </nav>
            </div>
        </div>
    </header>
    <!-- //header -->
    <div>
        @RenderBody()
    </div>
    
</body>
</html>
