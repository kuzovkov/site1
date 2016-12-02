<?php
$dir = '/home/www/html/web/upload/';
file_put_contents($dir.'test.txt',date('H:i:s d-m-Y',time()));