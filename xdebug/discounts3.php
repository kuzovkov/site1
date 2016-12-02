<?php

//продукт в корзине
interface IProduct {
    public function getId();
    public function getPrice();
    public function getCount();
    public function updateCount($count);
}


class Product implements IProduct {
    private $id;
    private $price;
    //число продуктов данного типа в корзине
    private $count;
    
    function __construct($id, $price, $count) {
        $this->id = $id;
        $this->price = $price;
        $this->count = $count;
    }
    
    public function getId() {
        return $this->id;
    }
    
    public function getPrice() {
        return $this->price;
    }
    
    public function getCount() {
        return $this->count;
    }
    
    public function updateCount($count) {
        $this->count += $count;
    }
}

//корзина
interface ICart {
    public function addProduct(IProduct $product);
    public function getProducts();
}


class Cart implements ICart {
    private $products;
    private $sum;
    
    function __construct() {
        $this->products  = array();
        $this->sum = 0;
        $this->_calculateSum();
    }
        
    public function getProducts() {
        return $this->products;
    }
    
    public function addProduct(IProduct $product) {
        $this->products[$product->getId()] = $product;
        //$this->sum += $product->getPrice();
		$this->sum += $product->getPrice() * $product->getCount();;
    }    
    
    public function getSum() {
        return $this->sum;
    }
    
    private function _calculateSum() {
        $this->sum = 0; /*вставлено*/
		foreach ($this->products as $product) {
            $this->sum += $product->getPrice()*$product->getCount();
        }
    }
}

//скидка
interface IDiscount {
    public function apply(array $products);
    public function getDiscount();
    public function getAppliedProducts();
	public function onChanged(array $discounts); /*метод для приема сообщений от обозреваемого объекта*/
}


//1.	Если одновременно выбраны А и B, то их суммарная стоимость уменьшается на 10% (для каждой пары А и B)
//2.	Если одновременно выбраны D и E, то их суммарная стоимость уменьшается на 5% (для каждой пары D и E)
//3.	Если одновременно выбраны E,F,G, то их суммарная стоимость уменьшается на 5% (для каждой тройки E,F,G)
class Discount1_2_3 implements IDiscount {
    private $products;
    private $productIds;
    //сумма скидки
    private $discount;
    private $discountValue;
    //товары, на которые применилась скидка [productId => $count]
    private $appliedProducts;
	private $applyedDiscounts; /*поле для хранения списка уже примененных скидок*/
    
    public function __construct(array $productIds, $discountValue) {
        $this->products = array();
        $this->discount = 0;
        $this->productIds = $productIds;
        $this->discountValue = $discountValue;
        $this->appliedProducts = array();
		$this->applyedDiscounts = array();
		
    }
    
    /**
	* принимаем от обозреваемого объекта (DiscountManager)
	* список уже примененных скидок и записываем в поле  $applyedDiscounts
	* @param array $discounts массив содержащий строки названий классов примененых скидок
	**/
	public function onChanged(array $discounts){
		$this->applyedDiscounts = $discounts;
	}
	
	public function apply(array $products) {
        $this->products = $products;
        $counts = array();
        foreach ($this->productIds as $productId) {
            $counts[] = $this->products[$productId]->getCount();
        }
        $min = min($counts);
        if ($min > 0) {
            foreach ($this->productIds as $productId) {
                $this->discount += $this->products[$productId]->getPrice();
                $this->appliedProducts[$productId] = $min;
            }
            $this->discount = -1 * $min * $this->discount * $this->discountValue / 100;
        }
    }
    
    public function getDiscount() {
        return $this->discount;
    }
    
    public function getAppliedProducts() {
        return $this->appliedProducts;
    }
}

//4.	Если одновременно выбраны А и один из [K,L,M], то стоимость выбранного продукта уменьшается на 5%
class Discount4 implements IDiscount {
    private $products;
    private $productId;
    private $productIds;
    //сумма скидки
    private $discount;
    private $discountValue;
    //товары, на которые применилась скидка [productId => $count]
    private $appliedProducts;
	private $applyedDiscounts; /*поле для хранения списка уже примененных скидок*/
    
