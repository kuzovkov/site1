<!DOCTYPE html>
<html>
<head>
<title>Inner table</title>
</head>
<style>
table,tr,td
{
	border: 1px solid black;
}

table.outer
{
	width: 400px;
	height: 300px;
	padding: 0;
}

table.outer td
{
	padding: 0;
}

table.inner
{
	margin: 0;
}

</style>

<body>
	<table class="outer" cellspacing='0' cellpadding='0'>
		<tr>
			<td>1</td>
			<td>2</td>
			<td>3</td>
		</tr>
		<tr height="100">
			<td>4</td>
			
			<td colspan="2" width="200" height="100">
				<table border="0" class="inner" width="100%" height="100%" cellspacing='0' cellpadding='0'>
					<tr>
						<td>1</td>
						<td>2</td>
					</tr>
				</table>
			
			</td>
		</tr>


	</table>

</body>
</html>