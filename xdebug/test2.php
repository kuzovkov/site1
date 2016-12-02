<?php

function foo1(){
	for( $i = 0; $i < 10000; $i++){
		$x = cos($i);
	}
	return foo2();
}

function foo2(){
	for( $i = 0; $i < 10000; $i++){
		$x = cos($i*$i);
	}
	return foo3();

}

function foo3(){
	for( $i = 0; $i < 10000; $i++){
		$x = cos($i*$i);
	}
	return 'end';

}

echo foo1();