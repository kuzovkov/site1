<html>
<head>
	<meta charset="utf-8"/>
  <link rel="stylesheet" type="text/css" href="http://ajax.aspnetcdn.com/ajax/jquery.dataTables/1.9.4/css/jquery.dataTables.css">
</head>
<body>
  <table id="example">
    <thead>
      <tr><th>Веб-сайты</th></tr>
    </thead>
    <tbody>
	<?php for($i=0; $i < 100; $i++):?> 
		<tr><td><?php echo $i;?></td></tr>     
		<tr><td>htmlhook.ru</td></tr>
      	<tr><td>Новый путь</td></tr>
      	<tr><td>Портал UA</td></tr>
	<?php endfor;?>
    </tbody>
  </table>
  <script type="text/javascript" charset="utf8" src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.2.min.js"></script>
  <script type="text/javascript" charset="utf8" src="http://ajax.aspnetcdn.com/ajax/jquery.dataTables/1.9.4/jquery.dataTables.min.js"></script>
  <script>
  $(function(){
    $("#example").dataTable();
  })
  </script>
</body>
</html>

