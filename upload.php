<?php
	echo '<h1>$_SERVER</h1>';
	print_r($_SERVER);
	echo '<h1>$_POST</h1>';
	print_r($_POST);
	echo '<h1>$_GET</h1>';
	print_r($_GET);
	echo '<h1>$_REQUEST</h1>';
	print_r($_REQUEST);
	echo '<h1>$_SESSION</h1>';
	print_r($_SESSION);
	echo '<h1>$_COOKIE</h1>';
	print_r($_COOKIE);
	echo '<h1>$_FILES</h1>';
	print_r($_FILES);
	
	if ( isset( $_FILES['file'] ) )
		{
			$file = $_FILES['file'];
			$name = $file['name'];
			$savename = 'upload/' . $name;
			$tmpname = $file['tmp_name'];
			if ( move_uploaded_file( $tmpname, $savename) )
			{
				echo '<h3>file '. $name . ' uploaded</h3>';
			}
			else
			{
				echo '<h3>upload Fail</h3>';
			}
			
		}
?>