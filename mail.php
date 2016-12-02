<?php
if ( $_SERVER['REQUEST_METHOD'] == 'POST' )
	{
		
			$email = $_POST['email'];
			$subject = $_POST['subject'];
			$message = $_POST['message'];
			if ( mail($email,$subject,$message) )
			{
				echo "Mail send success";
			}
			else
			{
				echo "Mail send fail";
			}
			
		
	
	}

?>


<style>
form
{
	width: 400px;
	height: 300px;
	border: 2px solid #00f;
	background-color: #06f;
	margin: 100px auto 0 auto;
	padding: 20px;
	font-size: 16px;
}
input
{
	font-size: 16px;
	border: 2px solid #007;
}

a
{
	font-size: 20px;
	color: #0f0;
}


</style>

<form name="form1" method="POST" action="mail.php" enctype="multipart/form-data">
<p>Email: <input type="text" name="email" value="dionis20095@rambler.ru"></p>
<p>Тема: <input type="text" name="subject" value="test message"/></p>
<p>Текст:<br/><textarea name="message" cols="45" rows="5">Test message </textarea></p>

<input type="submit" name="submit"  value="Послать почту"/>

</form>