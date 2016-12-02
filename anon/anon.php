<?php

require_once( 'simple_html_dom.php' );
require_once( 'Http.class.php' );

$service = 'http://dionis20095.orgfree.com/anon.php?url=';

if ( $_SERVER['REQUEST_METHOD'] == 'POST' && isset($_POST['url'])){
	$url = $_POST['url'];
	forward($url);
}

if ( $_SERVER['REQUEST_METHOD'] == 'GET' && isset($_GET['url'])){
	$url = $_GET['url'];
	forward($url);
}


function forward($url){
	$content = Http::SendRequest( $url, false, $headers );
	echo ($content)? $content : 'Not found';
}

function updateLinks($content){
	return str_replace('http://', $service+'http://', $content);
}