    public function __construct($productId, array $productIds, $discountValue) {
        $this->products = array();
        $this->discount = 0;
        $this->productId = $productId;
        $this->productIds = $productIds;
        $this->discountValue = $discountValue;
        $this->appliedProducts = array();
    }
    
	/**
	* принимаем от обозреваемого объекта (DiscountManager)
	* список уже примененных скидок и записываем в поле  $applyedDiscounts
	* @param array $discounts массив содержащий строки названий классов примененых скидок
	**/
	public function onChanged(array $discounts){
		$this->applyedDiscounts = $discounts;
	}
	
    public function apply(array $products) {
        $this->products = $products;
        if ($this->products[$this->productId]->getCount() > 0) {
            foreach ($this->productIds as $productId) {
                if ($this->products[$productId]->getCount() > 0) {
                    $this->discount -= $this->products[$productId]->getPrice() * $this->discountValue / 100;
                    $this->appliedProducts[$productId] = 1;
                    break;
                }
            }
        }
    }
    
    public function getDiscount() {
        return $this->discount;
    }
    
    public function getAppliedProducts() {
        return $this->appliedProducts;
    }
}

//5.	Если пользователь выбрал одновременно 3 продукта, он получает скидку 5% от суммы заказа
//6.	Если пользователь выбрал одновременно 4 продукта, он получает скидку 10% от сумм	ы заказа
//7.	Если пользователь выбрал одновременно 5 продуктов, он получает скидку 20% от суммы заказа
class Discount5_6_7 implements IDiscount {
    private $products;
    private $productIdsExcept;
    //сумма скидки
    private $discount;
    private $discountValue;
    //товары, на которые применилась скидка [productId => $count]
    private $appliedProducts;
	private $applyedDiscounts; /*поле для хранения списка уже примененных скидок*/
    
    public function __construct($productCount, array $productIdsExcept, $discountValue) {
        $this->products = array();
        $this->productsOriginal = array();
        $this->discount = 0;
        $this->discountValue = $discountValue;
        $this->productIdsExcept = $productIdsExcept;
        $this->appliedProducts = array();
        $this->productCount = $productCount;
		/*XDebug*/
		xdebug_print_function_stack( 'Discount(): Functions stack' );
    }
    
	/**
	* принимаем от обозреваемого объекта (DiscountManager)
	* список уже примененных скидок и записываем в поле  $applyedDiscounts
	* @param array $discounts массив содержащий строки названий классов примененых скидок
	**/
	public function onChanged(array $discounts){
		$this->applyedDiscounts = $discounts;
	}
		
    public function apply(array $products) {
        /*реализация логики поведения в зависимости от уже примененных скидок*/
		/*(если такая скидка уже была, то более не применится)*/
		if ( in_array( get_class($this), $this->applyedDiscounts ) ) return;
		
		$this->products = $products;
        $amount = 0;
        foreach ($this->products as  $productId => $product) {
            if (in_array($productId, $this->productIdsExcept)) continue;
            $count = $this->products[$productId]->getCount();
            if (($amount + $count) >= $this->productCount) {
                
                $this->appliedProducts = $appliedProductsTmp;
                $this->appliedProducts[$productId] = $count - ($this->productCount - ($count + $amount));
                $this->discount = $this->discountValue / 100;
                break;
            }
            else {
                $appliedProductsTmp[$productId] = $count;
            }
            $amount += $count;
			/*XDebug*/
			xdebug_print_function_stack( 'applyDiscounts: Functions stack' );
        }
    }
    
    public function getDiscount() {
        return $this->discount;
    }
    
    public function getAppliedProducts() {
        return $this->appliedProducts;
    }
}

//управление применением скидок
interface IDiscountManager {
    public function setProducts(array $products);
    public function addDiscount(IDiscount $discount);
    public function applyDiscounts();
    public function getSum();
}

