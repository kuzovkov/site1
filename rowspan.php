<?php
$data = array(
				array( '22-04-2014', '18:00', 5, 100 ),
				array( '22-04-2014', '19:00', 5, 100 ),
				array( '22-04-2014', '21:00', 5, 100 ),
				array( '25-04-2014', '18:00', 5, 100 )
				);
				
		
		$span = array();
		foreach( $data as $row )
		{
			$str = $row[0];
			if ( array_key_exists( $str, $span ) === false )
			{
				$span[$str] = 1;
			}
			else
			{
				$span[$str]++;
			}
		}
		
		$prev = '';
		print_r( $span );
?>


<style>
table, td, tr
{
	border: 1px solid black;
	background-color: #ccc;
	margin: 100px auto 0 auto;
}

td
{
	font-size: 20px;
	font-family: verdana;
	padding: 10px;
	text-align: center;
}

</style>
<table>

	<?php foreach( $data as $row ):?>
		<tr>
			<?php if( $row[0] != $prev ) { ?>
			<td rowspan="<?=$span[$row[0]]?>"><?=$row[0]?></td>
			<?php } ?>
			<?php $prev = $row[0];?>
			<td><?=$row[1]?></td>
			<td><?=$row[2]?></td>
			<td><?=$row[3]?></td>
		</tr>
	<?php endforeach;?>



</table>