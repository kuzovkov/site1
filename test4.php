<?php

require_once( 'Http.class.php' );

const PATH_TO_SAVE = 'c:/www3/site1/trail';
const LOG_FILE = 'c:/www3/site1/trail/download.log';

$headers = array(
				 'Cache-Control: max-age=0',
				 'Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8',
				 'Accept-Encoding: ',
				 'Accept-Language: ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4'

				);


if ( $_SERVER['REQUEST_METHOD'] == 'POST' )
{
	$url = $_POST['url'];
	if ( strrpos( $url, '/' ) !== ( strlen($url) - 1 ) ) $url .= '/';
	$base_url = 'http://kp.cdn.yandex.net/';
	$result = 1;

	$content = Http::SendRequest( $url, false, $headers );

	$pos = strpos($content,'"trailerFile":');
	if ( $pos === false ) $pos = strpos($content,"'trailerFile':");
	$str = substr( $content, $pos, 100 );
				
	$regV = '/[0-9]{1,}\/kinopoisk\.ru[_0-9a-zA-Z\-\.]{3,}/';
	$array = array( 0, 0 );
	preg_match( $regV, $str, $array );
				
	$trailerUrl = ( isset( $array[0] ))? $base_url . $array[0] : false;
	$trailerUrl = trim( $trailerUrl );
	echo '<br/>' . $trailerUrl; 
	
	if ( $trailerUrl )
	{
		$command = "start php download.php ". $trailerUrl. " " . PATH_TO_SAVE . " " . LOG_FILE;
		exec( $command, $output );
	}
	else
	{
		echo '<p>Fail get trailrt URL</p>';
	}
	
}



?>

<form id="form1" action = "test4.php" method="post">
URL:<input type="text" size="50" name="url" value="http://www.kinopoisk.ru/film/722253/video/"/><br/>
<input id="submit" type="submit" value="Загрузить трейлер"/>	

</form>
<div id="preload"><img src='loader.gif'/></div>

<script type="text/javascript">
	
	var preload = document.getElementById("preload");
	preload.style.display="none";
	var form = document.getElementById("form1");
	var btn = document.getElementById("submit");
	
	form.onsubmit=function(){ preload.style.display="block"; btn.setAttribute('disabled','disabled');};

</script>	