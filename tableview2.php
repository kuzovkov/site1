<?php
$dbCon=mysqli_connect('localhost','root','root','spyder') or die(mysqli_connect_error());
$table = 'content';
$result=mysqli_query($dbCon, "SELECT * FROM $table");
$data=array();
while($row=mysqli_fetch_assoc($result))
{
	$data[]=$row;
}
echo $table.'<br/>';
print_r($data);