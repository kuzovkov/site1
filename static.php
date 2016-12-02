<?php
class A {
    private function foo() {
        echo __CLASS__;
    }
    public function test() {
        $this->foo();
        //static::foo();
    }
}

class B extends A {
   /* foo() ����� ���������� � �, ������������� ��� ������� �������� �� �������� �,
      � ����� ����� �������*/
}

class C extends A {
    private function foo() {
        /* �������� ����� �������; ������� �������� ������ ������ � */
    }
}

$b = new B();
$b->test();
$c = new C();
$c->test();   //�� �����
?>