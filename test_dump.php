<?php

if ($_SERVER['REQUEST_METHOD'] == 'POST')
{
	
	$filedump = 'c:/www3/site3/install/backup.site3.sql';
	//
	
	//$command = "mysqldump -uroot -proot -databases site3 > $filedump";
	
	//$command = "more c:\\nis\\hello.cs > $filedump";
	//$command = "c:/NIS/dump";
	//echo $command;
	system( "mysqldump -uroot -proot -databases site3 > $filedump" );

}

?>

<form action="" method="post">
<input type="submit" value="Ok"/>
</form>