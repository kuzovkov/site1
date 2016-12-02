<?php
require_once('class.iterator.php');
require_once('array.prices.php');
require_once('class.goods.php');
require_once('class.discount.php');
require_once('class.discountmanager.php');
// purchase = (название товара => количество товара в корзине)
$purchase = array('A'=>5,
				'B'=>3,
				'C'=>1,
				'D'=>1,
				'E'=>2,
				'F'=>1,
				'G'=>5,
				'H'=>0,
				'I'=>0,
				'J'=>8,
				'K'=>3,
				'L'=>0,
				'M'=>2);

$setOfDiscounts = array('DiscountAB','DiscountDE','DiscountEFG','DiscountAKLM','Discount567');

echo "Hi php!<BR>";
// формируем корзину
$cart = array();
$cart[] = new Goods('wallet', 1, $prices);
foreach( $purchase as $name => $amount)
{
	$cart[] = new Goods($name, $amount, $prices); 
}

print_r($cart);
echo '<hr/>';

$collectionDiscounts = new Discounts();

foreach ($setOfDiscounts as $i) {
	$collectionDiscounts->add($i);
}
var_dump($collectionDiscounts);
foreach ($collectionDiscounts as $key => $val) {
	echo "<br/>".$key;
	var_dump($val);
	// запускает итератор. я сам себя запутал но без этого не работает.
}

print_r($cart);
$sumOfBuys = $cart[0]->getPrice();
echo "$sumOfBuys<BR>end";
?>