<link type="text/css" rel="stylesheet" href="popup.css"/>

<!-- ������ �� ����� ��������� ����-->
<div style="text-align: center;">
    <a href="#win1" class="button button-green">������� ���� 1</a>
    <a href="#win2" class="button button-red">������� ���� 2</a>
    <a href="#win3" class="button button-blue">����� � ���� 3</a>
    <a href="#win4" class="button button-orange">���� � ���� 4</a>
</div>
<!-- ����� ���� ����� ��������� ����������� -->
<div style="text-align: center;">
<a href="#win5"><img title="������������" src="img/realism_lrg.jpg" width="150" height="150" alt="������������ �������" /></a>
</div>
<!-- ��������� ���� �1 -->
   <a href="#x" class="overlay" id="win1"></a>
   <div class="popup">
    
		<div>
			<form action="" method="POST">
			<input type="text" name="date" id="datepicker"/><br/>
			<input type="text" name="time" id="time"/><br/>
			<input type="submit" value="Ok"/>
			
			</form>
		</div>
    <a class="close"title="�������" href="#close"></a>
    </div>
<!-- ��������� ���� �2 -->
    <a href="#x" class="overlay" id="win2"></a>
    <div class="popup">
     ����� �� ������ ���������� ����� ����������, ���� �� ������ ����� � ���������� ��� �����!
    <a class="close" title="�������" href="#close"></a>
    </div>
<!-- ��������� ���� �3 -->
        <a href="#x" class="overlay" id="win3"></a>
        <div class="popup">
<h2>���������</h2>
      ����� ���������� ����� � ������ ���������� �������, YouTube, Vimeo � �.�.
        <a class="close" title="�������" href="page.html" onclick="return false"></a><!-- ���������� ����� ��� �������� ���� -->
        </div>
<!-- ��������� ���� �4 -->
<a href="#x" class="overlay" id="win4"></a>
        <div class="popup">
<img class="is-image" src="���� ��������.jpg" alt="" />
        <a class="close" title="�������" href="#close"></a>
        </div>
<!-- ��������� ���� �5 -->
        <a href="#x" class="overlay" id="win5"></a>
        <div class="popup">
<img class="is-image" src="���� ��������.jpg" alt="" />
<a class="close" title="�������" href="#close"></a>
        </div>