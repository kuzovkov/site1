<?php 
//FreeBSD 
function getmac($ip) {
$output=exec("arp -a ".$ip);//получаем строку из ARP таблицы 
 /*
 $begin=strpos($output, "at");//позиция at 
 if($begin==false)return 0; 
 $begin+=3; //перепрыгнуть через at и пробел после него :)) 
 $output=trim(substr($output, $begin)); 
 $end=strpos($output, " ");//пробел после MAC 
 if($end==false)return 0; 
 $output=substr($output, 0, $end); 
 */
 return $output; 
} 
?> 
<html> 
<head> 
<title>Определение MAC адреса по IP</title> 
</head> 
<body> 
<form action="" method="post"> 
IP <input name="ip" value="<?PHP echo $_SERVER['REMOTE_ADDR']; ?>"><br> 
MAC <b><?PHP echo getmac($_POST['ip']); ?></b><br> 
<input type=submit value="GO"> 
</form> 
</body> 
</html>