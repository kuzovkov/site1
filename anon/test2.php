<?php

require_once( 'simple_html_dom.php' );
require_once( 'Http.class.php' );

const ENCODE_SOURSE = 'windows-1251';
const ENCODE_DEST = 'utf-8';

function string2timestamp( $date )
		{
			$ddmmyyyy = array();
			$items = explode( ' ', $date );
			foreach( $items as $item )
			{
				$item = trim($item);
				if ( ! empty( $item ) ) $ddmmyyyy[] = $item;
			}
			if ( count( $ddmmyyyy) == 2 )
			{
				$day = 1;
				$month = monthConv( $ddmmyyyy[0] );
				$year = intval(  $ddmmyyyy[1] );
			}
			else if ( count( $ddmmyyyy ) == 3 )
			{
				$day = intval( $ddmmyyyy[0] );
				$month = monthConv( $ddmmyyyy[1] );
				$year = intval(  $ddmmyyyy[2] );
			}
			else return false;
			echo $day,$month,$year;
			$timestamp =  mktime( 0, 0, 0, $month, $day, $year );
			return $timestamp;
        
		}//end func

	function monthConv( $month )
    {
        echo 1, $month;
		$month = iconv( ENCODE_SOURSE, ENCODE_DEST . '//IGNORE', $month );
		echo 2, $month;
		$month = mb_strtolower ( $month, ENCODE_DEST );
		echo 3, $month;
        $nameMonths = array(
							'январ',
							'феврал',
							'март',
							'апрел',
							'ма',
							'июн',
							'июл',
							'август',
							'сентябр',
							'октябр',
							'ноябр',
							'декабр',
						);
        foreach( $nameMonths as $numberMonth => $nameMonth )
		{
			if ( strpos( $month, $nameMonth ) !== false ) return $numberMonth + 1;
		}
		return 0;
    }//end func


$headers = array(
				 'Cache-Control: max-age=0',
				 'Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8',
				 'Accept-Encoding: ',
				 'Accept-Language: ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4'

				);

				
				
$url = 'http://www.kinopoisk.ru/film/680345/wall/';
if ( strrpos( $url, '/' ) !== ( strlen($url) - 1 ) ) $url .= '/';
//$url .= 'dates/';
echo $url . '<br/>';
$content = Http::SendRequest( $url, false, $headers );

		$html = str_get_html( $content );
        if ( is_object($html) )
		{	
			//$time = array(0,0);
			/*
			$result = array();
			$countries = $html->find( 'a[href*=country]' );
			if ( is_array( $countries) && count( $countries) )
			{
				foreach( $countries as $country )
				{
					if ( $country->innertext ) $result[] = $country->innertext;
				}
			}
			echo implode( ',', $result );
			*/
			$links = $html->find('table[class=fotos fotos1] a' );
			if ( is_array( $links ) && count( $links ) )
			{
				$maxSize = 0;
				$needLink = '';
				foreach( $links as $link )
				{
					$href = $link->href;
					$array = array( 0, 0 );
					preg_match( '/w_size\/\d{1,}/', $href, $array );
					$str = $array[0];
					$str = strrchr( $str, '/');
					$size = intval(substr($str,1));
					if( $size > $maxSize ) 
					{
						$maxSize = $size;
						$needLink = $href;
					}
					
				}
				echo $maxSize;
				echo $needLink;
				$baseUrl = 'http://www.kinopoisk.ru';
				$content = Http::SendRequest( $baseUrl.$needLink, false, $headers );
				$html2 = str_get_html( $content );
				if ( is_object($html2) )
				{
					$img = $html2->find('img[id=image]', 0);
					$src = $img->src;
					echo $src;
					$wall = Http::SendRequest( $src, false, $headers );
					if ( file_put_contents( 'wall.jpg', $wall ) ) echo 'Ok';
				}
			}
			
			 
			 /*
			 if ( is_array($items) && count( $items ) )
			 {
				
				foreach( $items as $item )
				{
					$date_last =  trim($item->plaintext);
				}
				echo $date_last;
			 }
			 */
			//$str = $html->find( 'td#runtime', 0 )->innertext;
			//preg_match( '/\d{1,}/', $str, $time );
			//echo intval($time[0]);
			
			
		}
		else
		{
			echo '$html is not object';
		}

		
		/*
		echo '<br/>' . string2timestamp( $date_last );
		echo '<br/>' . date( 'd.m.Y', string2timestamp( $date_last ));
		$date = new DateTime( date( 'd.m.Y', string2timestamp( $date_last )) );
		echo $date->format("d-m-Y H:i:s").'<br />';
	*/