<?php

require_once( 'simple_html_dom.php' );
require_once( 'Http.class.php' );

$url = $_POST['url'];

$content = Http::SendRequest( $url, false, $headers );
echo $content;