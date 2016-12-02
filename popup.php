<link type="text/css" rel="stylesheet" href="popup.css"/>

<!-- Ссылки на вызов модальных окон-->
<div style="text-align: center;">
    <a href="#win1" class="button button-green">Открыть окно 1</a>
    <a href="#win2" class="button button-red">Открыть окно 2</a>
    <a href="#win3" class="button button-blue">Видео в окне 3</a>
    <a href="#win4" class="button button-orange">Фото в окне 4</a>
</div>
<!-- Вызов окна через миниатюру изображения -->
<div style="text-align: center;">
<a href="#win5"><img title="Гиперреализм" src="img/realism_lrg.jpg" width="150" height="150" alt="Реалистичные Рисунки" /></a>
</div>
<!-- Модальное окно №1 -->
   <a href="#x" class="overlay" id="win1"></a>
   <div class="popup">
    
		<div>
			<form action="" method="POST">
			<input type="text" name="date" id="datepicker"/><br/>
			<input type="text" name="time" id="time"/><br/>
			<input type="submit" value="Ok"/>
			
			</form>
		</div>
    <a class="close"title="Закрыть" href="#close"></a>
    </div>
<!-- Модальное окно №2 -->
    <a href="#x" class="overlay" id="win2"></a>
    <div class="popup">
     ЗДЕСЬ ВЫ МОЖЕТЕ РАЗМЕСТИТЬ ЛЮБУЮ ИНФОРМАЦИЮ, БУДЬ ТО ПРОСТО ТЕКСТ С КАРТИНКАМИ ИЛИ ВИДЕО!
    <a class="close" title="Закрыть" href="#close"></a>
    </div>
<!-- Модальное окно №3 -->
        <a href="#x" class="overlay" id="win3"></a>
        <div class="popup">
<h2>Заголовок</h2>
      ЗДЕСЬ ВСТАВЛЯЕТЕ ВИДЕО С ЛЮБОГО СТОРОННЕГО СЕРВЕРА, YouTube, Vimeo и т.д.
        <a class="close" title="Закрыть" href="page.html" onclick="return false"></a><!-- Выключение видео при закрытии окна -->
        </div>
<!-- Модальное окно №4 -->
<a href="#x" class="overlay" id="win4"></a>
        <div class="popup">
<img class="is-image" src="ВАША КАРТИНКА.jpg" alt="" />
        <a class="close" title="Закрыть" href="#close"></a>
        </div>
<!-- Модальное окно №5 -->
        <a href="#x" class="overlay" id="win5"></a>
        <div class="popup">
<img class="is-image" src="ВАША КАРТИНКА.jpg" alt="" />
<a class="close" title="Закрыть" href="#close"></a>
        </div>