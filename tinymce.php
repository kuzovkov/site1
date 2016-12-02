<html>
<head>
<title>Test TinyMCE</title>
<script src="/tinymce/tinymce.min.js"></script>
<!--<script src="/tinymce35/tinymce/jscripts/tiny_mce/tiny_mce.js"></script>-->

<script>
       
		tinymce.init({selector:'textarea', width:500, height: 300, plugins: [
         "advlist autolink link image lists charmap print preview hr anchor pagebreak spellchecker",
         "searchreplace wordcount visualblocks visualchars code fullscreen textcolor insertdatetime media nonbreaking",
         "save table contextmenu directionality emoticons template paste"
],});


//tinymce._init({selector:'textarea'});
</script>

</head>

<body>

<form method="post" action="test_request.php">
<textarea id="editor" name="text" cols="60" rows="20" ></textarea>

<input type="submit" value="Save"/>
			</form>
<body>
</html>