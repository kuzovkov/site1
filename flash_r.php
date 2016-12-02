<!--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="en" xml:lang="en"> -->


<html>
	<head>
		<title>Принимающий видео</title>
		<meta http-equiv="Content-Type" content="text/html; charset=cp1251" />
		<style type="text/css" media="screen">
		html, body { height:100%; background-color: #FFFFFF;}
		body { margin:0; padding:0; overflow:hidden; }
		#flashContent { width:768; height:576; margin-left:auto; margin-right:auto; margin-top:100px;}
		</style>
	</head>
	<body>
	<?php require("config.php");?>
	<?php 
	$server_name=$config['server'];;
	$stream_name="sania229497";
	?>
		<div id="flashContent">
			<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" width="768" height="576" id="Untitled-1" align="middle">
				<param name="movie" value="resive.swf" />
				<param name="quality" value="high" />
				<param name="bgcolor" value="#999999" />
				<param name="FlashVars" value="server_name=<?=$server_name?>&stream_name=<?=$stream_name?>" />
				<param name="play" value="true" />
				<param name="loop" value="true" />
				<param name="wmode" value="window" />
				<param name="scale" value="showall" />
				<param name="menu" value="true" />
				<param name="devicefont" value="false" />
				<param name="salign" value="" />
				<param name="allowScriptAccess" value="sameDomain" />
				<param name="allowFullScreen" value="true" />
				<!--[if !IE]>-->
				<object type="application/x-shockwave-flash" data="resive.swf" width="768" height="576">
					<param name="movie" value="resive.swf" />
					<param name="quality" value="high" />
					<param name="bgcolor" value="#999999" />
					<param name="FlashVars" value="server_name=<?=$server_name?>&stream_name=<?=$stream_name?>" />
					<param name="play" value="true" />
					<param name="loop" value="true" />
					<param name="wmode" value="window" />
					<param name="scale" value="showall" />
					<param name="menu" value="true" />
					<param name="devicefont" value="false" />
					<param name="salign" value="" />
					<param name="allowScriptAccess" value="sameDomain" />
					<param name="allowFullScreen" value="true" />
				<!--<![endif]-->
					<a href="http://www.adobe.com/go/getflash">
						<img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="Get Adobe Flash player" />
					</a>
				<!--[if !IE]>-->
				</object>
				<!--<![endif]-->
			</object>
		</div>
	</body>
</html>