<?php
	echo "<h2>файла скрипта, вызывающей функции и номера строки</h2>";
	function fix_string($a)
    {
        echo "Called @ ".
            xdebug_call_file().
            ":".
            xdebug_call_line().
            " from ".
            xdebug_call_function();
    }
	 $ret = fix_string(array('Derick'));
	 
	echo "<h2>вывод стека функций</h2>";
	function foo( $far, $out )
	{
		for ($i = 0; $i < 25000; $i++)
		{
			$x = cos($i*$i);
		}
		foo2();
	}
	
	function foo2()
	{
		for ($i = 0; $i < 50000; $i++)
		{
			$x = cos($i*$i);
		}
		xdebug_print_function_stack( 'Your own message' );
	}
	
	
	foo( 42, 3141592654 );
	
   
	
	echo "<h2>вывод информации о времени исполнения от начала скрипта</h2>";
	echo "<br/>", xdebug_time_index(), "\n", "<br/>";
	for ($i = 0; $i < 250000; $i++)
	{
		$x = cos($i*$i);
	}
	echo xdebug_time_index(), "\n", "<br/>";
	
	echo "<h2>вывод информации о переменных</h2>", "<br/>";
	$a = array(1, 2, 3);
    $b =& $a;
    $c =& $a[2];

    xdebug_debug_zval('a');
    xdebug_debug_zval("a[2]");
	