<h1>Имя сайта: <?=substr($_SERVER['DOCUMENT_ROOT'],strrpos($_SERVER['DOCUMENT_ROOT'],"/")+1);?></h1>

<p><?php file_get_contents('info.txt')?></p>
<?php

echo __FILE__;
echo "<br>";
phpinfo();
?>