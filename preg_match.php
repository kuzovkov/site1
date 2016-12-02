<?php

	$link = 'http://www.youtube.com/watch?feature=player_detailpage&v=3UllAQ-J6I4';
	$matches = array();
	$pattern = '/&v=[0-9a-zA-Z-]{6,}/';
	preg_match( $pattern, $link, $matches );
	echo substr( $matches[0], 3);