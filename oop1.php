<?php
echo __FILE__ . "<br/>";

class A{
	private $x;
	private function foo(){
		echo __CLASS__;
	}
	
	public function test(){
		$this->foo();
	}

}

class B extends A {
	public function setX($a){
		$this->x = $a;
	}
}

$b = new B();

$b->test();
$b->setX(10);