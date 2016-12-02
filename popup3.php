<!DOCTYPE html>
<html>
<head>
  <title>Всплывающее окно на JavaScript</title>
  <style>
  #roditelskoe_okno {
    opacity: 0.89;
    background: #FFF;
    width: 100%;
    height: 100%;
    display: none;
    left: 0;
    top: 0;
    position: fixed;
    z-index: 100;
  }
  #okno {
    width: 560px;
    background-clip: padding-box;
    background-color: #FFF;
    box-shadow: 0 3px 7px rgba(0, 0, 0, 0.3);
    border-radius: 6px;
    border: 1px solid rgba(0, 0, 0, 0.3);
    left: 50%;
    top: 10%;
    margin-left: -280px;
    position: fixed;
    outline: medium none;
    z-index: 1050;
  }
  .telo-okna {
    position: relative;
    overflow-y: auto;
    padding: 15px;
    max-height: 400px;
  }
  </style>
  <link rel="stylesheet" href="//code.jquery.com/ui/1.10.4/themes/smoothness/jquery-ui.css">
  <script src="//code.jquery.com/jquery-1.10.2.js"></script>
  <script src="//code.jquery.com/ui/1.10.4/jquery-ui.js"></script>
  <script type="text/javascript">
  function vsplivauchii_block(pokazat) {
    document.getElementById('roditelskoe_okno').style.display = pokazat;
	$(function() {
    $( "#datepicker2" ).datepicker();
  });
  }
  </script>
</head>
<body>
<h1>Всплывающее окно на JavaScript</h1>

<div>
			<form action="test_request.php" method="POST">
			<input type="text" name="date" id="datepicker"/><br/>
			<input type="text" name="time" id="time"/><br/>
			<input type="submit" value="Ok"/>
			
			</form>
		</div>
		vhwdwdewd
		dewdewdwedwe
		d
		wedrewdwedfewdew
		d
		dwedwedwedewdewd
		edwedewdwedewdewd
		dwedewdewdwefgrthtrwfwfrhrtefwe
		f
		wef
		wetferter tyrytuyt
		uj
		uyhkjdwerhweurhtx bbd23 ddj ehiehiehiop h x	2e 	i2oe 
		wned ije 2	oje2	opej2ije2 io3ej2io3 erj2	je2	e
		 eirh 22w
<p><a href="#" onclick="vsplivauchii_block('block'); return false">Показать мне его</a></p>
<div id="roditelskoe_okno">
  <div id="okno">
    <div class="telo-okna">
      <p>Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumyeirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diamvoluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam[...]</p>
		<div>
			<form action="" method="POST">
			<input type="text" name="date" id="datepicker2"/><br/>
			<input type="text" name="time" id="time"/><br/>
			<input type="submit" value="Ok"/>
			
			</form>
		</div>
	  
	  <a href="#" onclick="vsplivauchii_block('none'); return false">Закрыть</a>
	  
    </div>
  </div>
</div>
<script type="text/javascript"> $(function() {
    $( "#datepicker" ).datepicker();
  });</script>
</body>
</html>