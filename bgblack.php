<!DOCTYPE html>
<html>
<head>
<title>Затемнение фона через CSS</title>
<style type = "text/css">
body {
  height: 3000px;
}
#parent_div {
  background: black; 
  height: 100%;
  opacity: 0.75;
  position: fixed;
  width: 100%;
  z-index: 100;
  top: 0;
  left: 0;
}
#div {
  background: yellow;
  padding: 10px;  
  height: 300px;
  position: fixed;
  top: 30%;
  left: 35%;
  color: red;
  width: 300px;
}
a#close {
  color: gray;
  font-weight: bold;
  text-decoration: underline;
  cursor: pointer;
}
</style>
</head>
<body>
<div id = "content">
  <h1>Основной контент сайта.</h1>
  <a onclick = "document.getElementById('parent_div').style.display='block';" id="open" href="#">Open</a>
</div>
<div style="display:none" id = "parent_div">
  <div id = "div">
    <a id = "close" onclick = "document.getElementById('parent_div').style.display='none';">Закрыть</a>
    <p>Текст внутри блока с затемнением</p>
  </div>
</div>

<script type="text/javascript">
	/*
	var open = document.getElementById('open');
	open.onclick = function(){ var parent = document.getElementById('parent_div');
		parent.style.display = 'block';
	};
	*/
</script>
</body>
</html>