<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
	<meta content="" name="author"/>
	<meta content="" name="title"/>
	<meta content="popup,jquery,�����������,����" name="keywords"/>
	<meta content="popup - ����������� ����. ���������� ������������ ���� � �������������� javascript ���������� jquery" name="description"/>
	<title>Popup - ����������� ���� �� jQuery</title>
	<link rel="stylesheet" href="style.css" type="text/css" media="screen" />
	<script type="text/javascript" src="jquery-1.11.0.min.js"></script>
	<script type="text/javascript" src="js/popup.js"></script>
	<script type="text/javascript">
		$(document).ready(function(){
			PopUp($('#obj'), $('#trigg'));
		});
	</script>
</head>

	<body>
		<div class="wrapper">
			<a id="trigg" href="javascript:void(0);">�������� POP-UP ����</a>
			
			<!-- �� obj ����� �������� HTML � ������� � POP-UP -->
				<div id="obj"><div class="sample"><p>������������ HTML ���...</p></div></div>
			<!-- X �� obj ����� �������� HTML � ������� � POP-UP -->
			
		</div>
	</body>

</html>