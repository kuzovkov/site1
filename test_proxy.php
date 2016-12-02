<?php
require_once( 'simple_html_dom.php' );
require_once( 'Http.class.php' );

const ENCODE_DEST = 'windows-1251';
const ENCODE_SOURCE = 'utf-8';
const ENCODE_DEST2 = 'cp866';

$headers = array(
				 'Cache-Control: max-age=0',
				 'Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8',
				 'Accept-Encoding: ',
				 'Accept-Language: ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4'

				);

				
				
$url = 'http://2ip.ru';
$file = 'c:/www3/site1/2ip_content.html';
exec("cls.bat");
echo "\n".$url."\n";  //. '<br/>';
$content = Http::SendRequest( $url, false, $headers );

if ($content) file_put_contents( $file, $content );

		
		$html = str_get_html( $content );
        if ( is_object($html) )
		{	
			$tag = $html->find( 'big[id=d_clip_button]', 0 );
			$ip = (is_object($tag))?  $tag->innertext : 'error parse';
			echo 'IP: ' . $ip;
			
			$tag = $html->find( 'span[class=ip-info-entry__value]', 0 );
			$compName = (is_object($tag))?  $tag->innertext : 'error parse';
			echo "\nComputer name: " . $compName;
			
			$tag = $html->find( 'span[class=ip-info-entry__value]', 1 );
			$OS = (is_object($tag))?  $tag->innertext : 'error parse';
			echo "\nOS: " . $OS;
			
			$tag = $html->find( 'span[class=ip-info-entry__value]', 2 );
			$browser = (is_object($tag))?  $tag->innertext : 'error parse';
			echo "\nBrowser: " . $browser;
			
			$tag = $html->find( 'span[class=ip-info-entry__value]', 3 );
			$place = (is_object($tag))?  trim($tag->plaintext) : 'error parse';
			echo "\nGeolocation: " . iconv( ENCODE_SOURCE, ENCODE_DEST2.'//IGNORE', $place );
			
			$tag = $html->find( 'span[class=ip-info-entry__value]', 4 );
			$provider = (is_object($tag))?  trim($tag->plaintext) : 'error parse';
			echo "\nProvider: " . iconv( ENCODE_SOURCE, ENCODE_DEST2.'//IGNORE', $provider );
			
			$tag = $html->find( 'span[class=ip-info-entry__value]', 5 );
			$proxy = (is_object($tag))?  trim($tag->plaintext) : 'error parse';
			echo "\nProxy: " . iconv( ENCODE_SOURCE, ENCODE_DEST2.'//IGNORE', $proxy );
		}