<html>
<head>
<title>Test CKEditor</title>

<script src="/ckeditor/ckeditor.js"></script>

</head>

<body>
<form method="post" action="test_request.php">
<textarea id="aaa" name="text" cols="60" rows="20" ></textarea>

<input type="submit" value="Save"/>
			</form>
 <script>
                // Replace the <textarea id="editor1"> with a CKEditor
                // instance, using default configuration.
                CKEDITOR.replace('aaa',{width: 800, height: 400} );
				//$("textarea").ckeditor();
            </script>

			
<body>
</html>