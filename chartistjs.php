<!DOCTYPE html>
<html>
  <head>
    <title>My first Chartist Tests</title>
    <link rel="stylesheet"
          href="/js/chartist/dist/chartist.min.css">
  </head>
  <body>
    <!-- Site content goes here !-->

	<div class="ct-chart ct-perfect-fourth"></div>

    <script src="/js/chartist/dist/chartist.min.js"></script>
	<script>
		
		var opt = {};		
		opt.val1 = 5;
		var x = opt.val || 10;
		alert(x);		
		

		function getRandomArbitary(min, max){
		  return Math.random() * (max - min) + min;
		}

		var now = new Date();
		
				
		var dates = [];
		for (var i = 10; i >= 0; i--){
			var date = new Date(now.getTime() - 3600*1000*i);			
			dates.push(date.toLocaleString());		
		}
		
		var values = [];
		
		for (var i = 10; i >= 0; i--){
			var value = getRandomArbitary(10.5, 12.5);			
			values.push(value);		
		}
		var data = {
		  // A labels array that can contain any sort of values
		  //labels: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri'],
			labels: dates,
		  // Our series array that contains series objects or in this case series data arrays
			// series: [[5, 2, 4, 2, 0]]
				series: [values]
		};

		var options = {
		  width: 500,
		  height: 300
		};

		// Create a new line chart object where as first parameter we pass in a selector
		// that is resolving to our chart container element. The Second parameter
		// is the actual data object.
		new Chartist.Line('.ct-chart', data, options);
	</script>
  </body>
</html>
