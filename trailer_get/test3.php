<?php

//require_once( 'simple_html_dom.php' );
require_once( 'Http.class.php' );

const ENCODE_SOURSE = 'windows-1251';
const ENCODE_DEST = 'utf-8';
const PATH_TO_SAVE = 'c:/www3/site1/trailer_get/trail';
const LOG = 'c:/www3/site1/trailer_get/trail/download.log';

function uploadTrailer( $trailerUrl, $headers )
{
	$output = array();
	$filename = substr( $trailerUrl, strrpos( $trailerUrl, '/' ) + 1 );
	$command = "wget -P " . PATH_TO_SAVE . ' ' . $trailerUrl;
	echo $command .'<br/>';
	exec( $command, $output, $result );
	echo $result . '<br/>';
	print_r($output);
	return ( $result === 0 ) ? $filename : false;
}//end func

function uploadTrailer3( $trailerUrl, $headers )
{
	$output = array();
	$filename = substr( $trailerUrl, strrpos( $trailerUrl, '/' ) + 1 );
	$fullname = PATH_TO_SAVE . '/' . $filename;
	$log = LOG;
	$command = "php download.php $trailerUrl $fullname $log > download.log 2>&1 &";
	echo $command .'<br/>';
	exec( $command, $output, $result );
	//echo $result . '<br/>';
	//print_r($output);
	//return ( $result === 0 ) ? $filename : false;
	return $filename;
}//end func

function uploadTrailer2( $trailerUrl, $headers )
{
	$trailer = Http::SendRequest( $trailerUrl, false, $headers );
	if ( !$trailer ) return false;
	$filename = substr( $trailerUrl, strrpos( $trailerUrl, '/' ) + 1 );
	return ( file_put_contents( $filename, $trailer ) )? $filename : false;
}//end func


if ( $_SERVER['REQUEST_METHOD'] == 'POST' )
{
	
	$headers = array(
				 'Cache-Control: max-age=0',
				 'Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8',
				 'Accept-Encoding: ',
				 'Accept-Language: ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4'

				);

				
				
	//$url = 'http://www.kinopoisk.ru/film/722253/';
	$url = $_POST['url'];
	if ( strrpos( $url, '/' ) !== ( strlen($url) - 1 ) ) $url .= '/';
	//$url .= 'video/';
	echo $url . '<br/>';
	$base_url = 'http://kp.cdn.yandex.net/';
	$result = 1;

	$content = Http::SendRequest( $url, false, $headers );

	$pos = strpos($content,'"trailerFile":');
	if ( $pos === false ) $pos = strpos($content,"'trailerFile':");
	$str = substr( $content, $pos, 100 );
				
	$regV = '/[0-9]{1,}\/kinopoisk\.ru[_0-9a-zA-Z\-\.]{3,}/';
	$array = array( 0, 0 );
	preg_match( $regV, $str, $array );
				
	echo '<br/>';
	$trailerUrl = ( isset( $array[0] ))? $base_url . $array[0] : false;
	$trailerUrl = trim( $trailerUrl );
	if ( $trailerUrl )
	{
		if ( $filename = uploadTrailer3( $trailerUrl, $headers ) )
		{
			header( 'Location: test3.php?filename=' . $filename );
		}
		else
		{
			echo 'Trailer download fail';
		}
					
	}
	else
	{
		echo 'Parse trailer URL fail';
	}

}

?>

<form id="form1" action = "test3.php" method="post">
URL:<input type="text" size="50" name="url" value="http://www.kinopoisk.ru/film/722253/video/"/><br/>
<input id="submit" type="submit" value="Загрузить трейлер"/>	

</form>
<div id="preload"><img src='loader.gif'/></div>
<?php echo ( isset($_GET['filename']) )? 'Файл ' . $_GET['filename'] . ' загружен' : ''; ?>

<script type="text/javascript">
	
	var preload = document.getElementById("preload");
	preload.style.display="none";
	var form = document.getElementById("form1");
	var btn = document.getElementById("submit");
	
	form.onsubmit=function(){ preload.style.display="block"; btn.setAttribute('disabled','disabled');};

</script>	
