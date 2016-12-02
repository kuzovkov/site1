<?php
session_start();
date_default_timezone_set( 'Europe/Moscow' );
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

function getResponse( $file_id )
{
	$response='<?xml version = "1.0" encoding = "utf-8" ?>';
	$response.='<file><id>'.$file_id.'</id><time>'.time().'</time></file>';
	return $response;
}

$key = '229497';
$file_id = md5( time() );
if ( isset( $_SERVER['HTTP_KEY'] ) && $_SERVER['HTTP_KEY'] == $key )
{
	if ( isset( $_FILES['filename'] ) )
	{
		$file = $_FILES['filename'];
		$name = $file['name'];
		$savename = '../upload/' . $name;
		$tmpname = $file['tmp_name'];
		if ( move_uploaded_file( $tmpname, $savename) )
		{
			echo '<h3>file '. $name . ' uploaded</h3>';
			echo getResponse($file_id);
		}
		else
		{
			echo '<h3>upload Fail</h3>';
		}
		
	}
}





?>