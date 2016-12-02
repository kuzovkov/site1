<?php
require_once('include/common.inc.php');

if ( $_SERVER['REQUEST_METHOD'] == 'POST' && isset($_POST['reset']) && isset($_POST['dump']))
{
	dbCreate($_POST['dump'],true);
}

$error = '';
//print_r($tables);
?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8"/>
	<title>Задание по БД</title>
	<link rel="stylesheet" href="css/style.lab1.css"/>
</head>
<body>


<div class="query">
	<form action="" method="post">
		<label>SQL: </label>
		<textarea id="query-text" name="query" cols="60" rows="8"><?=(isset($_POST['query']))? $_POST['query'] : '' ?></textarea>
		<input type="hidden" name="sql" value="1"/>
        <input type="hidden" id="input-rows" name="rows" value="8"/>
		<button>Ok</button>
        <p><a id="clear-link" href="#">Очистить</a></p>
	</form>

</div>
<hr/>

<h1>Результаты запроса: <span><?=(isset($_POST['query']))? $_POST['query'] : '' ?></span></h1>

<div class="results">
	<?php 
		if ( $_SERVER['REQUEST_METHOD'] == 'POST' && isset($_POST['query']) && isset($_POST['sql']))
		{
			$res = dbGetQueryResult($_POST['query']);
			
			if ( $res === true )
			{
				echo 'Успешно';
			}
			elseif( $res === false )
			{
				echo 'Ошибка';
				$error = mysql_error();
			}
			else
			{
				?>
				<table>
				<?php $first = true;?>
				<?php foreach( $res as $row ):?>
				<?php if($first): $first = false;?>
					<tr>
					<?php foreach($row as $col_name => $col_val ):?>
						<th><?=$col_name?></th>
					<?php endforeach;?>
					</tr>
				<?php endif;?>
				<tr>
					<?php foreach($row as $col):?>
						<td><?=$col?></td>
					
					<?php endforeach;?>
				</tr>
				<?php endforeach;?>
				</table>
				<?php
			
			}
			
		}
	?>
</div>
<hr/>
<h1>Ошибки: </h1>
<div class="error">
<?=$error?>
</div>
<hr/>
<h1>Таблицы в БД: </h1>
<div class="tables">
<?php
checkDbExisting();
$tables = dbGetTables(dbGetTablesList());
if ( is_array($tables) && count($tables) ):
foreach( $tables as $table ):
?>
	
	<div class="table">
	<h1><?=$table['name']?></h1>
	<table>
		<tr>
			<?php foreach( $table['header'] as $header ):?>
				<th><?=$header?></th>
			<?php endforeach;?>
		</tr>
		<?php foreach( $table['data'] as $row ):?>
		<tr>
			<?php foreach( $row as $col ):?>
				<td><?=$col?></td>
			<?php endforeach;?>
		</tr>	
		<?php endforeach;?>
	</table>
	</div>
	
<?php endforeach; endif;?>
</div>
<div class="cls"></div>
<hr/>
<h1>Воссоздание БД из дампа</h1>
<div class="reset">
	<form action="" method="post">
	<label>Выберите файл дампа:</label><br/>

    <select name="dump">
		<?php $list = getDumpfilesList('include'); foreach($list as $file):?>
			<option value="<?=BASE_PATH . 'include/' . $file?>"><?=$file?></option>
		<?php endforeach;?>
	</select>
	<input type="hidden" name="reset" value="1"/>
	<button>Ok</button>
	</form>

</div>
<hr/>
<script type="text/javascript">
    var queryText = document.getElementById('query-text');
    var clearLink = document.getElementById('clear-link');
    var inputCols = document.getElementById('input-cols');
    var inputRows = document.getElementById('input-rows');
    clearLink.onclick = function(){queryText.value='';};
    queryText.onchange = function(){
       //setSize();
    };
    //window.onload = function(){setSize();}; 
    function setSize(){
        var cols = queryText.getAttribute('cols');
        var rows = queryText.getAttribute('rows');
        //alert('len:'+queryText.value.length/cols);
        
        if ( queryText.value.length/cols+1 > rows ) rows = Math.round(queryText.value.length/cols);
        //alert(cols+':'+rows);
        var rows = queryText.setAttribute('rows',rows+3);
    }
</script>
</body>
</html>

