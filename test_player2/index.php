<!DOCTYPE html>
<html>
<head>
	<title>Test Player</title>
	<link href="js/video-js/video-js.css" rel="stylesheet" type="text/css">
  <script src="js/jquery-1.11.0.min.js"></script>
  <script src="js/video-js/video.js"></script>

 
  <script>
    videojs.options.flash.swf = "js/video-js/video-js.swf";
  </script>
	
</head>
<body>
	<video id="example_video_1" class="video-js vjs-default-skin" controls preload="none" width="640" height="264"
      data-setup="{}">
    <source src="http://site1.loc/test_player2/kinopoisk.ru-Hercules-213462.mp4" type='video/mp4' />
    <track kind="captions" src="demo.captions.vtt" srclang="en" label="English"></track><!-- Tracks need an ending tag thanks to IE9 -->
    <track kind="subtitles" src="demo.captions.vtt" srclang="en" label="English"></track><!-- Tracks need an ending tag thanks to IE9 -->
    <p class="vjs-no-js">To view this video please enable JavaScript, and consider upgrading to a web browser that <a href="http://videojs.com/html5-video-support/" target="_blank">supports HTML5 video</a></p>
  </video>



</body>
</html>
