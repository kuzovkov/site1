<html>
<head>
	<meta charset="utf-8"/>
  <link rel="stylesheet" type="text/css" href="http://ajax.aspnetcdn.com/ajax/jquery.dataTables/1.9.4/css/jquery.dataTables.css">
</head>
<body>
  <table id="example">
  <thead>
    <tr>
        <th class="site_name">Название</th>
        <th>Адрес</th>
        <th>Тип</th>
        <th>Последние изменения</th>
    </tr>
  </thead>
</table>
  <script type="text/javascript" charset="utf8" src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.2.min.js"></script>
  <script type="text/javascript" charset="utf8" src="http://ajax.aspnetcdn.com/ajax/jquery.dataTables/1.9.4/jquery.dataTables.min.js"></script>
  <script>
		 $("#example").dataTable({
		  "aaData":[
			["htmlhook.ru","http://htmlhook.ru/","Блог","2013-10-15 10:30:00"],
			["Новый путь","http://www.phppath.ru/","Блог","2013-09-15 09:20:00"],
			["Портал UA","http://pixelcom.at.ua/","Интернет магазин","null"],
		  ]//,
		  
	/*"aoColumnDefs":[{
				"sTitle":"Название сайта"
			  , "aTargets": [ "site_name" ]
		  },{
				"aTargets": [ 0,1,2,3 ]
			  , "bSortable": false
			  , "mRender": function ( url, type, full )  {
				  return  '<a href="'+url+'">' + url + '</a>';
			  }
		  },{
				"aTargets":[ 3 ]
			  , "sType": "date"
			  , "mRender": function(date, type, full) {
				  return (full[2] == "Блог")
				            ? new Date(date).toDateString()
				            : "N/A" ;
			  }
		  }]
*/
		});

  </script>
</body>
</html>

