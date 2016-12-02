<!DOCTYPE html>
<html>
<head>

<script type="text/javascript" src="/jwplayer/jwplayer.js"></script>
<script type="text/javascript">jwplayer.key="+w2dT5h4jJ27TMTalFPJE/IWsZ2cIzBT0BxnHA==";</script>

</head>
</body>
<!--
<div class="v-player">
<iframe src="http://site1.loc/trailers/Maleficent.mp4" width="600" height="320" frameborder="0" allowfullscreen="allowfullscreen">
</iframe></div>



<video width="400" height="300" controls="controls" autoplay="autoplay"> 
<source src="http://site1.loc/trailers/Maleficent.mp4" type='video/mp4; codecs="avc1.42E01E, mp4a.40.2"' >
Тег video не поддерживается вашим браузером. 
   <a href="http://site1.loc/trailers/Maleficent.mp4">Скачайте видео</a>
</video> 
-->


<div id="myElement">Loading the player...</div>
<script type="text/javascript">
    jwplayer("myElement").setup({
        file: "http://site1.loc/trailers/Maleficent.mp4",
        //image: "http://example.com/uploads/myPoster.jpg",
        width: 640,
        height: 360,
		autostart: true
    });
</script>

</body>
</html>