<?php
class Discounts implements IteratorAggregate
{
    private $items = array();
    private $count = 0;

    // getIterator() - Требование интерфейса IteratorAggregate
    public function getIterator() {
        return new MyIterator($this->items);
    }

    public function add($value) {
        $this->items[$this->count++] = $value;
    }
}
?>