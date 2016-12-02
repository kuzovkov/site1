<?php
define( 'FILELOG', 'logfile.txt' );
define( 'DELAY', '100000' );

if ( $f= @fopen( FILELOG, 'w' ) )
{
	fclose( $f );
}

function writeLog( $msg )
{
	if ( $f = @fopen( FILELOG, 'a+') )
	{
		$now = date( 'Y/m/d H:i:s', time() );
		fwrite( $f, $now. ':  ' . $msg . "\n" );
		fclose( $f );
	}
}//end func

if ( $_SERVER['REQUEST_METHOD'] == 'POST' )
	{
		if ( isset($_FILES['emails']) )
		{
			$subject = $_POST['subject'];
			$message = $_POST['message'];
			
			$content = file_get_contents( $_FILES['emails']['tmp_name'] );
			$mails = explode( "\n", $content );
			foreach ( $mails as $mail )
			{
				$mail = trim( $mail );
				if ( mail( $mail, $subject, $message ) )
				{
					$mess = "Письмо по адресу $mail отправлено";
					writeLog( $mess );
				}
				usleep( DELAY );
			}
		}
	
	}

?>


<style>
form
{
	width: 400px;
	height: 300px;
	border: 2px solid #00f;
	background-color: #06f;
	margin: 100px auto 0 auto;
	padding: 20px;
	font-size: 16px;
}
input
{
	font-size: 16px;
	border: 2px solid #007;
}

a
{
	font-size: 20px;
	color: #0f0;
}


</style>

<form name="form1" method="POST" action="mailsender.php" enctype="multipart/form-data">
<p>Email file: <input type="file" name="emails"></p>
<p>Тема: <input type="text" value="" name="subject"/></p>
<p>Текст:<br/><textarea name="message" cols="45" rows="5"></textarea></p>

<input type="submit" name="submit"  value="Послать почту"/>

<a href="<?=FILELOG?>">Посмотрель лог файл</a>
</form>