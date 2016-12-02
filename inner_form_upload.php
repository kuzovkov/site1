<form id="f1"  method="post" action="test_request.php">

<input type="text" name="arg1" value="agr1" form="f1"/>
<hr/>


<label>Выберите файл</label>
<input type="file" name="page_image" form="f2"/>
<input type="submit" value="Загрузить" form="f2"/>

<hr/>
<input type="text" name="arg2" value="agr2" form="f1"/>
<input type="submit" value="Сохранить" form="f1"/>

</form>

<form id="f2" method="post" enctype="multipart/form-data" action="upload.php">
</form>