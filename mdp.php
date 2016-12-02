<!DOCTYPE html>
<html>
<head>
<title>MultidatePicker</title>
	<link rel="stylesheet" type="text/css" href="/multidatespicker/css/mdp.css"/>
	<link rel="stylesheet" type="text/css" href="/multidatespicker/css/prettify.css"/>
	<script type="text/javascript" src="/multidatespicker/js/jquery-1.7.2.js"></script>
	<script type="text/javascript" src="/multidatespicker/js/jquery.ui.core.js"></script>
	
		<script type="text/javascript" src="/multidatespicker/js/jquery.ui.datepicker.js"></script>
		<script type="text/javascript" src="/multidatespicker/jquery-ui.multidatespicker.js"></script>
</head>
<body>
<div id="datepicker">&nbsp;</div>

</body>
	<script type="text/javascript">
		var firstDate = new Date( '2014-04-10' );
		var disabledDates = new Array();
		var i;
		var date = new Date();
		for ( i = 1; i < firstDate.getDate(); i++ )
		{
			disabledDates.push( date.setDate(i));
		}
		$('#datepicker').multiDatesPicker({dateFormat: "yy-mm-dd", addDisabledDates:disabledDates});
	</script>
</html>