class DiscountManager implements IDiscountManager {
    private $products;
    private $sum;
    private $discount;
	private $applyedDiscounts;
    
    public function __construct() {
        $this->products = array();
        $this->discount = 0;
        $this->sum = 0;
		$this->applyedDiscounts = array();
    }
	
    public function setProducts(array $products) {
        $this->products = $products;
    }
    
    public function addDiscount(IDiscount $discount) {
        $this->discounts[] = $discount;
    }
	
	public function applyDiscounts() {
        $products = $this->products;
        /*XDebug*/
		xdebug_print_function_stack( 'applyDiscounts: Functions stack' );
        
		foreach ($this->products as $productId => $product) {
            $this->sum += $product->getPrice()*$product->getCount();
        }        
        $lastDiscountType = null;
        $lastDiscount = 0;
        foreach ($this->discounts as $discount) {
			
			//if (get_class($discount) == 'Discount5_6_7' && $lastDiscountType == 'Discount5_6_7' && $lastDiscount==0) continue;
            $discount->apply($products);
            
			/*записываем примененную скидку в $applyedDiscounts и посылаем список с уже примененными скидками обозревателям (IDiscount)*/
			/*обозреватели могут реализовать каждый свою логику поведения в зависимости от этих данных*/
			$this->applyedDiscounts[] = get_class($discount);
			foreach ( $this->discounts as $observer){
				$observer->onChanged($this->applyedDiscounts);
			}
			
			
			//число товаров, на которые применилась скидка
            $appliedProducts = $discount->getAppliedProducts();
            
            //скидка абсолютная
            if ($discount->getDiscount() <= 0) {
                $this->sum += $discount->getDiscount();
            }
            //скидка в процентах
            else {
                $this->sum *= (1 - $discount->getDiscount());
            }
                        
            //обновляем число доступных товаров, для которых можно применить скидку
            foreach ($appliedProducts as $productId => $countApplied) {
                $products[$productId]->updateCount(-$countApplied);
            }
            
            $lastDiscountType = get_class($discount);
            $lastDiscount = $discount->getDiscount();
        }
    }
    
    public function getSum() {
        return $this->sum;
    }
}

class ProductService {
    public function getResultSum(ICart $cart, IDiscountManager $discountManager) {
        $products = $cart->getProducts();
        $discountManager->setProducts($products);
        $discountManager->applyDiscounts();
        return $discountManager->getSum();
    }
}


//наполняем корзину
$cart = new Cart();
$cart->addProduct(new Product('A',1000,2));
$cart->addProduct(new Product('B',250,3));
$cart->addProduct(new Product('C',250,3));
$cart->addProduct(new Product('D',250,3));
$cart->addProduct(new Product('E',250,3));
$cart->addProduct(new Product('F',250,3));
$cart->addProduct(new Product('G',250,3));
$cart->addProduct(new Product('H',250,3));
$cart->addProduct(new Product('I',250,3));
$cart->addProduct(new Product('J',250,3));
$cart->addProduct(new Product('K',250,3));
$cart->addProduct(new Product('L',250,3));
$cart->addProduct(new Product('M',250,3));

//Задаем скидки
$discountManager = new DiscountManager();
$discountManager->addDiscount(new Discount1_2_3(array('A','B'), 10));
$discountManager->addDiscount(new Discount1_2_3(array('D','E'), 5));
$discountManager->addDiscount(new Discount1_2_3(array('E','F','G'), 5));
$discountManager->addDiscount(new Discount4('A', array('K','L','M'), 5));
$discountManager->addDiscount(new Discount5_6_7(3, array('A','C'), 5));
$discountManager->addDiscount(new Discount5_6_7(4, array('A','C'), 10));
$discountManager->addDiscount(new Discount5_6_7(5, array('A','C'), 20));

$ps = new ProductService();
echo $sum = $ps->getResultSum($cart, $discountManager);
