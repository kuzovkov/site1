<!DOCTYPE html>
<html>
<head>
	<title>Test Player</title>
	
  <script src="js/jquery-1.11.0.min.js"></script>
   <script  src="js/mediaelement-and-player.min.js"></script
	
</head>
<body>
	<video width="640" height="267" poster="media/cars.png">
		<source src="http://site1.loc/test_player3/kinopoisk.ru-Hercules-213462.mp4" type="video/mp4">
	</video>

<script type="text/javascript">// <![CDATA[
$(document).ready(function() {
  $('video').mediaelementplayer({
    alwaysShowControls: true,
    videoVolume: 'horizontal',
    features: ['playpause','progress','volume','fullscreen']
  });
});
// ]]></script>

</body>
</html>
