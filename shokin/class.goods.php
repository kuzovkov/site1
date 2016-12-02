<?php

// Продукт (товар):
class Goods {
	protected $name;
	protected $price;
	protected $amount;
	
	function __construct($name, $amount, $prices)
	{
		$this->name = $name;
		$this->amount = $amount;
		foreach( $prices as $name => $price )
		{
			if ( $name == $this->name )
			{
				$this->price = $price;
			}
		}
	}
	
	function getName() {
		return $this->name;
	}
	function getPrice() {
		return $this->price;
	}
	function getAmount() {
		return $this->amount;
	}

	function setName($name) {
		$this->name = $name;
	}
	function setPrice($price) {
		$this->price = $price;
	}
	function setAmount($amount) {
		$this->amount = $amount;
	}
}
?>