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
   /* foo() будет скопирован в ¬, следовательно его область действи€ по прежнему ј,
      и вызов будет успешен*/
}

class C extends A {
    private function foo() {
        /* исходный метод заменен; область действи€ нового метода — */
    }
}

$b = new B();
$b->test();
$c = new C();
$c->test();   //не верно
?>