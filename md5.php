<?php
	$str = '';
	if ( $_SERVER['REQUEST_METHOD'] == 'POST' )
	{
		$str = (isset($_POST['str']))? ($_POST['str']) : '';
		
	}
	$hash = md5($str);
	
?>

<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8"/>
		<title>md5</title>
	</head>
	<body>
		<h3>md5(<?=$str?>) = <?=$hash?></h3>
		<form action="" method="POST">
			<input type="text" size="100" name="str" value="<?=$str?>"/>
			<input type="submit" value="Вычислить"/> 
		</form>
	</body>
</html>