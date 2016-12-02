<?php
$key='229497';


if($_SERVER['REQUEST_METHOD'] == 'GET' )
{
	if (isset($_GET['key']) && $_GET['key'] == $key)
	{
		readfile('upload/1.rar');
	}
}
