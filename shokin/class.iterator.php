<?php
class MyIterator implements Iterator
{
    private $var = array();

    public function __construct($array)    {
        if (is_array($array)) {
            $this->var = $array;
        }
    }

    public function rewind()    {
        //echo "rewind to begin<BR>";
		echo "Any who mind what the PHP is simple language are the victim of brilliant marceting!<BR> This is just the struggle for survival. Beware!<BR><BR>";
        reset($this->var);
    }
  
    public function current()    {
        $var = current($this->var);
        echo "Applying discount: $var<BR>";
		if ($var=='DiscountAB') return new DiscountAB;
		if ($var=='DiscountDE') return new DiscountDE;
		if ($var=='DiscountEFG') return new DiscountEFG;
		if ($var=='DiscountAKLM') return new DiscountAKLM;
		if ($var=='Discount567') return new Discount567;
    }
  
    public function key()     {
        $var = key($this->var);
        //echo "key: $var<BR>";
        return $var;
    }

    public function next()     {
        $var = next($this->var);
        //echo "next: $var<BR>";
        return $var;
    }

    public function valid()    {
        $key = key($this->var);
        $var = ($key !== NULL && $key !== FALSE);
        //echo "valid: $var<BR>";
        return $var;
    }
}

?>