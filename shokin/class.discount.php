<?php
abstract class Discount{
    abstract public function apply($cart);
}

// Для дальнейшего улучшения кода я бы написал класс, получающий на вход набор продуктов Ё,К,Л и % скидки, а в методах ниже вызывал бы этот класс вместо имеющейся там на данный момент копипастерской лапши. Но на начальном этапе написания кода у меня не хватает ума одновременно всё удерживать в голове, чтобы писать сразу без копипастов

class DiscountAB extends Discount{
    public function apply($cart) {
		echo 'call DiscountAB';
		foreach($cart as $product) {
			if ($product->getName()=="A") { 
				$amountA=$product->getAmount();
				$priceA=$product->getPrice();
			}
			if ($product->getName()=="B") {
				$amountB=$product->getAmount();
				$priceB=$product->getPrice();
			}
		}
		if ($amountA > 0 and $amountB > 0) {
			if ($amountA > $amountB) $amountPairs = $amountB; else $amountPairs = $amountA;
			$priceOfThisPairs = ($priceA+$priceB)*$amountPairs*0.9;
			foreach($cart as $product) {
				if ($product->getName()=="A") $product->setAmount($amountA-$amountPairs);
				if ($product->getName()=="B") $product->setAmount($amountB-$amountPairs);
			}
			$varBuys=$cart[0]->getPrice();
			$cart[0]->setPrice($varBuys+$priceOfThisPairs);
		}
    }
}

class DiscountDE extends Discount{
    public function apply($cart) {
        foreach($cart as $product) {
			if ($product->getName()=="D") { 
				$amountD=$product->getAmount();
				$priceD=$product->getPrice();
			}
			if ($product->getName()=="E") {
				$amountE=$product->getAmount();
				$priceE=$product->getPrice();
			}
		}
		if ($amountD > 0 and $amountE > 0) {
			if ($amountD > $amountE) $amountPairs = $amountE; else $amountPairs = $amountD;
			$priceOfThisPairs = ($priceD+$priceE)*$amountPairs*0.95;
			foreach($cart as $product) {
				if ($product->getName()=="D") $product->setAmount($amountD-$amountPairs);
				if ($product->getName()=="E") $product->setAmount($amountE-$amountPairs);
			}
			$varBuys=$cart[0]->getPrice();
			$cart[0]->setPrice($varBuys+$priceOfThisPairs);
		}
    }
}

class DiscountEFG extends Discount{
    public function apply($cart) {
        foreach($cart as $product) {
			if ($product->getName()=="E") { 
				$amountE=$product->getAmount();
				$priceE=$product->getPrice();
			}
			if ($product->getName()=="F") {
				$amountF=$product->getAmount();
				$priceF=$product->getPrice();
			}
			if ($product->getName()=="G") {
				$amountG=$product->getAmount();
				$priceG=$product->getPrice();
			}
		}
		if ($amountE > 0 and $amountF > 0 and $amountG > 0) {
			if ($amountE > $amountF) $minFromPair = $amountF; else $minFromPair = $amountE;
			if ($minFromPair > $amountG) $amountTrio = $amountG; else $amountTrio = $minFromPair;
			$priceOfThisTrio = ($priceE+$priceF+$priceG)*$amountTrio*0.95;
			foreach($cart as $product) {
				if ($product->getName()=="E") $product->setAmount($amountE-$amountTrio);
				if ($product->getName()=="F") $product->setAmount($amountF-$amountTrio);
				if ($product->getName()=="G") $product->setAmount($amountG-$amountTrio);
			}
			$varBuys=$cart[0]->getPrice();
			$cart[0]->setPrice($varBuys+$priceOfThisTrio);
		}
    }
}

class DiscountAKLM extends Discount{
    public function apply($cart) {
        foreach($cart as $product) {
			if ($product->getName()=="A") { 
				$amountA=$product->getAmount();
				$priceA=$product->getPrice();
			}
			if ($product->getName()=="K") {
				$amountK=$product->getAmount();
				$priceK=$product->getPrice();
			}
			if ($product->getName()=="L") {
				$amountL=$product->getAmount();
				$priceL=$product->getPrice();
			}
			if ($product->getName()=="M") {
				$amountM=$product->getAmount();
				$priceM=$product->getPrice();
			}
			$varBuysKLM = 0;
			while ($amountA > 0) {
				if ($amountK > 0) {
					$amountA--;
					$amountK--;
					$varBuysKLM += $priceK*0.95;
					continue;
				}
				if ($amountL > 0) {
					$amountA--;
					$amountL--;
					$varBuysKLM += $priceL*0.95;
					continue;
				}
				if ($amountM > 0) {
					$amountA--;
					$amountM--;
					$varBuysKLM += $priceM*0.95;
					continue;
				}
				break;
			}
			foreach($cart as $product) {
				if ($product->getName()=="A") $product->setAmount($amountA);
				if ($product->getName()=="K") $product->setAmount($amountK);
				if ($product->getName()=="L") $product->setAmount($amountL);
				if ($product->getName()=="M") $product->setAmount($amountM);
			}
			$varBuys=$cart[0]->getPrice();
			$cart[0]->setPrice($varBuys+$varBuysKLM);
		}
    }
}
	
class Discount567 extends Discount{
    public function apply($cart) {
		$sumBalance = 0;
        foreach($cart as $product) {
			if ($balance=$product->getAmount()>0) $sumBalance += $balance;
		}
		if ($sumBalance >4) $finalDiscount = 0.8;
		elseif ($sumBalance >3) $finalDiscount = 0.9;
		elseif ($sumBalance >2) $finalDiscount = 0.95;
		else $finalDiscount = 1;
		$leftoverPrice = 0;
		foreach($cart as $product) {
			if ($balance=$product->getAmount()>0) {
				$price=getPrice();
				$leftoverPrice += $balance*$price;
			}
		}
		$varBuys=$cart[0]->getPrice();
		$cart[0]->setPrice($varBuys+$leftoverPrice*$finalDiscount);
    }
}
?>