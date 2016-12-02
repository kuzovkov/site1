<!DOCTYPE html>
<html>
<head>
<link rel="stylesheet" href="magnific-popup.css"> 

<!-- jQuery 1.7.2+ or Zepto.js 1.0+ -->
<script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script> 

<!-- Magnific Popup core JS file -->
<script src="jquery.magnific-popup.js"></script>

</head>
<body>

<div class="gallery">
    <a href="slide1.jpg"><img width="100" src="slide1.jpg"/></a>
    <a href="slide2.jpg"><img width="100" src="slide2.jpg"/></a>
</div>
<div class="gallery">
    <a href="slide3.jpg"><img width="100" src="slide3.jpg"/></a>
    <a href="slide4.png"><img width="100" src="slide4.png"/></a>
    <a href="slide1.jpg" class="mfp-iframe"><img width="100" src="slide1.jpg"/></a>
</div>
<script type="text/javascript">
$('.gallery').each(function() { // the containers for all your galleries
    $(this).magnificPopup({
        delegate: 'a', // the selector for gallery item
        type: 'image',
        gallery: {
          enabled:true
        }
    });
}); 

</script>

</body>
</html>

 